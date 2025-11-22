using ClosedXML.Excel;
using OnDuty.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace OnDuty
{
    public partial class Form1 : Form
    {
        private List<ScheduleDate> scheduleDates = new List<ScheduleDate>();
        private List<ScheduleDate> scheduleNoHoliDayDates = new List<ScheduleDate>();
        private List<ScheduleDate> currentScheduleDates = new();
        private bool isDebug = true;
        private bool isDuty = false;
        private List<string> persons = new List<string>();
        private Dictionary<string, List<ScheduleDate>> dicMonthAndScheduleDates = new Dictionary<string, List<ScheduleDate>>();
        private string selectResult = "";
        private string year = "";
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 固定邊框
            this.MaximizeBox = false; // 禁用最大化按鈕
            lL_SchedulePage.Links.Add(0, lL_SchedulePage.Text.Length, "https://data.gov.tw/dataset/14718"); //在LabelLink上加入連結
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 載入時把Settings的值帶入
            tb_InputHoliDay.Text = Properties.Settings.Default.scheduleFilePath;
            tb_InputPerson.Text = Properties.Settings.Default.personFilePath;
            tb_CounterName.Text = Properties.Settings.Default.counterName;
            chk_CounterFirst.Checked = Properties.Settings.Default.counterFirst;
            chk_ShowHoliDay.Checked = Properties.Settings.Default.showHoliday;
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
                    if (persons.Count > 0)
                        persons = [];
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
            if (!string.IsNullOrEmpty(holidayFile))
            {
                Match match = Regex.Match(holidayFile, @"\d+");
                if (match.Success)
                    year = match.Value;
            }

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
                if (models?.Any() is true)
                {
                    bool isDiffWeek = false;
                    foreach (ScheduleDate model in models)
                    {
                        model.isDiffWeek = isDiffWeek;
                        if ("日".Equals(model.week))
                            isDiffWeek = !isDiffWeek;
                    }
                }
                this.scheduleDates = models ?? [];
                this.scheduleNoHoliDayDates = (models ?? []).Where(x => x.dayType == "0").ToList();
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
            lv_person.Items.Clear();
            lv_person.Columns.Clear();
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
                    this.btn_InputHoliDay_Click(this, EventArgs.Empty);
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
            SaveSetting();
            tb_SelectDateResult.Text = "";
            tb_SelectPersonResult.Text = "";
            selectResult = "";
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
            tb_SelectDateResult.Text = "";
            tb_SelectPersonResult.Text = "";
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
                string message = string.Empty;
                string fileTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                try
                {
                    // 建立 Excel 檔案
                    using (var workbook = new XLWorkbook())
                    {

                        var worksheet1 = workbook.Worksheets.Add("櫃臺輪值表");

                        int y = 1;

                        foreach (string month in this.dicMonthAndScheduleDates.Keys.OrderBy(x => x))
                        {
                            int x = 2;
                            worksheet1.Style.Font.FontName = "標楷體";
                            worksheet1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet1.Style.Font.FontSize = 12;

                            worksheet1.Cell(1, y).Value = month.TrimStart('0') + "月份";
                            worksheet1.Cell(1, y).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet1.Cell(1, y).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            worksheet1.Range(1, y, 1, y + 2).Merge();
                            List<ScheduleDate> scheduleDates = dicMonthAndScheduleDates[month];
                            foreach (ScheduleDate scheduleDate in scheduleDates)
                            {
                                worksheet1.Cell(x, y).Value = (scheduleDate.month ?? "").TrimStart('0') + "月" + (scheduleDate.day ?? "").TrimStart('0') + "日";
                                worksheet1.Cell(x, y).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                if (scheduleDate.isDiffWeek)
                                    worksheet1.Cell(x, y).Style.Fill.BackgroundColor = XLColor.LightYellow;
                                else
                                    worksheet1.Cell(x, y).Style.Fill.BackgroundColor = XLColor.LightBlue;

                                worksheet1.Cell(x, y + 1).Value = scheduleDate.week;
                                worksheet1.Cell(x, y + 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                                worksheet1.Cell(x, y + 2).Value = scheduleDate.person;
                                worksheet1.Cell(x, y + 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                if (!string.IsNullOrEmpty(tb_CounterName.Text) && tb_CounterName.Text.Equals(scheduleDate.person))
                                    worksheet1.Cell(x, y + 2).Style.Font.FontColor = XLColor.Blue;
                                if (chk_ShowHoliDay.Checked)
                                {
                                    if ("2".Equals(scheduleDate.dayType))
                                    {
                                        worksheet1.Cell(x, y + 2).Value = scheduleDate.remark;
                                        worksheet1.Cell(x, y + 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                        for (int i = y; i <= y + 2; i++)
                                        {
                                            worksheet1.Cell(x, i).Style.Font.FontColor = XLColor.Red;
                                        }
                                    }
                                }

                                x++;
                            }
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
                                //// 找出這一欄（第 2 列以後）的最長字串長度
                                //int maxLen = 0;
                                //for (int r = 2; r <= lastRow; r++)
                                //{
                                //    var val = worksheet1.Cell(r, c).GetString();
                                //    if (!string.IsNullOrEmpty(val))
                                //    {
                                //        // 取字數長度（中文或英文都計）
                                //        maxLen = Math.Max(maxLen, val.Length);
                                //    }
                                //}

                                //// 設定寬度：字數 * 1.5 + 額外間距
                                //worksheet1.Column(c).Width = maxLen * 1.5 + 2;
                                switch (c % 3) // 固定欄寬
                                {
                                    case 2:
                                        worksheet1.Column(c).Width = 4;
                                        break;
                                    case 3:
                                        worksheet1.Column(c).Width = 10;
                                        break;

                                }
                            }
                        }

                        var worksheet2 = workbook.Worksheets.Add("人員清單");

                        for (int i = 0; i < persons.Count; i++)
                        {
                            worksheet2.Cell(i + 1, 1).Value = persons[i];
                        }
                        worksheet2.Style.Font.FontName = "標楷體";
                        worksheet2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        worksheet2.Style.Font.FontSize = 12;
                        string fileName1 = "一樓櫃台中午值班表-Y" + this.year + "_" + fileTime + ".xlsx";
                        // 儲存檔案
                        workbook.SaveAs(fileName1);
                        if (File.Exists(fileName1))
                            message += "檔案已儲存至：" + Path.GetFullPath(fileName1) + Environment.NewLine;
                        else
                            message += fileName1 + this.year + "檔案儲存失敗。" + Environment.NewLine;
                    }
                    MessageBox.Show(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("匯出檔案出現未預期錯誤：" + ex.ToString());
                }
            }
        }
        private void btn_OpenTakeLeaveSettingForm_Click(object sender, EventArgs e)
        {
            using (TakeLeaveSettingsForm takeLeaveSettingForm = new TakeLeaveSettingsForm())
            {
                takeLeaveSettingForm.ShowDialog();
            }
            //ExportTakeLeaveList(5);
        }
        private void ExportTakeLeaveList(int columns)
        {
            if (this.dicMonthAndScheduleDates.Count > 0)
            {
                string message = string.Empty;
                string fileTime = DateTime.Now.ToString("yyyyMMddhhmmss");
                try
                {
                    // 建立 Excel 檔案
                    using (var workbook = new XLWorkbook())
                    {
                        CreateParameteWorkSheet(workbook); //建立參數頁
                        IXLWorksheet ws = workbook.Worksheets.First();
                        IXLRange? takeLeaveTypeRange = GetDataRange(ws, "A", 2, 100);
                        IXLRange? takeLeaveTimePeriodsTypeRange = GetDataRange(ws, "B", 2, 100);

                        foreach (string month in this.dicMonthAndScheduleDates.Keys.OrderBy(x => x))
                        {
                            //設定Sheet
                            var worksheet = workbook.Worksheets.Add(month.TrimStart('0') + "月");
                            worksheet.SheetView.Freeze(1, 2); //凍結窗格
                            worksheet.Style.Font.FontName = "標楷體";
                            worksheet.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            worksheet.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                            worksheet.Style.Font.FontSize = 14;

                            //標題
                            worksheet.Cell(1, 1).Value = "日期";
                            worksheet.Cell(1, 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                            worksheet.Column(1).Width = 10;
                            worksheet.Cell(1, 2).Value = "星期/假期";
                            worksheet.Cell(1, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                            worksheet.Column(2).Width = 14;

                            int index = 1;
                            for (int i = 1; i <= columns * 2; i++)
                            {
                                worksheet.Cell(1, i + 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                if (i % 2 == 1)
                                {
                                    worksheet.Cell(1, i + 2).Value = index;
                                    var indexTitleRange = worksheet.Range(1, i + 2, 1, i + 3);
                                    indexTitleRange.Merge();
                                    indexTitleRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                                    worksheet.Column(i + 2).Width = 15; //每個請假格寬度
                                    index++;
                                }
                            }
                            // 日期
                            List<ScheduleDate> scheduleDates = dicMonthAndScheduleDates[month];
                            int row = 2;

                            foreach (ScheduleDate scheduleDate in scheduleDates)
                            {
                                worksheet.Cell(row, 1).Value = (scheduleDate.month ?? "").TrimStart('0') + "月" + (scheduleDate.day ?? "").TrimStart('0') + "日";
                                worksheet.Cell(row, 2).Value = scheduleDate.week;
                                worksheet.Cell(row, 2).Style.Font.FontSize = 16;
                                worksheet.Cell(row, 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                                worksheet.Cell(row, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                                for (int i = 1; i <= columns * 2; i++)
                                {
                                    worksheet.Cell(row, i + 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                }

                                if ("2".Equals(scheduleDate.dayType))
                                {
                                    if (chk_ShowHoliDay.Checked)
                                    {
                                        if (!string.IsNullOrEmpty(scheduleDate.remark))
                                            worksheet.Cell(row, 3).Value = "【" + scheduleDate.remark + "】";

                                        for (int i = 1; i <= 3; i++)
                                        {
                                            worksheet.Cell(row, i).Style.Font.FontColor = XLColor.Red;
                                            worksheet.Cell(row, i).Style.Fill.BackgroundColor = XLColor.LightGray;
                                        }
                                        worksheet.Range(row, 3, row, 2 + (columns * 2)).Merge();
                                    }
                                }
                                else
                                {
                                    worksheet.Row(row).Height = 30; //工作日行高度
                                    for (int i = 1; i <= (columns * 2) + 2; i += 2)
                                    {
                                        worksheet.Cell(row, i + 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                        //每日主格
                                        if (i > 2)
                                        {
                                            //姓名區塊
                                            var takeLeavePerson = worksheet.Cell(row, i);
                                            takeLeavePerson.Style.Font.FontColor = XLColor.Blue;
                                            takeLeavePerson.Style.Font.FontSize = 14;
                                            //假別區塊
                                            var takeLeaveTypeCell = worksheet.Cell(row, i + 1);
                                            takeLeaveTypeCell.Value = "";
                                            var dv_TakeLeaveType = takeLeaveTypeCell.CreateDataValidation();
                                            dv_TakeLeaveType.AllowedValues = XLAllowedValues.List;        // 設為 List 型
                                            if (takeLeaveTypeRange != null)
                                                dv_TakeLeaveType.List(takeLeaveTypeRange);
                                            dv_TakeLeaveType.InputTitle = "假別選擇";
                                            dv_TakeLeaveType.InputMessage = "請從下拉選單中選擇";
                                            dv_TakeLeaveType.InCellDropdown = true;
                                            dv_TakeLeaveType.ShowErrorMessage = false;
                                        }
                                    }
                                    row++;
                                    //每日次格區塊
                                    worksheet.Cell(row, 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                                    worksheet.Cell(row, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                                    for (int i = 3; i <= (columns * 2) + 2; i += 2)
                                    {
                                        //請假時段區塊
                                        var takeLeaveTimePeriodCell = worksheet.Cell(row, i);
                                        //takeLeaveTimePeriodCell.Value = "整天(08:50～17:00)";
                                        var dv_takeLeaveTimePeriod = takeLeaveTimePeriodCell.CreateDataValidation();
                                        dv_takeLeaveTimePeriod.AllowedValues = XLAllowedValues.List;
                                        if (takeLeaveTimePeriodsTypeRange != null)
                                            dv_takeLeaveTimePeriod.List(takeLeaveTimePeriodsTypeRange);
                                        dv_takeLeaveTimePeriod.InputTitle = "選擇請假時間";
                                        dv_takeLeaveTimePeriod.InputMessage = "請從下拉選單中選擇";
                                        dv_takeLeaveTimePeriod.InCellDropdown = true;
                                        dv_takeLeaveTimePeriod.ShowErrorMessage = false;
                                        worksheet.Range(row, i, row, i + 1).Merge();

                                        worksheet.Range(row - 1, i, row, i + 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                                    }
                                    worksheet.Range(row - 1, 1, row, 1).Merge();
                                    worksheet.Range(row - 1, 2, row, 2).Merge();
                                }
                                row++;
                            }

                        }
                        ws.Position = workbook.Worksheets.Count; //參數頁移到最後面

                        string fileName2 = "科員請假紀錄-Y" + this.year + "_" + fileTime + ".xlsx";
                        // 儲存檔案
                        workbook.SaveAs(fileName2);
                        if (File.Exists(fileName2))
                            message += "檔案已儲存至：" + Path.GetFullPath(fileName2) + Environment.NewLine;
                        else
                            message += fileName2 + this.year + "檔案儲存失敗。" + Environment.NewLine;
                    }
                    MessageBox.Show(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("匯出檔案出現未預期錯誤：" + ex.ToString());
                }
            }
        }
        /// <summary>
        /// 建立參數頁
        /// </summary>
        /// <param name="wb"></param>
        private void CreateParameteWorkSheet(IXLWorkbook wb)
        {
            //參數頁
            var parameterWorkSheet = wb.Worksheets.Add("參數頁");

            parameterWorkSheet.Style.Font.FontName = "標楷體";
            parameterWorkSheet.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            parameterWorkSheet.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            parameterWorkSheet.Style.Font.FontSize = 12;


            parameterWorkSheet.Cell(1, 1).Value = "請假種類";
            parameterWorkSheet.Cell(1, 1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            parameterWorkSheet.Column(1).Width = 10;

            string taskLeaveTypeString = Properties.Settings.Default.takeLeaveType;
            if (!string.IsNullOrEmpty(taskLeaveTypeString))
            {
                List<string> taskLeaveTypes = taskLeaveTypeString.Split(",").ToList();
                if (taskLeaveTypes?.Any() is true)
                {
                    for (int i = 0; i < taskLeaveTypes.Count; i++)
                    {
                        parameterWorkSheet.Cell(i + 2, 1).Value = taskLeaveTypes[i];
                    }
                }
            }

            parameterWorkSheet.Cell(1, 2).Value = "時段選項";
            //parameterWorkSheet.Cell(1, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            parameterWorkSheet.Column(2).Width = 20;
            string takeLeaveTimePeriodsString = Properties.Settings.Default.takeLeaveTimePeriodsType;
            if (!string.IsNullOrEmpty(takeLeaveTimePeriodsString))
            {
                List<string> takeLeaveTimePeriods = takeLeaveTimePeriodsString.Split(",").ToList();
                if (takeLeaveTimePeriods?.Any() is true)
                {
                    for (int i = 0; i < takeLeaveTimePeriods.Count; i++)
                    {
                        parameterWorkSheet.Cell(i + 2, 2).Value = takeLeaveTimePeriods[i];
                    }
                    return;
                }
            }
        }
        private IXLRange? GetDataRange(IXLWorksheet ws, string column, int rowStartNumber, int rowEndNumber)
        {
            IXLRange? range = null;

            range = ws.Range($"{column}{rowStartNumber}:{column}{rowEndNumber}");


            // 若需要回傳 Range 型別，請根據實際需求調整
            return range;
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
                    this.btn_InputPerson_Click(this, EventArgs.Empty);
                }
            }
        }

        private void btn_SaveSetting_Click(object sender, EventArgs e)
        {
            SaveSetting();
            MessageBox.Show("設定已儲存");
        }

        private void btn_ClearSetting_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "確定清除所有儲存設定？",            // 訊息文字
                "確認",                 // 視窗標題
                MessageBoxButtons.YesNo, // 按鈕樣式
                MessageBoxIcon.Question  // 圖示
            );

            if (result == DialogResult.Yes)
            {
                tb_InputHoliDay.Text = "";
                tb_InputPerson.Text = "";
                tb_CounterName.Text = "";
                chk_CounterFirst.Checked = false;
                chk_ShowHoliDay.Checked = false;
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                MessageBox.Show("設定已清除");
            }
        }
        private void SaveSetting()
        {
            Properties.Settings.Default.scheduleFilePath = tb_InputHoliDay.Text;
            Properties.Settings.Default.personFilePath = tb_InputPerson.Text;
            Properties.Settings.Default.counterName = tb_CounterName.Text;
            Properties.Settings.Default.counterFirst = chk_CounterFirst.Checked;
            Properties.Settings.Default.showHoliday = chk_ShowHoliDay.Checked;
            Properties.Settings.Default.Save();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.dicMonthAndScheduleDates = new Dictionary<string, List<ScheduleDate>>();
            this.scheduleDates = new List<ScheduleDate>();
            this.scheduleNoHoliDayDates = new List<ScheduleDate>();
            this.currentScheduleDates = new();
            this.persons = new List<string>();
            tb_CounterName.Text = "";
            tb_InputHoliDay.Text = "";
            tb_InputPerson.Text = "";
            tb_SelectDateResult.Text = "";
            tb_SelectPersonResult.Text = "";
            tabDates.TabPages.Clear();
            lv_person.Items.Clear();
            lv_person.Columns.Clear();
            btn_ExportDutyResult.Visible = false;
        }


    }
}
