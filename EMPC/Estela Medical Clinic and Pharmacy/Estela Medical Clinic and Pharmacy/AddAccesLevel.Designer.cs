namespace Estela_Medical_Clinic_and_Pharmacy
{
    partial class AddAccesLevel
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
            this.tbaccessname = new System.Windows.Forms.TextBox();
            this.tbremarks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.cmd_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbaccessname
            // 
            this.tbaccessname.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbaccessname.Location = new System.Drawing.Point(104, 98);
            this.tbaccessname.Name = "tbaccessname";
            this.tbaccessname.Size = new System.Drawing.Size(268, 22);
            this.tbaccessname.TabIndex = 2;
            this.tbaccessname.Click += new System.EventHandler(this.tbaccessname_Click);
            this.tbaccessname.Enter += new System.EventHandler(this.tbaccessname_Enter);
            // 
            // tbremarks
            // 
            this.tbremarks.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbremarks.Location = new System.Drawing.Point(104, 129);
            this.tbremarks.Multiline = true;
            this.tbremarks.Name = "tbremarks";
            this.tbremarks.Size = new System.Drawing.Size(268, 84);
            this.tbremarks.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(34, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Remarks :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(12, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Access Level :";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.ForestGreen;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(289, 262);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(83, 28);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(200, 262);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(83, 28);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // cmd_status
            // 
            this.cmd_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_status.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_status.FormattingEnabled = true;
            this.cmd_status.Items.AddRange(new object[] {
            "Active",
            "Deactivate"});
            this.cmd_status.Location = new System.Drawing.Point(104, 69);
            this.cmd_status.Name = "cmd_status";
            this.cmd_status.Size = new System.Drawing.Size(119, 21);
            this.cmd_status.TabIndex = 1;
            this.cmd_status.SelectedIndexChanged += new System.EventHandler(this.cmd_status_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Status :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Add Access Level";
            // 
            // lblstatus
            // 
            this.lblstatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblstatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblstatus.Location = new System.Drawing.Point(12, 262);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(182, 28);
            this.lblstatus.TabIndex = 26;
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddAccesLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 315);
            this.Controls.Add(this.cmd_status);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.tbaccessname);
            this.Controls.Add(this.tbremarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAccesLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccesLevel";
            this.Load += new System.EventHandler(this.AddAccesLevel_Load);
            this.Shown += new System.EventHandler(this.AddAccesLevel_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbaccessname;
        private System.Windows.Forms.TextBox tbremarks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox cmd_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblstatus;
    }
}