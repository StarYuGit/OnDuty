namespace OnDuty
{
    public partial class TakeLeaveSettingsForm : Form
    {
        public TakeLeaveSettingsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 固定邊框
            this.MaximizeBox = false; // 禁用最大化按鈕
            tb_TakeLeaveType.Text = Properties.Settings.Default.takeLeaveType;
            tb_TakeLeaveTimePeriodsType.Text = Properties.Settings.Default.takeLeaveTimePeriodsType;
            tb_TakeLeaveNumber.Text = Properties.Settings.Default.takeLeaveNumber.ToString();
        }
        private void btn_SaveSettings_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "確定儲存設定？",            // 訊息文字
                "確認",                 // 視窗標題
                MessageBoxButtons.YesNo, // 按鈕樣式
                MessageBoxIcon.Question  // 圖示
            );

            if (result == DialogResult.Yes)
            {
                int takeLeaveNumber = 0;
                if (Int32.TryParse(tb_TakeLeaveNumber.Text, out takeLeaveNumber))
                {
                    Properties.Settings.Default.takeLeaveType = tb_TakeLeaveType.Text;
                    Properties.Settings.Default.takeLeaveTimePeriodsType = tb_TakeLeaveTimePeriodsType.Text;
                    Properties.Settings.Default.takeLeaveNumber = takeLeaveNumber;
                    MessageBox.Show("儲存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("「請假格數」請輸入數字。");
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
