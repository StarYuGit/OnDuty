using OnDuty.Models;

namespace OnDuty
{
    public partial class Form1 : Form
    {
        private List<ScheduleDate> scheduleDates = new List<ScheduleDate>();
        private List<ScheduleDate> scheduleNoHoliDayDates = new List<ScheduleDate>();
        bool isDuty = false;
        List<string> persons = new List<string>();
        Dictionary<string, List<ScheduleDate>> dicMonthAndScheduleDates = new Dictionary<string, List<ScheduleDate>>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string counterName = Properties.Settings.Default.counterName;
            tb_CounterName.Text = counterName;
        }

        private void btn_InputHoliDay_Click(object sender, EventArgs e)
        {
            GetAllDateFromCSVFIle();
            if (chk_ShowHoliDay.Checked)
                ImportHolidayData(scheduleDates);
            else
                ImportHolidayData(scheduleNoHoliDayDates);
            CreateTabFromDataList(dicMonthAndScheduleDates);
        }
        private void btn_InputPerson_Click(object sender, EventArgs e)
        {
            GetPersonDataFrom();
            CreatePersonViewList();
        }
        private void GetPersonDataFrom()
        {
            tb_InputPerson.Text = "C:\\Projects\\OnDuty\\person.txt";
            string personFile = tb_InputPerson.Text;
            try
            {
                using (StreamReader person = new StreamReader(personFile))
                {
                    string? line = "";
                    while ((line = person.ReadLine()) != null)
                    {
                        persons.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                throw;
            }
        }
        private void GetAllDateFromCSVFIle()
        {

            tb_InputHoliDay.Text = "C:\\Projects\\OnDuty\\114年中華民國政府行政機關辦公日曆表(修正版).csv";

            string holidayFile = tb_InputHoliDay.Text;

            List<ScheduleDate> models = [];
            try
            {
                using (StreamReader holiday = new StreamReader(holidayFile))
                {
                    string? line;
                    bool isWorkDayData = false;
                    int fullDate = 0;
                    while ((line = holiday.ReadLine()) != null)
                    {
                        if (isWorkDayData)
                        {
                            fullDate = 0;
                            string[] dArray = line.Split(',');
                            if (int.TryParse(dArray[0], out fullDate))
                            {
                                ScheduleDate scheduleDate =
                                    new ScheduleDate(fullDate,
                                                     dArray[0].Substring(0, 4),
                                                        dArray[0].Substring(4, 2),
                                                        dArray[0].Substring(6, 2),
                                                        dArray[1],
                                                        dArray[2],
                                                        !string.IsNullOrEmpty(dArray[3]) ? dArray[3] : null
                                                     );
                                models.Add(scheduleDate);
                            }
                        }
                        if ("西元日期,星期,是否放假,備註".Equals(line))
                            isWorkDayData = true;
                    }
                }
                scheduleDates = models;
                scheduleNoHoliDayDates = models.Where(x => x.dayType == "0").ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                throw;
            }

        }
        private void ImportHolidayData(List<ScheduleDate> scheduleDates)
        {
            if (scheduleDates?.Any() is true)
            {
                dicMonthAndScheduleDates =
                    scheduleDates.GroupBy(x => x.month ?? "")
                                 .ToDictionary(x => x.Key, x => x.OrderBy(x => x.fullDate).ToList());
            }
        }
        private void CreatePersonViewList()
        {
            if (persons?.Any() is true)
            {
                lv_person.Columns.Add("姓名", 100);
                lv_person.FullRowSelect = true;
                lv_person.GridLines = true;
                List<ListViewItem> lviPoersons = new List<ListViewItem>();
                foreach (string person in persons)
                {
                    ListViewItem lvi = new ListViewItem(person);
                    lviPoersons.Add(lvi);

                }
                lv_person.Items.AddRange(lviPoersons.ToArray());
                lv_person.SelectedIndexChanged += (sender, e) => lv_person_SelectedIndexChanged(lv_person);
            }
        }

        private void CreateTabFromDataList(Dictionary<string, List<ScheduleDate>> dicMonthAndScheduleDates)
        {
            tabDates.TabPages.Clear();
            if (dicMonthAndScheduleDates.Count > 0)
            {
                foreach (string month in dicMonthAndScheduleDates.Keys.OrderBy(x => x))
                {
                    TabPage tabPage = new TabPage();
                    tabPage.Text = month.TrimStart('0') + "月份";
                    tabDates.Controls.Add(tabPage);
                    List<ScheduleDate> scheduleDates = dicMonthAndScheduleDates[month];
                    ListView listView = new();

                    List<ListViewItem> lvisHoliDay = new List<ListViewItem>();

                    foreach (ScheduleDate item in scheduleDates)
                    {
                        string displayText = "";
                        displayText += (item.year ?? "") + "/" + (item.month ?? "").TrimStart('0') + "/" + (item.day ?? "").TrimStart('0');

                        ListViewItem lvi = new ListViewItem(displayText);
                        lvi.SubItems.Add(item.week);
                        lvi.SubItems.Add(item.remark);
                        if (isDuty)
                            lvi.SubItems.Add(item.person);
                        if (item.dayType == "2")
                            lvi.ForeColor = Color.Red;

                        lvisHoliDay.Add(lvi);
                    }
                    listView.Items.AddRange(lvisHoliDay.ToArray());


                    tabPage.Controls.Add(listView);
                    InitListView(listView);
                }
            }
        }
        //初始化ListView
        private void InitListView(ListView listView)
        {
            listView.Dock = DockStyle.Fill;     // 讓 ListView 充滿整個 TabPage
            listView.View = View.Details;       // 詳細資料模式
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Columns.Add("日期", 70, HorizontalAlignment.Center);
            listView.Columns.Add("星期", 100, HorizontalAlignment.Center);
            if (chk_ShowHoliDay.Checked)
            {
                listView.Columns.Add("備註", 300);
                listView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            if (isDuty)
                listView.Columns.Add("值班人員", 100);
            else
                listView.SelectedIndexChanged += (sender, e) => listView_SelectedIndexChanged(listView);
            listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void listView_SelectedIndexChanged(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                tb_SelectDateResult.Text = listView.SelectedItems[0].Text;
            }
        }
        private void lv_person_SelectedIndexChanged(ListView lv_person)
        {
            if (lv_person.SelectedItems.Count > 0)
                tb_SelectPersonResult.Text = lv_person.SelectedItems[0].Text;
        }
        private void btn_InputHoliDayFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tb_InputHoliDay.Text = openFileDialog.FileName;
                }
            }
        }

        private void btn_Duty_Click(object sender, EventArgs e)
        {
            if (scheduleDates?.Any() is false)
            {
                MessageBox.Show("尚未匯入正確行事曆資料。");
                return;
            }
            if (persons?.Any() is false)
            {
                MessageBox.Show("尚未匯入排班人員資料。");
                return;
            }
            isDuty = true;
            if (chk_ShowHoliDay.Checked)
                CreateDuty(scheduleDates ?? [], persons ?? []);
            else
                CreateDuty(scheduleNoHoliDayDates ?? [], persons ?? []);
        }
        private void CreateDuty(List<ScheduleDate> scheduleDates, List<string> persons)
        {
            int i = 0;
            bool isCounter = chk_CounterFirst.Checked;
            foreach (ScheduleDate scheduleDate in scheduleDates)
            {
                if (i == persons.Count)                    i = 0;
                if (scheduleDate.dayType == "0")
                {
                    if (!string.IsNullOrEmpty(tb_CounterName.Text) && isCounter)
                        scheduleDate.person = tb_CounterName.Text;
                    else
                    {
                        scheduleDate.person = persons[i];
                        i++;
                    }
                    isCounter = !isCounter;
                }
            }
            CreateTabFromDataList(dicMonthAndScheduleDates);
        }

        private void chk_ShowHoliDay_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowHoliDay.Checked)
                ImportHolidayData(scheduleDates);
            else
                ImportHolidayData(scheduleNoHoliDayDates);
            CreateTabFromDataList(dicMonthAndScheduleDates);
        }
    }
}
