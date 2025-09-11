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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tb_InputHoliDay.Text = openFileDialog.FileName;
                    string holidayFile = tb_InputHoliDay.Text;
                    label1.Text = "";
                    using (StreamReader holiday = new StreamReader(holidayFile))
                    {
             
                        string? line;
                        bool isWorkDayData = false;
                        while ((line = holiday.ReadLine()) != null)
                        {
                            if ("西元日期,星期,是否放假,備註".Equals(line))
                                isWorkDayData = true;
                            if (isWorkDayData)
                            {
                                label1.Text += line + Environment.NewLine;
                            }
     
                        }
                    }
                }
            }
        }
    }
}
