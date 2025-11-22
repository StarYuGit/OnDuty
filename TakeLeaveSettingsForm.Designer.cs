namespace OnDuty
{
    partial class TakeLeaveSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Cancel = new Button();
            lb_TakeLeaveType = new Label();
            lb_TakeLeaveTimePeriodsType = new Label();
            lb_TakeLeaveNumber = new Label();
            tb_TakeLeaveType = new TextBox();
            tb_TakeLeaveTimePeriodsType = new TextBox();
            tb_TakeLeaveNumber = new TextBox();
            btn_SaveSettings = new Button();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(608, 298);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(150, 46);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "取消";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // lb_TakeLeaveType
            // 
            lb_TakeLeaveType.AutoSize = true;
            lb_TakeLeaveType.Location = new Point(34, 35);
            lb_TakeLeaveType.Name = "lb_TakeLeaveType";
            lb_TakeLeaveType.Size = new Size(293, 30);
            lb_TakeLeaveType.TabIndex = 1;
            lb_TakeLeaveType.Text = "請假類別(請用逗點隔開)：";
            // 
            // lb_TakeLeaveTimePeriodsType
            // 
            lb_TakeLeaveTimePeriodsType.AutoSize = true;
            lb_TakeLeaveTimePeriodsType.Location = new Point(34, 133);
            lb_TakeLeaveTimePeriodsType.Name = "lb_TakeLeaveTimePeriodsType";
            lb_TakeLeaveTimePeriodsType.Size = new Size(293, 30);
            lb_TakeLeaveTimePeriodsType.TabIndex = 2;
            lb_TakeLeaveTimePeriodsType.Text = "請假時段(請用遏點隔開)：";
            // 
            // lb_TakeLeaveNumber
            // 
            lb_TakeLeaveNumber.AutoSize = true;
            lb_TakeLeaveNumber.Location = new Point(35, 226);
            lb_TakeLeaveNumber.Name = "lb_TakeLeaveNumber";
            lb_TakeLeaveNumber.Size = new Size(269, 30);
            lb_TakeLeaveNumber.TabIndex = 3;
            lb_TakeLeaveNumber.Text = "請假格數(請輸入數字)：";
            // 
            // tb_TakeLeaveType
            // 
            tb_TakeLeaveType.Location = new Point(323, 35);
            tb_TakeLeaveType.Name = "tb_TakeLeaveType";
            tb_TakeLeaveType.Size = new Size(783, 38);
            tb_TakeLeaveType.TabIndex = 4;
            // 
            // tb_TakeLeaveTimePeriodsType
            // 
            tb_TakeLeaveTimePeriodsType.Location = new Point(323, 133);
            tb_TakeLeaveTimePeriodsType.Name = "tb_TakeLeaveTimePeriodsType";
            tb_TakeLeaveTimePeriodsType.Size = new Size(783, 38);
            tb_TakeLeaveTimePeriodsType.TabIndex = 5;
            // 
            // tb_TakeLeaveNumber
            // 
            tb_TakeLeaveNumber.Location = new Point(323, 226);
            tb_TakeLeaveNumber.Name = "tb_TakeLeaveNumber";
            tb_TakeLeaveNumber.Size = new Size(111, 38);
            tb_TakeLeaveNumber.TabIndex = 6;
            // 
            // btn_SaveSettings
            // 
            btn_SaveSettings.Location = new Point(394, 298);
            btn_SaveSettings.Name = "btn_SaveSettings";
            btn_SaveSettings.Size = new Size(150, 46);
            btn_SaveSettings.TabIndex = 7;
            btn_SaveSettings.Text = "儲存設定";
            btn_SaveSettings.UseVisualStyleBackColor = true;
            btn_SaveSettings.Click += this.btn_SaveSettings_Click;
            // 
            // TakeLeaveSettingsForm
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 372);
            Controls.Add(btn_SaveSettings);
            Controls.Add(tb_TakeLeaveNumber);
            Controls.Add(tb_TakeLeaveTimePeriodsType);
            Controls.Add(tb_TakeLeaveType);
            Controls.Add(lb_TakeLeaveNumber);
            Controls.Add(lb_TakeLeaveTimePeriodsType);
            Controls.Add(lb_TakeLeaveType);
            Controls.Add(btn_Cancel);
            Name = "TakeLeaveSettingsForm";
            Text = "請假表設定";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private Label lb_TakeLeaveType;
        private Label lb_TakeLeaveTimePeriodsType;
        private Label lb_TakeLeaveNumber;
        private TextBox tb_TakeLeaveType;
        private TextBox tb_TakeLeaveTimePeriodsType;
        private TextBox tb_TakeLeaveNumber;
        private Button btn_SaveSettings;
    }
}