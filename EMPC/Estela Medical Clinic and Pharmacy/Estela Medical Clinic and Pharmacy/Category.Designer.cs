namespace Estela_Medical_Clinic_and_Pharmacy
{
    partial class Category
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_disc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 69);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Add Item Category";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmb_type);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmb_status);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblstatus);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.tb_disc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tb_name);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 252);
            this.panel2.TabIndex = 1;
            // 
            // cmb_type
            // 
            this.cmb_type.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.cmb_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(119, 40);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(134, 21);
            this.cmb_type.TabIndex = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 126;
            this.label1.Text = "Type :";
            // 
            // cmb_status
            // 
            this.cmb_status.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.cmb_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmb_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmb_status.Location = new System.Drawing.Point(119, 11);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(134, 21);
            this.cmb_status.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(51, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 126;
            this.label3.Text = "Status :";
            // 
            // lblstatus
            // 
            this.lblstatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblstatus.Location = new System.Drawing.Point(85, 212);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(221, 28);
            this.lblstatus.TabIndex = 124;
            this.lblstatus.Text = "Successfuly Saved !";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblstatus.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(407, 212);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(89, 28);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(312, 212);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 28);
            this.btn_save.TabIndex = 3;
            this.btn_save.TabStop = false;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_disc
            // 
            this.tb_disc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_disc.ForeColor = System.Drawing.Color.Black;
            this.tb_disc.Location = new System.Drawing.Point(119, 108);
            this.tb_disc.Multiline = true;
            this.tb_disc.Name = "tb_disc";
            this.tb_disc.Size = new System.Drawing.Size(377, 81);
            this.tb_disc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 122;
            this.label2.Text = "Discription:";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.Black;
            this.tb_name.Location = new System.Drawing.Point(119, 79);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(377, 22);
            this.tb_name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(49, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 123;
            this.label5.Text = "Name :";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_disc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}