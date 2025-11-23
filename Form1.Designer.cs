namespace OnDuty
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_InputHoliDay = new Label();
            tb_InputHoliDay = new TextBox();
            btn_InputHoliDay = new Button();
            lb_InputPerson = new Label();
            btn_InputPerson = new Button();
            tb_InputPerson = new TextBox();
            lb_CounterName = new Label();
            tb_CounterName = new TextBox();
            lb_SelectDate = new Label();
            tabDates = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btn_InputHoliDayFile = new Button();
            btn_InputPersonFile = new Button();
            lb_SelectPerson = new Label();
            tb_SelectDateResult = new TextBox();
            tb_SelectPersonResult = new TextBox();
            lv_person = new ListView();
            btn_Duty = new Button();
            chk_CounterFirst = new CheckBox();
            chk_ShowHoliDay = new CheckBox();
            btn_ExportDutyResult = new Button();
            lL_SchedulePage = new LinkLabel();
            btn_SaveSetting = new Button();
            btn_ClearSetting = new Button();
            btn_Clear = new Button();
            btn_OpenTakeLeaveSettingForm = new Button();
            gb_PreView = new GroupBox();
            gb_FormSettings = new GroupBox();
            cb_ExportDuty = new CheckBox();
            cb_ExportTakeLeave = new CheckBox();
            gb_ExportFileCheckArea = new GroupBox();
            gb_PreView.SuspendLayout();
            gb_FormSettings.SuspendLayout();
            gb_ExportFileCheckArea.SuspendLayout();
            SuspendLayout();
            // 
            // lb_InputHoliDay
            // 
            lb_InputHoliDay.AutoSize = true;
            lb_InputHoliDay.Location = new Point(21, 60);
            lb_InputHoliDay.Name = "lb_InputHoliDay";
            lb_InputHoliDay.Size = new Size(108, 15);
            lb_InputHoliDay.TabIndex = 0;
            lb_InputHoliDay.Text = "匯入行事例csv檔：";
            // 
            // tb_InputHoliDay
            // 
            tb_InputHoliDay.Location = new Point(133, 57);
            tb_InputHoliDay.Name = "tb_InputHoliDay";
            tb_InputHoliDay.Size = new Size(489, 23);
            tb_InputHoliDay.TabIndex = 1;
            // 
            // btn_InputHoliDay
            // 
            btn_InputHoliDay.Location = new Point(549, 90);
            btn_InputHoliDay.Name = "btn_InputHoliDay";
            btn_InputHoliDay.Size = new Size(74, 23);
            btn_InputHoliDay.TabIndex = 2;
            btn_InputHoliDay.Text = "匯入";
            btn_InputHoliDay.UseVisualStyleBackColor = true;
            btn_InputHoliDay.Click += btn_InputHoliDay_Click;
            // 
            // lb_InputPerson
            // 
            lb_InputPerson.AutoSize = true;
            lb_InputPerson.Location = new Point(21, 125);
            lb_InputPerson.Name = "lb_InputPerson";
            lb_InputPerson.Size = new Size(103, 15);
            lb_InputPerson.TabIndex = 3;
            lb_InputPerson.Text = "匯入排班人名單：";
            // 
            // btn_InputPerson
            // 
            btn_InputPerson.Location = new Point(549, 159);
            btn_InputPerson.Name = "btn_InputPerson";
            btn_InputPerson.Size = new Size(74, 23);
            btn_InputPerson.TabIndex = 4;
            btn_InputPerson.Text = "匯入";
            btn_InputPerson.UseVisualStyleBackColor = true;
            btn_InputPerson.Click += btn_InputPerson_Click;
            // 
            // tb_InputPerson
            // 
            tb_InputPerson.Location = new Point(134, 122);
            tb_InputPerson.Name = "tb_InputPerson";
            tb_InputPerson.Size = new Size(489, 23);
            tb_InputPerson.TabIndex = 5;
            // 
            // lb_CounterName
            // 
            lb_CounterName.AutoSize = true;
            lb_CounterName.Location = new Point(21, 162);
            lb_CounterName.Name = "lb_CounterName";
            lb_CounterName.Size = new Size(67, 15);
            lb_CounterName.TabIndex = 6;
            lb_CounterName.Text = "櫃台人員：";
            // 
            // tb_CounterName
            // 
            tb_CounterName.Location = new Point(134, 159);
            tb_CounterName.Name = "tb_CounterName";
            tb_CounterName.Size = new Size(100, 23);
            tb_CounterName.TabIndex = 7;
            // 
            // lb_SelectDate
            // 
            lb_SelectDate.AutoSize = true;
            lb_SelectDate.Location = new Point(21, 198);
            lb_SelectDate.Name = "lb_SelectDate";
            lb_SelectDate.Size = new Size(115, 15);
            lb_SelectDate.TabIndex = 8;
            lb_SelectDate.Text = "選擇排班起始日期：";
            // 
            // tabDates
            // 
            tabDates.Location = new Point(5, 22);
            tabDates.Name = "tabDates";
            tabDates.SelectedIndex = 0;
            tabDates.Size = new Size(341, 274);
            tabDates.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(504, 272);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(504, 272);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_InputHoliDayFile
            // 
            btn_InputHoliDayFile.Location = new Point(469, 90);
            btn_InputHoliDayFile.Name = "btn_InputHoliDayFile";
            btn_InputHoliDayFile.Size = new Size(74, 23);
            btn_InputHoliDayFile.TabIndex = 10;
            btn_InputHoliDayFile.Text = "選擇檔案";
            btn_InputHoliDayFile.UseVisualStyleBackColor = true;
            btn_InputHoliDayFile.Click += btn_InputHoliDayFile_Click;
            // 
            // btn_InputPersonFile
            // 
            btn_InputPersonFile.Location = new Point(469, 159);
            btn_InputPersonFile.Name = "btn_InputPersonFile";
            btn_InputPersonFile.Size = new Size(74, 23);
            btn_InputPersonFile.TabIndex = 11;
            btn_InputPersonFile.Text = "選擇檔案";
            btn_InputPersonFile.UseVisualStyleBackColor = true;
            btn_InputPersonFile.Click += btn_InputPersonFile_Click;
            // 
            // lb_SelectPerson
            // 
            lb_SelectPerson.AutoSize = true;
            lb_SelectPerson.Location = new Point(375, 198);
            lb_SelectPerson.Name = "lb_SelectPerson";
            lb_SelectPerson.Size = new Size(115, 15);
            lb_SelectPerson.TabIndex = 12;
            lb_SelectPerson.Text = "選擇排班起始人員：";
            // 
            // tb_SelectDateResult
            // 
            tb_SelectDateResult.Location = new Point(133, 195);
            tb_SelectDateResult.Name = "tb_SelectDateResult";
            tb_SelectDateResult.Size = new Size(232, 23);
            tb_SelectDateResult.TabIndex = 13;
            // 
            // tb_SelectPersonResult
            // 
            tb_SelectPersonResult.Location = new Point(491, 195);
            tb_SelectPersonResult.Name = "tb_SelectPersonResult";
            tb_SelectPersonResult.Size = new Size(131, 23);
            tb_SelectPersonResult.TabIndex = 14;
            // 
            // lv_person
            // 
            lv_person.FullRowSelect = true;
            lv_person.GridLines = true;
            lv_person.Location = new Point(356, 22);
            lv_person.Margin = new Padding(2);
            lv_person.Name = "lv_person";
            lv_person.Size = new Size(247, 274);
            lv_person.TabIndex = 15;
            lv_person.UseCompatibleStateImageBehavior = false;
            lv_person.View = View.Details;
            // 
            // btn_Duty
            // 
            btn_Duty.Location = new Point(549, 229);
            btn_Duty.Name = "btn_Duty";
            btn_Duty.Size = new Size(74, 23);
            btn_Duty.TabIndex = 16;
            btn_Duty.Text = "執行排班";
            btn_Duty.UseVisualStyleBackColor = true;
            btn_Duty.Click += btn_Duty_Click;
            // 
            // chk_CounterFirst
            // 
            chk_CounterFirst.AutoSize = true;
            chk_CounterFirst.Location = new Point(249, 161);
            chk_CounterFirst.Margin = new Padding(2);
            chk_CounterFirst.Name = "chk_CounterFirst";
            chk_CounterFirst.Size = new Size(98, 19);
            chk_CounterFirst.TabIndex = 17;
            chk_CounterFirst.Text = "櫃臺人員優先";
            chk_CounterFirst.UseVisualStyleBackColor = true;
            // 
            // chk_ShowHoliDay
            // 
            chk_ShowHoliDay.AutoSize = true;
            chk_ShowHoliDay.Location = new Point(351, 161);
            chk_ShowHoliDay.Margin = new Padding(2);
            chk_ShowHoliDay.Name = "chk_ShowHoliDay";
            chk_ShowHoliDay.Size = new Size(74, 19);
            chk_ShowHoliDay.TabIndex = 18;
            chk_ShowHoliDay.Text = "顯示假日";
            chk_ShowHoliDay.UseVisualStyleBackColor = true;
            chk_ShowHoliDay.CheckedChanged += chk_ShowHoliDay_CheckedChanged;
            // 
            // btn_ExportDutyResult
            // 
            btn_ExportDutyResult.Location = new Point(549, 578);
            btn_ExportDutyResult.Name = "btn_ExportDutyResult";
            btn_ExportDutyResult.Size = new Size(74, 23);
            btn_ExportDutyResult.TabIndex = 19;
            btn_ExportDutyResult.Text = "匯出";
            btn_ExportDutyResult.UseVisualStyleBackColor = true;
            btn_ExportDutyResult.Visible = false;
            btn_ExportDutyResult.Click += btn_ExportDutyResult_Click;
            // 
            // lL_SchedulePage
            // 
            lL_SchedulePage.AutoSize = true;
            lL_SchedulePage.Location = new Point(133, 94);
            lL_SchedulePage.Margin = new Padding(2, 0, 2, 0);
            lL_SchedulePage.Name = "lL_SchedulePage";
            lL_SchedulePage.Size = new Size(322, 15);
            lL_SchedulePage.TabIndex = 20;
            lL_SchedulePage.TabStop = true;
            lL_SchedulePage.Text = "下載行事曆(政府資料開放平臺)，勿下載Google行事曆專用";
            lL_SchedulePage.LinkClicked += lL_SchedulePage_LinkClicked;
            // 
            // btn_SaveSetting
            // 
            btn_SaveSetting.Location = new Point(86, 15);
            btn_SaveSetting.Name = "btn_SaveSetting";
            btn_SaveSetting.Size = new Size(74, 23);
            btn_SaveSetting.TabIndex = 21;
            btn_SaveSetting.Text = "儲存設定";
            btn_SaveSetting.UseVisualStyleBackColor = true;
            btn_SaveSetting.Click += btn_SaveSetting_Click;
            // 
            // btn_ClearSetting
            // 
            btn_ClearSetting.Location = new Point(6, 16);
            btn_ClearSetting.Name = "btn_ClearSetting";
            btn_ClearSetting.Size = new Size(74, 23);
            btn_ClearSetting.TabIndex = 22;
            btn_ClearSetting.Text = "清除設定";
            btn_ClearSetting.UseVisualStyleBackColor = true;
            btn_ClearSetting.Click += btn_ClearSetting_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(549, 24);
            btn_Clear.Margin = new Padding(2);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(74, 23);
            btn_Clear.TabIndex = 23;
            btn_Clear.Text = "清空";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_OpenTakeLeaveSettingForm
            // 
            btn_OpenTakeLeaveSettingForm.Location = new Point(450, 578);
            btn_OpenTakeLeaveSettingForm.Margin = new Padding(2);
            btn_OpenTakeLeaveSettingForm.Name = "btn_OpenTakeLeaveSettingForm";
            btn_OpenTakeLeaveSettingForm.Size = new Size(93, 23);
            btn_OpenTakeLeaveSettingForm.TabIndex = 24;
            btn_OpenTakeLeaveSettingForm.Text = "請假表設定";
            btn_OpenTakeLeaveSettingForm.UseVisualStyleBackColor = true;
            btn_OpenTakeLeaveSettingForm.Click += btn_OpenTakeLeaveSettingForm_Click;
            // 
            // gb_PreView
            // 
            gb_PreView.Controls.Add(tabDates);
            gb_PreView.Controls.Add(lv_person);
            gb_PreView.Location = new Point(20, 252);
            gb_PreView.Margin = new Padding(2);
            gb_PreView.Name = "gb_PreView";
            gb_PreView.Padding = new Padding(2);
            gb_PreView.Size = new Size(613, 300);
            gb_PreView.TabIndex = 25;
            gb_PreView.TabStop = false;
            gb_PreView.Text = "排班預覽";
            // 
            // gb_FormSettings
            // 
            gb_FormSettings.Controls.Add(btn_ClearSetting);
            gb_FormSettings.Controls.Add(btn_SaveSetting);
            gb_FormSettings.Location = new Point(13, 8);
            gb_FormSettings.Name = "gb_FormSettings";
            gb_FormSettings.Size = new Size(173, 45);
            gb_FormSettings.TabIndex = 26;
            gb_FormSettings.TabStop = false;
            gb_FormSettings.Text = "設定";
            // 
            // cb_ExportDuty
            // 
            cb_ExportDuty.AutoSize = true;
            cb_ExportDuty.Location = new Point(5, 18);
            cb_ExportDuty.Name = "cb_ExportDuty";
            cb_ExportDuty.Size = new Size(134, 19);
            cb_ExportDuty.TabIndex = 27;
            cb_ExportDuty.Text = "一樓櫃台中午值班表";
            cb_ExportDuty.UseVisualStyleBackColor = true;
            // 
            // cb_ExportTakeLeave
            // 
            cb_ExportTakeLeave.AutoSize = true;
            cb_ExportTakeLeave.Location = new Point(140, 18);
            cb_ExportTakeLeave.Name = "cb_ExportTakeLeave";
            cb_ExportTakeLeave.Size = new Size(98, 19);
            cb_ExportTakeLeave.TabIndex = 28;
            cb_ExportTakeLeave.Text = "科員請假紀錄";
            cb_ExportTakeLeave.UseVisualStyleBackColor = true;
            // 
            // gb_ExportFileCheckArea
            // 
            gb_ExportFileCheckArea.Controls.Add(cb_ExportDuty);
            gb_ExportFileCheckArea.Controls.Add(cb_ExportTakeLeave);
            gb_ExportFileCheckArea.Location = new Point(25, 563);
            gb_ExportFileCheckArea.Name = "gb_ExportFileCheckArea";
            gb_ExportFileCheckArea.Size = new Size(244, 42);
            gb_ExportFileCheckArea.TabIndex = 29;
            gb_ExportFileCheckArea.TabStop = false;
            gb_ExportFileCheckArea.Text = "選擇匯出檔案";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 610);
            Controls.Add(btn_Duty);
            Controls.Add(gb_ExportFileCheckArea);
            Controls.Add(gb_FormSettings);
            Controls.Add(btn_OpenTakeLeaveSettingForm);
            Controls.Add(lb_SelectPerson);
            Controls.Add(tb_SelectPersonResult);
            Controls.Add(btn_Clear);
            Controls.Add(lL_SchedulePage);
            Controls.Add(btn_ExportDutyResult);
            Controls.Add(chk_ShowHoliDay);
            Controls.Add(chk_CounterFirst);
            Controls.Add(tb_SelectDateResult);
            Controls.Add(btn_InputPersonFile);
            Controls.Add(btn_InputHoliDayFile);
            Controls.Add(lb_SelectDate);
            Controls.Add(tb_CounterName);
            Controls.Add(lb_CounterName);
            Controls.Add(tb_InputPerson);
            Controls.Add(btn_InputPerson);
            Controls.Add(lb_InputPerson);
            Controls.Add(btn_InputHoliDay);
            Controls.Add(tb_InputHoliDay);
            Controls.Add(lb_InputHoliDay);
            Controls.Add(gb_PreView);
            Name = "Form1";
            Text = "櫃檯排班小工具";
            Load += Form1_Load;
            gb_PreView.ResumeLayout(false);
            gb_FormSettings.ResumeLayout(false);
            gb_ExportFileCheckArea.ResumeLayout(false);
            gb_ExportFileCheckArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_InputHoliDay;
        private TextBox tb_InputHoliDay;
        private Button btn_InputHoliDay;
        private Label lb_InputPerson;
        private Button btn_InputPerson;
        private TextBox tb_InputPerson;
        private Label lb_CounterName;
        private TextBox tb_CounterName;
        private Label lb_SelectDate;
        private TabControl tabDates;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btn_InputHoliDayFile;
        private Button btn_InputPersonFile;
        private Label lb_SelectPerson;
        private TextBox tb_SelectDateResult;
        private TextBox tb_SelectPersonResult;
        private ListView lv_person;
        private Button btn_Duty;
        private CheckBox chk_CounterFirst;
        private CheckBox chk_ShowHoliDay;
        private Button btn_ExportDutyResult;
        private LinkLabel lL_SchedulePage;
        private Button btn_SaveSetting;
        private Button btn_ClearSetting;
        private Button btn_Clear;
        private Button btn_OpenTakeLeaveSettingForm;
        private GroupBox gb_PreView;
        private GroupBox gb_FormSettings;
        private CheckBox cb_ExportDuty;
        private CheckBox cb_ExportTakeLeave;
        private GroupBox gb_ExportFileCheckArea;
    }
}
