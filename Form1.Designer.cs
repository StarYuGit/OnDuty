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
            SuspendLayout();
            // 
            // lb_InputHoliDay
            // 
            lb_InputHoliDay.AutoSize = true;
            lb_InputHoliDay.Location = new Point(54, 24);
            lb_InputHoliDay.Margin = new Padding(6, 0, 6, 0);
            lb_InputHoliDay.Name = "lb_InputHoliDay";
            lb_InputHoliDay.Size = new Size(216, 30);
            lb_InputHoliDay.TabIndex = 0;
            lb_InputHoliDay.Text = "匯入行事例csv檔：";
            // 
            // tb_InputHoliDay
            // 
            tb_InputHoliDay.Location = new Point(282, 18);
            tb_InputHoliDay.Margin = new Padding(6);
            tb_InputHoliDay.Name = "tb_InputHoliDay";
            tb_InputHoliDay.Size = new Size(436, 38);
            tb_InputHoliDay.TabIndex = 1;
            // 
            // btn_InputHoliDay
            // 
            btn_InputHoliDay.Location = new Point(902, 18);
            btn_InputHoliDay.Margin = new Padding(6);
            btn_InputHoliDay.Name = "btn_InputHoliDay";
            btn_InputHoliDay.Size = new Size(150, 46);
            btn_InputHoliDay.TabIndex = 2;
            btn_InputHoliDay.Text = "匯入";
            btn_InputHoliDay.UseVisualStyleBackColor = true;
            btn_InputHoliDay.Click += btn_InputHoliDay_Click;
            // 
            // lb_InputPerson
            // 
            lb_InputPerson.AutoSize = true;
            lb_InputPerson.Location = new Point(54, 102);
            lb_InputPerson.Margin = new Padding(6, 0, 6, 0);
            lb_InputPerson.Name = "lb_InputPerson";
            lb_InputPerson.Size = new Size(205, 30);
            lb_InputPerson.TabIndex = 3;
            lb_InputPerson.Text = "匯入排班人名單：";
            // 
            // btn_InputPerson
            // 
            btn_InputPerson.Location = new Point(902, 92);
            btn_InputPerson.Margin = new Padding(6);
            btn_InputPerson.Name = "btn_InputPerson";
            btn_InputPerson.Size = new Size(150, 46);
            btn_InputPerson.TabIndex = 4;
            btn_InputPerson.Text = "匯入";
            btn_InputPerson.UseVisualStyleBackColor = true;
            btn_InputPerson.Click += btn_InputPerson_Click;
            // 
            // tb_InputPerson
            // 
            tb_InputPerson.Location = new Point(282, 94);
            tb_InputPerson.Margin = new Padding(6);
            tb_InputPerson.Name = "tb_InputPerson";
            tb_InputPerson.Size = new Size(436, 38);
            tb_InputPerson.TabIndex = 5;
            // 
            // lb_CounterName
            // 
            lb_CounterName.AutoSize = true;
            lb_CounterName.Location = new Point(54, 180);
            lb_CounterName.Margin = new Padding(6, 0, 6, 0);
            lb_CounterName.Name = "lb_CounterName";
            lb_CounterName.Size = new Size(133, 30);
            lb_CounterName.TabIndex = 6;
            lb_CounterName.Text = "櫃台人員：";
            // 
            // tb_CounterName
            // 
            tb_CounterName.Location = new Point(282, 174);
            tb_CounterName.Margin = new Padding(6);
            tb_CounterName.Name = "tb_CounterName";
            tb_CounterName.Size = new Size(196, 38);
            tb_CounterName.TabIndex = 7;
            // 
            // lb_SelectDate
            // 
            lb_SelectDate.AutoSize = true;
            lb_SelectDate.Location = new Point(54, 254);
            lb_SelectDate.Margin = new Padding(6, 0, 6, 0);
            lb_SelectDate.Name = "lb_SelectDate";
            lb_SelectDate.Size = new Size(229, 30);
            lb_SelectDate.TabIndex = 8;
            lb_SelectDate.Text = "選擇排班起始日期：";
            // 
            // tabDates
            // 
            tabDates.Location = new Point(54, 326);
            tabDates.Margin = new Padding(6);
            tabDates.Name = "tabDates";
            tabDates.SelectedIndex = 0;
            tabDates.Size = new Size(664, 550);
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
            btn_InputHoliDayFile.Location = new Point(740, 18);
            btn_InputHoliDayFile.Margin = new Padding(6);
            btn_InputHoliDayFile.Name = "btn_InputHoliDayFile";
            btn_InputHoliDayFile.Size = new Size(150, 46);
            btn_InputHoliDayFile.TabIndex = 10;
            btn_InputHoliDayFile.Text = "選擇檔案";
            btn_InputHoliDayFile.UseVisualStyleBackColor = true;
            btn_InputHoliDayFile.Click += btn_InputHoliDayFile_Click;
            // 
            // btn_InputPersonFile
            // 
            btn_InputPersonFile.Location = new Point(740, 94);
            btn_InputPersonFile.Margin = new Padding(6);
            btn_InputPersonFile.Name = "btn_InputPersonFile";
            btn_InputPersonFile.Size = new Size(150, 46);
            btn_InputPersonFile.TabIndex = 11;
            btn_InputPersonFile.Text = "選擇檔案";
            btn_InputPersonFile.UseVisualStyleBackColor = true;
            // 
            // lb_SelectPerson
            // 
            lb_SelectPerson.AutoSize = true;
            lb_SelectPerson.Location = new Point(520, 258);
            lb_SelectPerson.Margin = new Padding(6, 0, 6, 0);
            lb_SelectPerson.Name = "lb_SelectPerson";
            lb_SelectPerson.Size = new Size(229, 30);
            lb_SelectPerson.TabIndex = 12;
            lb_SelectPerson.Text = "選擇排班起始人員：";
            // 
            // tb_SelectDateResult
            // 
            tb_SelectDateResult.Location = new Point(282, 248);
            tb_SelectDateResult.Margin = new Padding(6);
            tb_SelectDateResult.Name = "tb_SelectDateResult";
            tb_SelectDateResult.Size = new Size(196, 38);
            tb_SelectDateResult.TabIndex = 13;
            // 
            // tb_SelectPersonResult
            // 
            tb_SelectPersonResult.Location = new Point(740, 248);
            tb_SelectPersonResult.Margin = new Padding(6);
            tb_SelectPersonResult.Name = "tb_SelectPersonResult";
            tb_SelectPersonResult.Size = new Size(150, 38);
            tb_SelectPersonResult.TabIndex = 14;
            // 
            // lv_person
            // 
            lv_person.FullRowSelect = true;
            lv_person.GridLines = true;
            lv_person.Location = new Point(740, 328);
            lv_person.Name = "lv_person";
            lv_person.Size = new Size(451, 548);
            lv_person.TabIndex = 15;
            lv_person.UseCompatibleStateImageBehavior = false;
            lv_person.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 900);
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
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
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
    }
}
