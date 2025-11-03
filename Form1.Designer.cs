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
            btn_ExportTakeLeaveList = new Button();
            SuspendLayout();
            // 
            // lb_InputHoliDay
            // 
            lb_InputHoliDay.AutoSize = true;
            lb_InputHoliDay.Location = new Point(36, 65);
            lb_InputHoliDay.Margin = new Padding(4, 0, 4, 0);
            lb_InputHoliDay.Name = "lb_InputHoliDay";
            lb_InputHoliDay.Size = new Size(136, 19);
            lb_InputHoliDay.TabIndex = 0;
            lb_InputHoliDay.Text = "匯入行事例csv檔：";
            // 
            // tb_InputHoliDay
            // 
            tb_InputHoliDay.Location = new Point(183, 61);
            tb_InputHoliDay.Margin = new Padding(4);
            tb_InputHoliDay.Name = "tb_InputHoliDay";
            tb_InputHoliDay.Size = new Size(282, 27);
            tb_InputHoliDay.TabIndex = 1;
            // 
            // btn_InputHoliDay
            // 
            btn_InputHoliDay.Location = new Point(581, 60);
            btn_InputHoliDay.Margin = new Padding(4);
            btn_InputHoliDay.Name = "btn_InputHoliDay";
            btn_InputHoliDay.Size = new Size(96, 29);
            btn_InputHoliDay.TabIndex = 2;
            btn_InputHoliDay.Text = "匯入";
            btn_InputHoliDay.UseVisualStyleBackColor = true;
            btn_InputHoliDay.Click += btn_InputHoliDay_Click;
            // 
            // lb_InputPerson
            // 
            lb_InputPerson.AutoSize = true;
            lb_InputPerson.Location = new Point(36, 137);
            lb_InputPerson.Margin = new Padding(4, 0, 4, 0);
            lb_InputPerson.Name = "lb_InputPerson";
            lb_InputPerson.Size = new Size(129, 19);
            lb_InputPerson.TabIndex = 3;
            lb_InputPerson.Text = "匯入排班人名單：";
            // 
            // btn_InputPerson
            // 
            btn_InputPerson.Location = new Point(581, 132);
            btn_InputPerson.Margin = new Padding(4);
            btn_InputPerson.Name = "btn_InputPerson";
            btn_InputPerson.Size = new Size(96, 29);
            btn_InputPerson.TabIndex = 4;
            btn_InputPerson.Text = "匯入";
            btn_InputPerson.UseVisualStyleBackColor = true;
            btn_InputPerson.Click += btn_InputPerson_Click;
            // 
            // tb_InputPerson
            // 
            tb_InputPerson.Location = new Point(183, 134);
            tb_InputPerson.Margin = new Padding(4);
            tb_InputPerson.Name = "tb_InputPerson";
            tb_InputPerson.Size = new Size(282, 27);
            tb_InputPerson.TabIndex = 5;
            // 
            // lb_CounterName
            // 
            lb_CounterName.AutoSize = true;
            lb_CounterName.Location = new Point(36, 190);
            lb_CounterName.Margin = new Padding(4, 0, 4, 0);
            lb_CounterName.Name = "lb_CounterName";
            lb_CounterName.Size = new Size(84, 19);
            lb_CounterName.TabIndex = 6;
            lb_CounterName.Text = "櫃台人員：";
            // 
            // tb_CounterName
            // 
            tb_CounterName.Location = new Point(183, 186);
            tb_CounterName.Margin = new Padding(4);
            tb_CounterName.Name = "tb_CounterName";
            tb_CounterName.Size = new Size(127, 27);
            tb_CounterName.TabIndex = 7;
            // 
            // lb_SelectDate
            // 
            lb_SelectDate.AutoSize = true;
            lb_SelectDate.Location = new Point(36, 237);
            lb_SelectDate.Margin = new Padding(4, 0, 4, 0);
            lb_SelectDate.Name = "lb_SelectDate";
            lb_SelectDate.Size = new Size(144, 19);
            lb_SelectDate.TabIndex = 8;
            lb_SelectDate.Text = "選擇排班起始日期：";
            // 
            // tabDates
            // 
            tabDates.Location = new Point(22, 286);
            tabDates.Margin = new Padding(4);
            tabDates.Name = "tabDates";
            tabDates.SelectedIndex = 0;
            tabDates.Size = new Size(427, 348);
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
            btn_InputHoliDayFile.Location = new Point(477, 60);
            btn_InputHoliDayFile.Margin = new Padding(4);
            btn_InputHoliDayFile.Name = "btn_InputHoliDayFile";
            btn_InputHoliDayFile.Size = new Size(96, 29);
            btn_InputHoliDayFile.TabIndex = 10;
            btn_InputHoliDayFile.Text = "選擇檔案";
            btn_InputHoliDayFile.UseVisualStyleBackColor = true;
            btn_InputHoliDayFile.Click += btn_InputHoliDayFile_Click;
            // 
            // btn_InputPersonFile
            // 
            btn_InputPersonFile.Location = new Point(477, 132);
            btn_InputPersonFile.Margin = new Padding(4);
            btn_InputPersonFile.Name = "btn_InputPersonFile";
            btn_InputPersonFile.Size = new Size(96, 29);
            btn_InputPersonFile.TabIndex = 11;
            btn_InputPersonFile.Text = "選擇檔案";
            btn_InputPersonFile.UseVisualStyleBackColor = true;
            btn_InputPersonFile.Click += btn_InputPersonFile_Click;
            // 
            // lb_SelectPerson
            // 
            lb_SelectPerson.AutoSize = true;
            lb_SelectPerson.Location = new Point(336, 239);
            lb_SelectPerson.Margin = new Padding(4, 0, 4, 0);
            lb_SelectPerson.Name = "lb_SelectPerson";
            lb_SelectPerson.Size = new Size(144, 19);
            lb_SelectPerson.TabIndex = 12;
            lb_SelectPerson.Text = "選擇排班起始人員：";
            // 
            // tb_SelectDateResult
            // 
            tb_SelectDateResult.Location = new Point(183, 233);
            tb_SelectDateResult.Margin = new Padding(4);
            tb_SelectDateResult.Name = "tb_SelectDateResult";
            tb_SelectDateResult.Size = new Size(127, 27);
            tb_SelectDateResult.TabIndex = 13;
            // 
            // tb_SelectPersonResult
            // 
            tb_SelectPersonResult.Location = new Point(477, 233);
            tb_SelectPersonResult.Margin = new Padding(4);
            tb_SelectPersonResult.Name = "tb_SelectPersonResult";
            tb_SelectPersonResult.Size = new Size(98, 27);
            tb_SelectPersonResult.TabIndex = 14;
            // 
            // lv_person
            // 
            lv_person.FullRowSelect = true;
            lv_person.GridLines = true;
            lv_person.Location = new Point(468, 290);
            lv_person.Name = "lv_person";
            lv_person.Size = new Size(208, 346);
            lv_person.TabIndex = 15;
            lv_person.UseCompatibleStateImageBehavior = false;
            lv_person.View = View.Details;
            // 
            // btn_Duty
            // 
            btn_Duty.Location = new Point(581, 180);
            btn_Duty.Margin = new Padding(4);
            btn_Duty.Name = "btn_Duty";
            btn_Duty.Size = new Size(96, 29);
            btn_Duty.TabIndex = 16;
            btn_Duty.Text = "執行排班";
            btn_Duty.UseVisualStyleBackColor = true;
            btn_Duty.Click += btn_Duty_Click;
            // 
            // chk_CounterFirst
            // 
            chk_CounterFirst.AutoSize = true;
            chk_CounterFirst.Location = new Point(336, 171);
            chk_CounterFirst.Name = "chk_CounterFirst";
            chk_CounterFirst.Size = new Size(121, 23);
            chk_CounterFirst.TabIndex = 17;
            chk_CounterFirst.Text = "櫃臺人員優先";
            chk_CounterFirst.UseVisualStyleBackColor = true;
            // 
            // chk_ShowHoliDay
            // 
            chk_ShowHoliDay.AutoSize = true;
            chk_ShowHoliDay.Location = new Point(336, 200);
            chk_ShowHoliDay.Name = "chk_ShowHoliDay";
            chk_ShowHoliDay.Size = new Size(91, 23);
            chk_ShowHoliDay.TabIndex = 18;
            chk_ShowHoliDay.Text = "顯示假日";
            chk_ShowHoliDay.UseVisualStyleBackColor = true;
            chk_ShowHoliDay.CheckedChanged += chk_ShowHoliDay_CheckedChanged;
            // 
            // btn_ExportDutyResult
            // 
            btn_ExportDutyResult.Location = new Point(582, 230);
            btn_ExportDutyResult.Margin = new Padding(4);
            btn_ExportDutyResult.Name = "btn_ExportDutyResult";
            btn_ExportDutyResult.Size = new Size(96, 29);
            btn_ExportDutyResult.TabIndex = 19;
            btn_ExportDutyResult.Text = "匯出";
            btn_ExportDutyResult.UseVisualStyleBackColor = true;
            btn_ExportDutyResult.Visible = false;
            btn_ExportDutyResult.Click += btn_ExportDutyResult_Click;
            // 
            // lL_SchedulePage
            // 
            lL_SchedulePage.AutoSize = true;
            lL_SchedulePage.Location = new Point(183, 92);
            lL_SchedulePage.Name = "lL_SchedulePage";
            lL_SchedulePage.Size = new Size(400, 19);
            lL_SchedulePage.TabIndex = 20;
            lL_SchedulePage.TabStop = true;
            lL_SchedulePage.Text = "下載行事曆(政府資料開放平臺)，勿下載Google行事曆專用";
            lL_SchedulePage.LinkClicked += lL_SchedulePage_LinkClicked;
            // 
            // btn_SaveSetting
            // 
            btn_SaveSetting.Location = new Point(478, 14);
            btn_SaveSetting.Margin = new Padding(4);
            btn_SaveSetting.Name = "btn_SaveSetting";
            btn_SaveSetting.Size = new Size(96, 29);
            btn_SaveSetting.TabIndex = 21;
            btn_SaveSetting.Text = "儲存設定";
            btn_SaveSetting.UseVisualStyleBackColor = true;
            btn_SaveSetting.Click += btn_SaveSetting_Click;
            // 
            // btn_ClearSetting
            // 
            btn_ClearSetting.Location = new Point(582, 14);
            btn_ClearSetting.Margin = new Padding(4);
            btn_ClearSetting.Name = "btn_ClearSetting";
            btn_ClearSetting.Size = new Size(96, 29);
            btn_ClearSetting.TabIndex = 22;
            btn_ClearSetting.Text = "清除設定";
            btn_ClearSetting.UseVisualStyleBackColor = true;
            btn_ClearSetting.Click += btn_ClearSetting_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(366, 14);
            btn_Clear.Margin = new Padding(2);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(96, 29);
            btn_Clear.TabIndex = 23;
            btn_Clear.Text = "清空所有";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_ExportTakeLeaveList
            // 
            btn_ExportTakeLeaveList.Location = new Point(585, 99);
            btn_ExportTakeLeaveList.Name = "btn_ExportTakeLeaveList";
            btn_ExportTakeLeaveList.Size = new Size(94, 29);
            btn_ExportTakeLeaveList.TabIndex = 24;
            btn_ExportTakeLeaveList.Text = "匯出科員請假表";
            btn_ExportTakeLeaveList.UseVisualStyleBackColor = true;
            btn_ExportTakeLeaveList.Click += btn_ExportTakeLeaveList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 554);
            Controls.Add(btn_ExportTakeLeaveList);
            Controls.Add(btn_Clear);
            Controls.Add(btn_ClearSetting);
            Controls.Add(btn_SaveSetting);
            Controls.Add(lL_SchedulePage);
            Controls.Add(btn_ExportDutyResult);
            Controls.Add(chk_ShowHoliDay);
            Controls.Add(chk_CounterFirst);
            Controls.Add(btn_Duty);
            Controls.Add(lv_person);
            Controls.Add(tb_SelectPersonResult);
            Controls.Add(tb_SelectDateResult);
            Controls.Add(lb_SelectPerson);
            Controls.Add(btn_InputPersonFile);
            Controls.Add(btn_InputHoliDayFile);
            Controls.Add(tabDates);
            Controls.Add(lb_SelectDate);
            Controls.Add(tb_CounterName);
            Controls.Add(lb_CounterName);
            Controls.Add(tb_InputPerson);
            Controls.Add(btn_InputPerson);
            Controls.Add(lb_InputPerson);
            Controls.Add(btn_InputHoliDay);
            Controls.Add(tb_InputHoliDay);
            Controls.Add(lb_InputHoliDay);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "櫃檯排班小工具";
            Load += Form1_Load;
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
        private Button btn_ExportTakeLeaveList;
    }
}
