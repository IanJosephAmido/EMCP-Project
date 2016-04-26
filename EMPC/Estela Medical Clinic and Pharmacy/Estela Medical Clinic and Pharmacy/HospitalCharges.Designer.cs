namespace Estela_Medical_Clinic_and_Pharmacy
{
    partial class HospitalCharges
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
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lnk_add = new System.Windows.Forms.LinkLabel();
            this.cmd_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_category = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_mc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_phicfee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_hpcharge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_discription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_chargename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_savenew = new System.Windows.Forms.Button();
            this.tb_trxnum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 56);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Hospital Charges";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(119, 114);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(113, 22);
            this.dtp_date.TabIndex = 20;
            // 
            // lnk_add
            // 
            this.lnk_add.AutoSize = true;
            this.lnk_add.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_add.Location = new System.Drawing.Point(377, 148);
            this.lnk_add.Name = "lnk_add";
            this.lnk_add.Size = new System.Drawing.Size(36, 13);
            this.lnk_add.TabIndex = 91;
            this.lnk_add.TabStop = true;
            this.lnk_add.Text = "+ Add";
            this.lnk_add.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmd_status
            // 
            this.cmd_status.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.cmd_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmd_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmd_status.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_status.FormattingEnabled = true;
            this.cmd_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmd_status.Location = new System.Drawing.Point(119, 86);
            this.cmd_status.Name = "cmd_status";
            this.cmd_status.Size = new System.Drawing.Size(113, 21);
            this.cmd_status.TabIndex = 81;
            this.cmd_status.SelectedIndexChanged += new System.EventHandler(this.cmd_status_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(77, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 90;
            this.label7.Text = "Date :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(73, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 89;
            this.label2.Text = "Status :";
            // 
            // cmd_category
            // 
            this.cmd_category.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.cmd_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmd_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmd_category.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_category.FormattingEnabled = true;
            this.cmd_category.Location = new System.Drawing.Point(119, 145);
            this.cmd_category.Name = "cmd_category";
            this.cmd_category.Size = new System.Drawing.Size(248, 21);
            this.cmd_category.TabIndex = 1;
            this.cmd_category.Enter += new System.EventHandler(this.cmd_category_Enter);
            this.cmd_category.Leave += new System.EventHandler(this.cmd_category_Leave);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(20, 148);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(112, 22);
            this.label27.TabIndex = 88;
            this.label27.Text = "Charge Category :";
            // 
            // tb_mc
            // 
            this.tb_mc.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mc.Location = new System.Drawing.Point(264, 376);
            this.tb_mc.Name = "tb_mc";
            this.tb_mc.Size = new System.Drawing.Size(143, 22);
            this.tb_mc.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(170, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 87;
            this.label6.Text = "Insurance/MC :";
            // 
            // tb_phicfee
            // 
            this.tb_phicfee.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phicfee.Location = new System.Drawing.Point(264, 348);
            this.tb_phicfee.Name = "tb_phicfee";
            this.tb_phicfee.Size = new System.Drawing.Size(143, 22);
            this.tb_phicfee.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(196, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 85;
            this.label5.Text = "PHIC Fee :";
            // 
            // tb_hpcharge
            // 
            this.tb_hpcharge.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hpcharge.Location = new System.Drawing.Point(264, 319);
            this.tb_hpcharge.Name = "tb_hpcharge";
            this.tb_hpcharge.Size = new System.Drawing.Size(143, 22);
            this.tb_hpcharge.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(166, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 84;
            this.label3.Text = "Hospital Charge :";
            // 
            // tb_discription
            // 
            this.tb_discription.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_discription.Location = new System.Drawing.Point(119, 239);
            this.tb_discription.Multiline = true;
            this.tb_discription.Name = "tb_discription";
            this.tb_discription.Size = new System.Drawing.Size(288, 63);
            this.tb_discription.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(46, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 83;
            this.label8.Text = "Discription :";
            // 
            // tb_chargename
            // 
            this.tb_chargename.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_chargename.Location = new System.Drawing.Point(119, 208);
            this.tb_chargename.Name = "tb_chargename";
            this.tb_chargename.Size = new System.Drawing.Size(288, 22);
            this.tb_chargename.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 86;
            this.label4.Text = "Charge Name :";
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_status.Location = new System.Drawing.Point(-1, 473);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(194, 28);
            this.lbl_status.TabIndex = 103;
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(318, 473);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(89, 28);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_savenew
            // 
            this.btn_savenew.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_savenew.FlatAppearance.BorderSize = 0;
            this.btn_savenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savenew.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savenew.ForeColor = System.Drawing.Color.White;
            this.btn_savenew.Location = new System.Drawing.Point(199, 473);
            this.btn_savenew.Name = "btn_savenew";
            this.btn_savenew.Size = new System.Drawing.Size(113, 28);
            this.btn_savenew.TabIndex = 7;
            this.btn_savenew.Text = "Save And New";
            this.btn_savenew.UseVisualStyleBackColor = false;
            this.btn_savenew.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_trxnum
            // 
            this.tb_trxnum.Enabled = false;
            this.tb_trxnum.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_trxnum.ForeColor = System.Drawing.Color.Red;
            this.tb_trxnum.Location = new System.Drawing.Point(294, 85);
            this.tb_trxnum.Name = "tb_trxnum";
            this.tb_trxnum.Size = new System.Drawing.Size(113, 22);
            this.tb_trxnum.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(243, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 22);
            this.label9.TabIndex = 89;
            this.label9.Text = "Trx num :";
            // 
            // HospitalCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 513);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_savenew);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.lnk_add);
            this.Controls.Add(this.cmd_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmd_category);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.tb_mc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_phicfee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_hpcharge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_discription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_trxnum);
            this.Controls.Add(this.tb_chargename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HospitalCharges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.LinkLabel lnk_add;
        private System.Windows.Forms.ComboBox cmd_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmd_category;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tb_mc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_phicfee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_hpcharge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_discription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_chargename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_savenew;
        private System.Windows.Forms.TextBox tb_trxnum;
        private System.Windows.Forms.Label label9;
    }
}