using OnDuty.Models;

namespace OnDuty
{
    public partial class Form1 : Form
    {
        private List<ScheduleDate> scheduleDates = new List<ScheduleDate>();
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
            CreateTabFromDataList();
        }
        private void GetAllDateFromCSVFIle()
        {
            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //tb_InputHoliDay.Text = openFileDialog.FileName;
            tb_InputHoliDay.Text = "C:\\Projects\\OnDuty\\114年中華民國政府行政機關辦公日曆表(修正版).csv";

            string holidayFile = tb_InputHoliDay.Text;
            label1.Text = "";
            List<ScheduleDate> models = [];
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
            //    }
            //}
            scheduleDates =  models;
        }
        private void CreateTabFromDataList()
        {
            if (scheduleDates?.Any() is true)
            {

            }
        }
    }
}
