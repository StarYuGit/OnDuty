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
            label1 = new Label();
            tabDates = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btn_InputHoliDayFile = new Button();
            btn_InputPersonFile = new Button();
            SuspendLayout();
            // 
            // lb_InputHoliDay
            // 
            lb_InputHoliDay.AutoSize = true;
            lb_InputHoliDay.Location = new Point(27, 12);
            lb_InputHoliDay.Name = "lb_InputHoliDay";
            lb_InputHoliDay.Size = new Size(108, 15);
            lb_InputHoliDay.TabIndex = 0;
            lb_InputHoliDay.Text = "匯入行事例csv檔：";
            // 
            // tb_InputHoliDay
            // 
            tb_InputHoliDay.Location = new Point(141, 9);
            tb_InputHoliDay.Name = "tb_InputHoliDay";
            tb_InputHoliDay.Size = new Size(220, 23);
            tb_InputHoliDay.TabIndex = 1;
            // 
            // btn_InputHoliDay
            // 
            btn_InputHoliDay.Location = new Point(451, 9);
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
            lb_InputPerson.Location = new Point(27, 62);
            lb_InputPerson.Name = "lb_InputPerson";
            lb_InputPerson.Size = new Size(103, 15);
            lb_InputPerson.TabIndex = 3;
            lb_InputPerson.Text = "匯入排班人名單：";
            // 
            // btn_InputPerson
            // 
            btn_InputPerson.Location = new Point(451, 57);
            btn_InputPerson.Name = "btn_InputPerson";
            btn_InputPerson.Size = new Size(75, 23);
            btn_InputPerson.TabIndex = 4;
            btn_InputPerson.Text = "匯入";
            btn_InputPerson.UseVisualStyleBackColor = true;
            // 
            // tb_InputPerson
            // 
            tb_InputPerson.Location = new Point(141, 58);
            tb_InputPerson.Name = "tb_InputPerson";
            tb_InputPerson.Size = new Size(220, 23);
            tb_InputPerson.TabIndex = 5;
            // 
            // lb_CounterName
            // 
            lb_CounterName.AutoSize = true;
            lb_CounterName.Location = new Point(27, 112);
            lb_CounterName.Name = "lb_CounterName";
            lb_CounterName.Size = new Size(67, 15);
            lb_CounterName.TabIndex = 6;
            lb_CounterName.Text = "櫃台人員：";
            // 
            // tb_CounterName
            // 
            tb_CounterName.Location = new Point(141, 109);
            tb_CounterName.Name = "tb_CounterName";
            tb_CounterName.Size = new Size(100, 23);
            tb_CounterName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 117);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // tabDates
            // 
            tabDates.Location = new Point(27, 138);
            tabDates.Name = "tabDates";
            tabDates.SelectedIndex = 0;
            tabDates.Size = new Size(512, 300);
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
            btn_InputHoliDayFile.Location = new Point(370, 9);
            btn_InputHoliDayFile.Name = "btn_InputHoliDayFile";
            btn_InputHoliDayFile.Size = new Size(75, 23);
            btn_InputHoliDayFile.TabIndex = 10;
            btn_InputHoliDayFile.Text = "選擇檔案";
            btn_InputHoliDayFile.UseVisualStyleBackColor = true;
            btn_InputHoliDayFile.Click += btn_InputHoliDayFile_Click;
            // 
            // btn_InputPersonFile
            // 
            btn_InputPersonFile.Location = new Point(370, 58);
            btn_InputPersonFile.Name = "btn_InputPersonFile";
            btn_InputPersonFile.Size = new Size(75, 23);
            btn_InputPersonFile.TabIndex = 11;
            btn_InputPersonFile.Text = "選擇檔案";
            btn_InputPersonFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_InputPersonFile);
            Controls.Add(btn_InputHoliDayFile);
            Controls.Add(tabDates);
            Controls.Add(label1);
            Controls.Add(tb_CounterName);
            Controls.Add(lb_CounterName);
            Controls.Add(tb_InputPerson);
            Controls.Add(btn_InputPerson);
            Controls.Add(lb_InputPerson);
            Controls.Add(btn_InputHoliDay);
            Controls.Add(tb_InputHoliDay);
            Controls.Add(lb_InputHoliDay);
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
        private Label label1;
        private TabControl tabDates;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btn_InputHoliDayFile;
        private Button btn_InputPersonFile;
    }
}
