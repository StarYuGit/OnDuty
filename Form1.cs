using OnDuty.Models;
using System.Net;
using System.Runtime.Serialization.Json;

namespace OnDuty
{
    public partial class Form1 : Form
    {
        private List<ScheduleDate> scheduleDates = new List<ScheduleDate>();
        Dictionary<string, List<ScheduleDate>> dicMonthAndScheduleDates = new Dictionary<string, List<ScheduleDate>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string counterName = Properties.Settings.Default.counterName;
            //tb_CounterName.Text = counterName;
        }

        private void btn_InputHoliDay_Click(object sender, EventArgs e)
        {
            GetAllDateFromCSVFIle();
            ImportData();
            CreateTabFromDataList();
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
                            string year = "", month = "", day = "";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                throw;
            }

        }
        private void ImportData()
        {
            if (scheduleDates?.Any() is true)
            {
                dicMonthAndScheduleDates =
                    scheduleDates.GroupBy(x => x.month ?? "")
                                 .ToDictionary(x => x.Key, x => x.OrderBy(x => x.fullDate).ToList());
            }
        }
        private void CreateTabFromDataList()
        {
            if (dicMonthAndScheduleDates.Count > 0)
            {
                foreach (string month in dicMonthAndScheduleDates.Keys.OrderBy(x => x))
                {
                    TabPage tabPage = new TabPage();
                    tabPage.Text = month.TrimStart('0') + "月份";
                    tabDates.Controls.Add(tabPage);
                    List<ScheduleDate> scheduleDates = dicMonthAndScheduleDates[month];
                    ListView listView = new ListView
                    {
                        Dock = DockStyle.Fill,     // 讓 ListView 充滿整個 TabPage
                        View = View.Details,       // 詳細資料模式
                        FullRowSelect = true,
                        GridLines = true
                    };
                    listView.Columns.Add("日期", 200);
                    listView.Columns.Add("星期", 50);
                    listView.Columns.Add("備註", 300);
                    listView.SelectedIndexChanged += (sender, e) => listView_SelectedIndexChanged(listView);
                    List<ListViewItem> listViewItems = new List<ListViewItem>();

                    foreach (ScheduleDate item in scheduleDates)
                    {
                        string displayText = "";
                        displayText += (item.month ?? "").TrimStart('0') + "月" + (item.day ?? "").TrimStart('0') + "日";
                        ListViewItem lvi = new ListViewItem(displayText);
                        lvi.SubItems.Add(item.week);
            
                        lvi.SubItems.Add(item.remark);
                        if (item.dayType == "2")
                            lvi.ForeColor = Color.Red;

                        listViewItems.Add(lvi);
                    }
                    listView.Items.AddRange(listViewItems.ToArray());
                    tabPage.Controls.Add(listView);
                }
            }
        }

        private void listView_SelectedIndexChanged(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                tb_SelectDateResult.Text = listView.SelectedItems[0].Text;
            }
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
    }
}
