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
            SuspendLayout();
            // 
            // lb_InputHoliDay
            // 
            lb_InputHoliDay.AutoSize = true;
            lb_InputHoliDay.Location = new Point(28, 50);
            lb_InputHoliDay.Name = "lb_InputHoliDay";
            lb_InputHoliDay.Size = new Size(108, 15);
            lb_InputHoliDay.TabIndex = 0;
            lb_InputHoliDay.Text = "匯入行事例csv檔：";
            // 
            // tb_InputHoliDay
            // 
            tb_InputHoliDay.Location = new Point(142, 47);
            tb_InputHoliDay.Name = "tb_InputHoliDay";
            tb_InputHoliDay.Size = new Size(220, 23);
            tb_InputHoliDay.TabIndex = 1;
            // 
            // btn_InputHoliDay
            // 
            btn_InputHoliDay.Location = new Point(452, 47);
            btn_InputHoliDay.Name = "btn_InputHoliDay";
            btn_InputHoliDay.Size = new Size(75, 23);
            btn_InputHoliDay.TabIndex = 2;
            btn_InputHoliDay.Text = "匯入";
            btn_InputHoliDay.UseVisualStyleBackColor = true;
            btn_InputHoliDay.Click += btn_InputHoliDay_Click;
            // 
            // lb_InputPerson
            // 
            lb_InputPerson.AutoSize = true;
            lb_InputPerson.Location = new Point(28, 108);
            lb_InputPerson.Name = "lb_InputPerson";
            lb_InputPerson.Size = new Size(103, 15);
            lb_InputPerson.TabIndex = 3;
            lb_InputPerson.Text = "匯入排班人名單：";
            // 
            // btn_InputPerson
            // 
            btn_InputPerson.Location = new Point(452, 104);
            btn_InputPerson.Name = "btn_InputPerson";
            btn_InputPerson.Size = new Size(75, 23);
            btn_InputPerson.TabIndex = 4;
            btn_InputPerson.Text = "匯入";
            btn_InputPerson.UseVisualStyleBackColor = true;
            btn_InputPerson.Click += btn_InputPerson_Click;
            // 
            // tb_InputPerson
            // 
            tb_InputPerson.Location = new Point(142, 106);
            tb_InputPerson.Name = "tb_InputPerson";
            tb_InputPerson.Size = new Size(220, 23);
            tb_InputPerson.TabIndex = 5;
            // 
            // lb_CounterName
            // 
            lb_CounterName.AutoSize = true;
            lb_CounterName.Location = new Point(28, 150);
            lb_CounterName.Name = "lb_CounterName";
            lb_CounterName.Size = new Size(67, 15);
            lb_CounterName.TabIndex = 6;
            lb_CounterName.Text = "櫃台人員：";
            // 
            // tb_CounterName
            // 
            tb_CounterName.Location = new Point(142, 147);
            tb_CounterName.Name = "tb_CounterName";
            tb_CounterName.Size = new Size(100, 23);
            tb_CounterName.TabIndex = 7;
            // 
            // lb_SelectDate
            // 
            lb_SelectDate.AutoSize = true;
            lb_SelectDate.Location = new Point(28, 187);
            lb_SelectDate.Name = "lb_SelectDate";
            lb_SelectDate.Size = new Size(115, 15);
            lb_SelectDate.TabIndex = 8;
            lb_SelectDate.Text = "選擇排班起始日期：";
            // 
            // tabDates
            // 
            tabDates.Location = new Point(17, 226);
            tabDates.Name = "tabDates";
            tabDates.SelectedIndex = 0;
            tabDates.Size = new Size(332, 275);
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
            btn_InputHoliDayFile.Location = new Point(371, 47);
            btn_InputHoliDayFile.Name = "btn_InputHoliDayFile";
            btn_InputHoliDayFile.Size = new Size(75, 23);
            btn_InputHoliDayFile.TabIndex = 10;
            btn_InputHoliDayFile.Text = "選擇檔案";
            btn_InputHoliDayFile.UseVisualStyleBackColor = true;
            btn_InputHoliDayFile.Click += btn_InputHoliDayFile_Click;
            // 
            // btn_InputPersonFile
            // 
            btn_InputPersonFile.Location = new Point(371, 104);
            btn_InputPersonFile.Name = "btn_InputPersonFile";
            btn_InputPersonFile.Size = new Size(75, 23);
            btn_InputPersonFile.TabIndex = 11;
            btn_InputPersonFile.Text = "選擇檔案";
            btn_InputPersonFile.UseVisualStyleBackColor = true;
            btn_InputPersonFile.Click += btn_InputPersonFile_Click;
            // 
            // lb_SelectPerson
            // 
            lb_SelectPerson.AutoSize = true;
            lb_SelectPerson.Location = new Point(261, 189);
            lb_SelectPerson.Name = "lb_SelectPerson";
            lb_SelectPerson.Size = new Size(115, 15);
            lb_SelectPerson.TabIndex = 12;
            lb_SelectPerson.Text = "選擇排班起始人員：";
            // 
            // tb_SelectDateResult
            // 
            tb_SelectDateResult.Location = new Point(142, 184);
            tb_SelectDateResult.Name = "tb_SelectDateResult";
            tb_SelectDateResult.Size = new Size(100, 23);
            tb_SelectDateResult.TabIndex = 13;
            // 
            // tb_SelectPersonResult
            // 
            tb_SelectPersonResult.Location = new Point(371, 184);
            tb_SelectPersonResult.Name = "tb_SelectPersonResult";
            tb_SelectPersonResult.Size = new Size(77, 23);
            tb_SelectPersonResult.TabIndex = 14;
            // 
            // lv_person
            // 
            lv_person.FullRowSelect = true;
            lv_person.GridLines = true;
            lv_person.Location = new Point(364, 229);
            lv_person.Margin = new Padding(2);
            lv_person.Name = "lv_person";
            lv_person.Size = new Size(163, 274);
            lv_person.TabIndex = 15;
            lv_person.UseCompatibleStateImageBehavior = false;
            lv_person.View = View.Details;
            // 
            // btn_Duty
            // 
            btn_Duty.Location = new Point(454, 184);
            btn_Duty.Name = "btn_Duty";
            btn_Duty.Size = new Size(75, 23);
            btn_Duty.TabIndex = 16;
            btn_Duty.Text = "執行排班";
            btn_Duty.UseVisualStyleBackColor = true;
            btn_Duty.Click += btn_Duty_Click;
            // 
            // chk_CounterFirst
            // 
            chk_CounterFirst.AutoSize = true;
            chk_CounterFirst.Location = new Point(261, 135);
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
            chk_ShowHoliDay.Location = new Point(261, 158);
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
            btn_ExportDutyResult.Location = new Point(452, 142);
            btn_ExportDutyResult.Name = "btn_ExportDutyResult";
            btn_ExportDutyResult.Size = new Size(75, 23);
            btn_ExportDutyResult.TabIndex = 19;
            btn_ExportDutyResult.Text = "匯出";
            btn_ExportDutyResult.UseVisualStyleBackColor = true;
            btn_ExportDutyResult.Visible = false;
            btn_ExportDutyResult.Click += btn_ExportDutyResult_Click;
            // 
            // lL_SchedulePage
            // 
            lL_SchedulePage.AutoSize = true;
            lL_SchedulePage.Location = new Point(142, 73);
            lL_SchedulePage.Margin = new Padding(2, 0, 2, 0);
            lL_SchedulePage.Name = "lL_SchedulePage";
            lL_SchedulePage.Size = new Size(322, 15);
            lL_SchedulePage.TabIndex = 20;
            lL_SchedulePage.TabStop = true;
            lL_SchedulePage.Text = "下載行事曆(政資資料開放平臺)，勿下載Google行事曆專用";
            lL_SchedulePage.LinkClicked += lL_SchedulePage_LinkClicked;
            // 
            // btn_SaveSetting
            // 
            btn_SaveSetting.Location = new Point(372, 11);
            btn_SaveSetting.Name = "btn_SaveSetting";
            btn_SaveSetting.Size = new Size(75, 23);
            btn_SaveSetting.TabIndex = 21;
            btn_SaveSetting.Text = "儲存設定";
            btn_SaveSetting.UseVisualStyleBackColor = true;
            btn_SaveSetting.Click += btn_SaveSetting_Click;
            // 
            // btn_ClearSetting
            // 
            btn_ClearSetting.Location = new Point(453, 11);
            btn_ClearSetting.Name = "btn_ClearSetting";
            btn_ClearSetting.Size = new Size(75, 23);
            btn_ClearSetting.TabIndex = 22;
            btn_ClearSetting.Text = "清除設定";
            btn_ClearSetting.UseVisualStyleBackColor = true;
            btn_ClearSetting.Click += btn_ClearSetting_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 519);
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
    }
}
