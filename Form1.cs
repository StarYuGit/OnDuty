using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using OnDuty.Models;
using System.Diagnostics;

namespace OnDuty
{
    public partial class Form1 : Form
    {
        private List<ScheduleDate> scheduleDates = new List<ScheduleDate>();
        private List<ScheduleDate> scheduleNoHoliDayDates = new List<ScheduleDate>();
        private List<ScheduleDate> currentScheduleDates = new();
        private bool isDebug = true;
        private bool isDuty = false;
        List<string> persons = new List<string>();
        Dictionary<string, List<ScheduleDate>> dicMonthAndScheduleDates = new Dictionary<string, List<ScheduleDate>>();
        string selectResult = "";
        public Form1()
        {
            InitializeComponent();
            lL_SchedulePage.Links.Add(0, lL_SchedulePage.Text.Length, "https://data.gov.tw/dataset/14718");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_CounterName.Text = Properties.Settings.Default.counterName;
            tb_InputPerson.Text = Properties.Settings.Default.personFilePath;
        }

        private void btn_InputHoliDay_Click(object sender, EventArgs e)
        {
            GetAllDateFromCSVFIle();
            InputCurrentScheduleDatasToDictionary();
            CreateTabFromDataList(dicMonthAndScheduleDates);
        }
        private void InputCurrentScheduleDatasToDictionary()
        {
            if (chk_ShowHoliDay.Checked)
                this.currentScheduleDates = this.scheduleDates;
            else
                this.currentScheduleDates = this.scheduleNoHoliDayDates;
            ImportHolidayData();
        }
        private void btn_InputPerson_Click(object sender, EventArgs e)
        {
            GetPersonDataFrom();
            CreatePersonViewList();
        }
        private void GetPersonDataFrom()
        {
            if (isDebug)
                tb_InputPerson.Text = "C:\\Projects\\OnDuty\\person.txt";
            string personFile = tb_InputPerson.Text;
            try
            {
                if (!string.IsNullOrEmpty(personFile))
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
                else
                {
                    MessageBox.Show("請先選擇排班人員檔案");
                    return;
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
            if (isDebug)
                tb_InputHoliDay.Text = "C:\\Projects\\OnDuty\\114年中華民國政府行政機關辦公日曆表(修正版).csv";

            string holidayFile = tb_InputHoliDay.Text;

            List<ScheduleDate> models = [];
            try
            {
                if (!string.IsNullOrEmpty(holidayFile))
                {
                    using (StreamReader holiday = new StreamReader(holidayFile))
                    {
                        string? line;
                        bool isWorkDayData = false;
                        int fullDate = 0;
                        while ((line = holiday.ReadLine()) != null)
                        {
                            if ("西元日期,星期,是否放假,備註".Equals(line))
                            {
                                isWorkDayData = true;
                                continue;
                            }
                            else if (isWorkDayData is false)
                            {
                                MessageBox.Show("檔案錯誤：\n請下載「xxx年中華民國政府行政機關辦公日曆表」");
                                return;
                            }
                                
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

                        }
                    }
                }
                else
                {
                    MessageBox.Show("請先選擇行事曆檔案");
                    return;
                }

                    this.scheduleDates = models;
                this.scheduleNoHoliDayDates = models.Where(x => x.dayType == "0").ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                throw;
            }

        }
        private void ImportHolidayData()
        {
            if (this.currentScheduleDates?.Any() is true)
            {
                dicMonthAndScheduleDates =
                    this.currentScheduleDates.GroupBy(x => x.month ?? "")
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
                        lvi.Tag = item.fullDate + "," + item.dayType;
                        lvi.SubItems.Add(item.week);

                        if (isDuty)
                            lvi.SubItems.Add(item.person);
                        if (chk_ShowHoliDay.Checked)
                            lvi.SubItems.Add(item.remark);
                        if (item.dayType == "2")
                            lvi.ForeColor = System.Drawing.Color.Red;

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
            listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView.Columns.Add("星期", 60, HorizontalAlignment.Center);

            if (isDuty)
                listView.Columns.Add("值班人員", 120);
            if (chk_ShowHoliDay.Checked)
                listView.Columns.Add("備註", 300);

            listView.SelectedIndexChanged += (sender, e) => listView_SelectedIndexChanged(listView);
        }
        private void listView_SelectedIndexChanged(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string[] tagType = ((listView.SelectedItems[0].Tag ?? new()).ToString() ?? "").Split(",");
                if ("2".Equals(tagType[1]))
                {
                    MessageBox.Show("排班起始日不可選擇假日。");
                    tb_SelectDateResult.Text = "";
                    return;
                }
                selectResult = tagType[0];
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
                openFileDialog.Title = "請選擇檔案";
                openFileDialog.Filter = "csv檔 (*.csv)|*.csv"; 
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tb_InputHoliDay.Text = openFileDialog.FileName;
                }
            }
        }

        private void btn_Duty_Click(object sender, EventArgs e)
        {
            if (this.scheduleDates?.Any() is false)
            {
                MessageBox.Show("尚未匯入行事曆資料。");
                return;
            }
            if (this.persons?.Any() is false)
            {
                MessageBox.Show("尚未匯入排班人員資料。");
                return;
            }
            isDuty = true;
            List<ScheduleDate> scheduleDates = new List<ScheduleDate>();

            if (!string.IsNullOrEmpty(selectResult))
            {
                this.scheduleDates = (this.scheduleDates ?? []).Where(x => x.fullDate >= Convert.ToInt32(selectResult)).ToList();
                this.scheduleNoHoliDayDates = this.scheduleNoHoliDayDates.Where(x => x.fullDate >= Convert.ToInt32(selectResult)).ToList();
            }
            InputCurrentScheduleDatasToDictionary();


            CreateDuty(persons ?? []);
            Properties.Settings.Default.counterName = tb_CounterName.Text;
            Properties.Settings.Default.personFilePath = tb_InputPerson.Text;
            Properties.Settings.Default.Save();
            btn_ExportDutyResult.Visible = true;
        }
        private void CreateDuty(List<string> persons)
        {
            int i = 0;
            bool isCounter = chk_CounterFirst.Checked;
            if (!string.IsNullOrEmpty(tb_SelectPersonResult.Text))
            {
                i = persons.IndexOf(tb_SelectPersonResult.Text);
                if (i == -1)
                    i = 0;
            }

            foreach (ScheduleDate scheduleDate in this.currentScheduleDates)
            {
                if (i == persons.Count)
                    i = 0;
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


            ImportHolidayData();
            CreateTabFromDataList(this.dicMonthAndScheduleDates);
        }

        private void chk_ShowHoliDay_CheckedChanged(object sender, EventArgs e)
        {
            InputCurrentScheduleDatasToDictionary();
            CreateTabFromDataList(this.dicMonthAndScheduleDates);
        }

        private void btn_ExportDutyResult_Click(object sender, EventArgs e)
        {
            ExportDutyResult();
        }

        private void ExportDutyResult()
        {
            if (this.dicMonthAndScheduleDates.Count > 0)
            {
                // 建立 Excel 檔案
                using (var workbook = new XLWorkbook())
                {
                    var worksheet1 = workbook.Worksheets.Add("櫃臺輪值表");
                    
                    int y = 1;
                    foreach (string month in this.dicMonthAndScheduleDates.Keys.OrderBy(x => x))
                    {
                        int x = 2;
                        worksheet1.Cell(1, y).Value = month.TrimStart('0') + "月份";
                        worksheet1.Cell(1, y).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet1.Range(1, y, 1, y + 2).Merge();
                        List<ScheduleDate> scheduleDates = dicMonthAndScheduleDates[month];
                        foreach (ScheduleDate scheduleDate in scheduleDates)
                        {
                            worksheet1.Cell(x, y).Value = scheduleDate.month + "/" + scheduleDate.day;
                            worksheet1.Cell(x, y).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet1.Cell(x, y + 1).Value = scheduleDate.week;
                            worksheet1.Cell(x, y + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet1.Cell(x, y + 2).Value = scheduleDate.person;
                            if (chk_ShowHoliDay.Checked)
                            {
                                worksheet1.Cell(x, y + 3).Value = scheduleDate.remark;
                                worksheet1.Cell(x, y).Style.Font.FontColor = XLColor.Red;
                                worksheet1.Cell(x, y + 1).Style.Font.FontColor = XLColor.Red;
                                worksheet1.Cell(x, y + 2).Style.Font.FontColor = XLColor.Red;
                                worksheet1.Cell(x, y + 3).Style.Font.FontColor = XLColor.Red;
                            }
                            else
                            {
                                worksheet1.Cell(x, y).Style.Font.FontColor = XLColor.Black;
                                worksheet1.Cell(x, y + 1).Style.Font.FontColor = XLColor.Black;
                                worksheet1.Cell(x, y + 2).Style.Font.FontColor = XLColor.Black;
                                worksheet1.Cell(x, y + 3).Style.Font.FontColor = XLColor.Black;
                            }
                                x++;
                        }
                        if (chk_ShowHoliDay.Checked)
                            y += 4;
                        else
                            y += 3;
                    }
                    // ===========================
                    // 手動計算每欄最長字元長度，並設定欄寬
                    // ===========================

                    var usedRange = worksheet1.RangeUsed();
                    if (usedRange != null)
                    {
                        int lastRow = usedRange.LastRow().RowNumber();
                        int lastCol = usedRange.LastColumn().ColumnNumber();

                        // 只考慮第 2 列以後
                        for (int c = 1; c <= lastCol; c++)
                        {
                            // 找出這一欄（第 2 列以後）的最長字串長度
                            int maxLen = 0;
                            for (int r = 2; r <= lastRow; r++)
                            {
                                var val = worksheet1.Cell(r, c).GetString();
                                if (!string.IsNullOrEmpty(val))
                                {
                                    // 取字數長度（中文或英文都計）
                                    maxLen = Math.Max(maxLen, val.Length);
                                }
                            }

                            // 設定寬度：字數 * 1.5 + 額外間距
                            worksheet1.Column(c).Width = maxLen * 1.5 + 2;
                        }
                    }

                    var worksheet2 = workbook.Worksheets.Add("人員清單");

                    for (int i = 0; i < persons.Count; i++)
                    {
                        worksheet2.Cell(i + 1, 1).Value = persons[i];
                    }
                    
                    // 儲存檔案
                    workbook.SaveAs("櫃臺輪值表_"+DateTime.Now.ToString("yyyyMMddhhmmss")+".xlsx");
                }
            }
        }

        private void lL_SchedulePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string targetUrl = (e.Link ?? new()).LinkData as string ?? "";

            if (!string.IsNullOrEmpty(targetUrl))
            {
                try
                {
                    // 使用預設瀏覽器開啟連結
                    Process.Start(new ProcessStartInfo(targetUrl) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("無法開啟連結: " + ex.Message);
                }
            }
        }

        private void btn_InputPersonFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "請選擇檔案";
                openFileDialog.Filter = "txt檔 (*.txt)|*.txt";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tb_InputPerson.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
