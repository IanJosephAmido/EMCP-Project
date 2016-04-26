namespace Estela_Medical_Clinic_and_Pharmacy
{
    partial class Patient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_mstatus = new System.Windows.Forms.ComboBox();
            this.tb_mname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_lname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_address1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_contactnum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_telnum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmd_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_phicnum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_MC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmd_type = new System.Windows.Forms.ComboBox();
            this.dtp_bdate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.tb_address2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_bdate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 57);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Patient";
            // 
            // cmd_mstatus
            // 
            this.cmd_mstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_mstatus.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_mstatus.ForeColor = System.Drawing.Color.Black;
            this.cmd_mstatus.FormattingEnabled = true;
            this.cmd_mstatus.Items.AddRange(new object[] {
            "Married",
            "Engaged",
            "Separated",
            "Widowed",
            "Never Married"});
            this.cmd_mstatus.Location = new System.Drawing.Point(402, 176);
            this.cmd_mstatus.Name = "cmd_mstatus";
            this.cmd_mstatus.Size = new System.Drawing.Size(122, 21);
            this.cmd_mstatus.TabIndex = 6;
            // 
            // tb_mname
            // 
            this.tb_mname.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mname.ForeColor = System.Drawing.Color.Black;
            this.tb_mname.Location = new System.Drawing.Point(689, 136);
            this.tb_mname.MaxLength = 1;
            this.tb_mname.Name = "tb_mname";
            this.tb_mname.Size = new System.Drawing.Size(53, 22);
            this.tb_mname.TabIndex = 4;
            this.tb_mname.TextChanged += new System.EventHandler(this.tb_mname_TextChanged);
            this.tb_mname.Enter += new System.EventHandler(this.enter);
            this.tb_mname.Leave += new System.EventHandler(this.leave);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(604, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Middle Name :";
            // 
            // tb_fname
            // 
            this.tb_fname.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fname.ForeColor = System.Drawing.Color.Black;
            this.tb_fname.Location = new System.Drawing.Point(402, 137);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(190, 22);
            this.tb_fname.TabIndex = 3;
            this.tb_fname.Enter += new System.EventHandler(this.enter);
            this.tb_fname.Leave += new System.EventHandler(this.leave);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(333, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "First Name :";
            // 
            // tb_lname
            // 
            this.tb_lname.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lname.ForeColor = System.Drawing.Color.Black;
            this.tb_lname.Location = new System.Drawing.Point(102, 136);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.Size = new System.Drawing.Size(212, 22);
            this.tb_lname.TabIndex = 2;
            this.tb_lname.Enter += new System.EventHandler(this.enter);
            this.tb_lname.Leave += new System.EventHandler(this.leave);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "BirthDate :";
            // 
            // cmd_gender
            // 
            this.cmd_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_gender.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_gender.ForeColor = System.Drawing.Color.Black;
            this.cmd_gender.FormattingEnabled = true;
            this.cmd_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmd_gender.Location = new System.Drawing.Point(588, 176);
            this.cmd_gender.Name = "cmd_gender";
            this.cmd_gender.Size = new System.Drawing.Size(122, 21);
            this.cmd_gender.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(319, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Marital Status :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(534, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Gender :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 40);
            this.label8.TabIndex = 26;
            this.label8.Text = "Street Barangay :";
            // 
            // tb_address1
            // 
            this.tb_address1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address1.ForeColor = System.Drawing.Color.Black;
            this.tb_address1.Location = new System.Drawing.Point(102, 224);
            this.tb_address1.Name = "tb_address1";
            this.tb_address1.Size = new System.Drawing.Size(212, 22);
            this.tb_address1.TabIndex = 8;
            this.tb_address1.Enter += new System.EventHandler(this.enter);
            this.tb_address1.Leave += new System.EventHandler(this.leave);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(365, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "City :";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(45, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 34);
            this.label10.TabIndex = 26;
            this.label10.Text = "Contact Number :";
            // 
            // tb_contactnum
            // 
            this.tb_contactnum.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contactnum.ForeColor = System.Drawing.Color.Black;
            this.tb_contactnum.Location = new System.Drawing.Point(102, 258);
            this.tb_contactnum.Name = "tb_contactnum";
            this.tb_contactnum.Size = new System.Drawing.Size(212, 22);
            this.tb_contactnum.TabIndex = 10;
            this.tb_contactnum.Enter += new System.EventHandler(this.enter);
            this.tb_contactnum.Leave += new System.EventHandler(this.leave);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(326, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tel Number :";
            // 
            // tb_telnum
            // 
            this.tb_telnum.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telnum.ForeColor = System.Drawing.Color.Black;
            this.tb_telnum.Location = new System.Drawing.Point(402, 258);
            this.tb_telnum.Name = "tb_telnum";
            this.tb_telnum.Size = new System.Drawing.Size(190, 22);
            this.tb_telnum.TabIndex = 11;
            this.tb_telnum.Enter += new System.EventHandler(this.enter);
            this.tb_telnum.Leave += new System.EventHandler(this.leave);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(20, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "Patient Status :";
            // 
            // cmd_status
            // 
            this.cmd_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_status.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_status.ForeColor = System.Drawing.Color.Black;
            this.cmd_status.FormattingEnabled = true;
            this.cmd_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmd_status.Location = new System.Drawing.Point(102, 74);
            this.cmd_status.Name = "cmd_status";
            this.cmd_status.Size = new System.Drawing.Size(124, 21);
            this.cmd_status.TabIndex = 0;
            this.cmd_status.SelectedIndexChanged += new System.EventHandler(this.cmd_status_SelectedIndexChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_status.Location = new System.Drawing.Point(426, 370);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(221, 28);
            this.lbl_status.TabIndex = 100;
            this.lbl_status.Text = " ";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(748, 370);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(89, 28);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(653, 370);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 28);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(48, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 23);
            this.label14.TabIndex = 27;
            this.label14.Text = "PHIC # :";
            // 
            // tb_phicnum
            // 
            this.tb_phicnum.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phicnum.ForeColor = System.Drawing.Color.Black;
            this.tb_phicnum.Location = new System.Drawing.Point(102, 306);
            this.tb_phicnum.Name = "tb_phicnum";
            this.tb_phicnum.Size = new System.Drawing.Size(212, 22);
            this.tb_phicnum.TabIndex = 12;
            this.tb_phicnum.Enter += new System.EventHandler(this.enter);
            this.tb_phicnum.Leave += new System.EventHandler(this.leave);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 340);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 23);
            this.label15.TabIndex = 26;
            this.label15.Text = "MC/Insurance # :";
            // 
            // tb_MC
            // 
            this.tb_MC.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MC.ForeColor = System.Drawing.Color.Black;
            this.tb_MC.Location = new System.Drawing.Point(102, 336);
            this.tb_MC.Name = "tb_MC";
            this.tb_MC.Size = new System.Drawing.Size(212, 22);
            this.tb_MC.TabIndex = 13;
            this.tb_MC.Enter += new System.EventHandler(this.enter);
            this.tb_MC.Leave += new System.EventHandler(this.leave);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(25, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 23);
            this.label16.TabIndex = 28;
            this.label16.Text = "Patient Type :";
            // 
            // cmd_type
            // 
            this.cmd_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_type.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_type.ForeColor = System.Drawing.Color.Black;
            this.cmd_type.FormattingEnabled = true;
            this.cmd_type.Items.AddRange(new object[] {
            "Regular",
            "Employee",
            "Management"});
            this.cmd_type.Location = new System.Drawing.Point(102, 103);
            this.cmd_type.Name = "cmd_type";
            this.cmd_type.Size = new System.Drawing.Size(212, 21);
            this.cmd_type.TabIndex = 1;
            this.cmd_type.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dtp_bdate
            // 
            this.dtp_bdate.AutoSelectDate = true;
            // 
            // 
            // 
            this.dtp_bdate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtp_bdate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtp_bdate.ButtonDropDown.Visible = true;
            this.dtp_bdate.CustomFormat = "MM-dd-yyyy";
            this.dtp_bdate.FocusHighlightColor = System.Drawing.Color.LightGreen;
            this.dtp_bdate.FocusHighlightEnabled = true;
            this.dtp_bdate.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_bdate.ForeColor = System.Drawing.Color.Black;
            this.dtp_bdate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtp_bdate.Location = new System.Drawing.Point(102, 176);
            // 
            // 
            // 
            this.dtp_bdate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_bdate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtp_bdate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtp_bdate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtp_bdate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_bdate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtp_bdate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtp_bdate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtp_bdate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtp_bdate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtp_bdate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtp_bdate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtp_bdate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtp_bdate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtp_bdate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtp_bdate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtp_bdate.MonthCalendar.TodayButtonVisible = true;
            this.dtp_bdate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtp_bdate.Name = "dtp_bdate";
            this.dtp_bdate.Size = new System.Drawing.Size(212, 22);
            this.dtp_bdate.TabIndex = 5;
            // 
            // tb_address2
            // 
            this.tb_address2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address2.ForeColor = System.Drawing.Color.Black;
            this.tb_address2.Location = new System.Drawing.Point(402, 224);
            this.tb_address2.Name = "tb_address2";
            this.tb_address2.Size = new System.Drawing.Size(306, 22);
            this.tb_address2.TabIndex = 9;
            this.tb_address2.Enter += new System.EventHandler(this.enter);
            this.tb_address2.Leave += new System.EventHandler(this.leave);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 411);
            this.Controls.Add(this.dtp_bdate);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmd_type);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmd_status);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmd_gender);
            this.Controls.Add(this.cmd_mstatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_telnum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_address2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_contactnum);
            this.Controls.Add(this.tb_mname);
            this.Controls.Add(this.tb_address1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_MC);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.tb_phicnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_bdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmd_mstatus;
        private System.Windows.Forms.TextBox tb_mname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_lname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmd_gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_address1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_contactnum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_telnum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmd_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_phicnum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_MC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmd_type;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtp_bdate;
        private System.Windows.Forms.TextBox tb_address2;
    }
}