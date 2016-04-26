namespace Estela_Medical_Clinic_and_Pharmacy
{
    partial class Supplier
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_scode = new System.Windows.Forms.TextBox();
            this.tb_sname = new System.Windows.Forms.TextBox();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.tbcontactperson = new System.Windows.Forms.TextBox();
            this.tbTinNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbcontactnum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 57);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Supplier";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbstatus);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.tb_scode);
            this.panel3.Controls.Add(this.tb_sname);
            this.panel3.Controls.Add(this.tbaddress);
            this.panel3.Controls.Add(this.tbcontactperson);
            this.panel3.Controls.Add(this.tbTinNum);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tbcontactnum);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 349);
            this.panel3.TabIndex = 4;
            // 
            // cmbstatus
            // 
            this.cmbstatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.cmbstatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbstatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbstatus.Enabled = false;
            this.cmbstatus.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbstatus.Location = new System.Drawing.Point(116, 22);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(106, 21);
            this.cmbstatus.TabIndex = 0;
            this.cmbstatus.SelectedIndexChanged += new System.EventHandler(this.cmbstatus_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(71, 25);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 22);
            this.label27.TabIndex = 81;
            this.label27.Text = "Status :";
            // 
            // tb_scode
            // 
            this.tb_scode.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_scode.Location = new System.Drawing.Point(117, 81);
            this.tb_scode.Name = "tb_scode";
            this.tb_scode.Size = new System.Drawing.Size(74, 22);
            this.tb_scode.TabIndex = 2;
            this.tb_scode.Enter += new System.EventHandler(this.tb_scode_Enter);
            this.tb_scode.Leave += new System.EventHandler(this.tb_scode_Leave);
            // 
            // tb_sname
            // 
            this.tb_sname.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sname.Location = new System.Drawing.Point(117, 53);
            this.tb_sname.Name = "tb_sname";
            this.tb_sname.Size = new System.Drawing.Size(231, 22);
            this.tb_sname.TabIndex = 1;
            this.tb_sname.Enter += new System.EventHandler(this.enter);
            this.tb_sname.Leave += new System.EventHandler(this.leave);
            // 
            // tbaddress
            // 
            this.tbaddress.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaddress.Location = new System.Drawing.Point(116, 181);
            this.tbaddress.Multiline = true;
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(395, 69);
            this.tbaddress.TabIndex = 6;
            this.tbaddress.Enter += new System.EventHandler(this.enter);
            this.tbaddress.Leave += new System.EventHandler(this.leave);
            // 
            // tbcontactperson
            // 
            this.tbcontactperson.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontactperson.Location = new System.Drawing.Point(116, 121);
            this.tbcontactperson.Name = "tbcontactperson";
            this.tbcontactperson.Size = new System.Drawing.Size(395, 22);
            this.tbcontactperson.TabIndex = 3;
            this.tbcontactperson.Enter += new System.EventHandler(this.enter);
            this.tbcontactperson.Leave += new System.EventHandler(this.leave);
            // 
            // tbTinNum
            // 
            this.tbTinNum.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTinNum.Location = new System.Drawing.Point(333, 153);
            this.tbTinNum.Name = "tbTinNum";
            this.tbTinNum.Size = new System.Drawing.Size(178, 22);
            this.tbTinNum.TabIndex = 5;
            this.tbTinNum.Enter += new System.EventHandler(this.enter);
            this.tbTinNum.Leave += new System.EventHandler(this.leave);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 22);
            this.label8.TabIndex = 77;
            this.label8.Text = "TIN # :";
            // 
            // tbcontactnum
            // 
            this.tbcontactnum.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontactnum.Location = new System.Drawing.Point(116, 153);
            this.tbcontactnum.Name = "tbcontactnum";
            this.tbcontactnum.Size = new System.Drawing.Size(171, 22);
            this.tbcontactnum.TabIndex = 4;
            this.tbcontactnum.Enter += new System.EventHandler(this.enter);
            this.tbcontactnum.Leave += new System.EventHandler(this.leave);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 79;
            this.label6.Text = "Contact Person :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(69, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 76;
            this.label4.Text = "Name :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(61, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "Address :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 80;
            this.label5.Text = "Supplier Code :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 78;
            this.label2.Text = "Contact # :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblstatus);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 50);
            this.panel2.TabIndex = 5;
            // 
            // lblstatus
            // 
            this.lblstatus.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblstatus.Location = new System.Drawing.Point(100, 10);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(221, 28);
            this.lblstatus.TabIndex = 103;
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(422, 10);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(89, 28);
            this.btn_close.TabIndex = 102;
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
            this.btn_save.Location = new System.Drawing.Point(327, 10);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 28);
            this.btn_save.TabIndex = 101;
            this.btn_save.TabStop = false;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tb_scode;
        private System.Windows.Forms.TextBox tb_sname;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.TextBox tbcontactperson;
        private System.Windows.Forms.TextBox tbTinNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbcontactnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
    }
}