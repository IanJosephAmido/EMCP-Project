namespace Estela_Medical_Clinic_and_Pharmacy
{
    partial class AddChargeCategory
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
            this.cmd_status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_discription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_status
            // 
            this.cmd_status.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.cmd_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmd_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmd_status.Enabled = false;
            this.cmd_status.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_status.FormattingEnabled = true;
            this.cmd_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmd_status.Location = new System.Drawing.Point(117, 69);
            this.cmd_status.Name = "cmd_status";
            this.cmd_status.Size = new System.Drawing.Size(132, 21);
            this.cmd_status.TabIndex = 74;
            this.cmd_status.SelectedIndexChanged += new System.EventHandler(this.cmd_status_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(65, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 77;
            this.label2.Text = "Status :";
            // 
            // tb_discription
            // 
            this.tb_discription.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_discription.Location = new System.Drawing.Point(117, 130);
            this.tb_discription.Multiline = true;
            this.tb_discription.Name = "tb_discription";
            this.tb_discription.Size = new System.Drawing.Size(356, 82);
            this.tb_discription.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(42, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "Discription :";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(117, 98);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(356, 22);
            this.tb_name.TabIndex = 1;
            this.tb_name.Enter += new System.EventHandler(this.tb_name_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(21, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 76;
            this.label4.Text = "Charge Name :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 33);
            this.label1.TabIndex = 78;
            this.label1.Text = "Add Category";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(384, 235);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(89, 28);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(289, 235);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 28);
            this.btn_save.TabIndex = 4;
            this.btn_save.TabStop = false;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_status.Location = new System.Drawing.Point(62, 235);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(221, 28);
            this.lbl_status.TabIndex = 97;
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddChargeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 277);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_discription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddChargeCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmd_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_discription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_status;
    }
}