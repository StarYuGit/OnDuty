using OnDuty.Models;

namespace OnDuty
{
    public partial class Form1 : Form
    {
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
            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
                    //tb_InputHoliDay.Text = openFileDialog.FileName;
                    tb_InputHoliDay.Text = "C:\\Projects\\OnDuty\\114�~���إ���F����F�����줽����(�ץ���).csv";

                    string holidayFile = tb_InputHoliDay.Text;
                    label1.Text = "";
                    using (StreamReader holiday = new StreamReader(holidayFile))
                    {
                        List<ScheduleDate> scheduleDates = [];
                        string? line;
                        bool isWorkDayData = false;
                        while ((line = holiday.ReadLine()) != null)
                        {
                            if (isWorkDayData)
                            {
                                label1.Text += line + Environment.NewLine;
                                List<string> everyDay = line.Split(',').ToList();
                            }
                            if ("�褸���,�P��,�O�_��,�Ƶ�".Equals(line))
                                isWorkDayData = true;
                        }
                    }
            //    }
            //}
        }
    }
}
