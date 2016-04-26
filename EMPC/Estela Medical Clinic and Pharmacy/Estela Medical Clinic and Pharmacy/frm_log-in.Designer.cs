namespace Estela_Medical_Clinic_and_Pharmacy
{
    partial class frm_log_in
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playUI_ControlBox1 = new PlayUI_ControlBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ambiance_Label3 = new Ambiance_Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.ambiance_Label2 = new Ambiance_Label();
            this.ambiance_Label1 = new Ambiance_Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.playUI_ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 31);
            this.panel1.TabIndex = 0;
            // 
            // playUI_ControlBox1
            // 
            this.playUI_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playUI_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.playUI_ControlBox1.Font = new System.Drawing.Font("Marlett", 7F);
            this.playUI_ControlBox1.Location = new System.Drawing.Point(481, 5);
            this.playUI_ControlBox1.Name = "playUI_ControlBox1";
            this.playUI_ControlBox1.Size = new System.Drawing.Size(45, 23);
            this.playUI_ControlBox1.TabIndex = 1;
            this.playUI_ControlBox1.Text = "playUI_ControlBox1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.ambiance_Label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 71);
            this.panel2.TabIndex = 6;
            // 
            // ambiance_Label3
            // 
            this.ambiance_Label3.AutoSize = true;
            this.ambiance_Label3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_Label3.ForeColor = System.Drawing.Color.White;
            this.ambiance_Label3.Location = new System.Drawing.Point(32, 12);
            this.ambiance_Label3.Name = "ambiance_Label3";
            this.ambiance_Label3.Size = new System.Drawing.Size(467, 45);
            this.ambiance_Label3.TabIndex = 1;
            this.ambiance_Label3.Text = "EMCP MANAGEMENT SYSTEM";
            this.ambiance_Label3.Click += new System.EventHandler(this.ambiance_Label3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(257, 254);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(97, 28);
            this.btnlogin.TabIndex = 20;
            this.btnlogin.Text = "Log-in";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.ForestGreen;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(378, 254);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(97, 28);
            this.btnclose.TabIndex = 21;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(122, 192);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(353, 25);
            this.tb_password.TabIndex = 17;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter);
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_password_KeyDown);
            this.tb_password.Leave += new System.EventHandler(this.tb_password_Leave);
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.White;
            this.tb_username.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.Black;
            this.tb_username.Location = new System.Drawing.Point(122, 149);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(353, 25);
            this.tb_username.TabIndex = 16;
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            this.tb_username.Enter += new System.EventHandler(this.tb_username_Enter);
            this.tb_username.Leave += new System.EventHandler(this.tb_username_Leave);
            // 
            // lblstatus
            // 
            this.lblstatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblstatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblstatus.Location = new System.Drawing.Point(33, 238);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(218, 60);
            this.lblstatus.TabIndex = 27;
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_Label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.ambiance_Label2.Location = new System.Drawing.Point(45, 192);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(66, 17);
            this.ambiance_Label2.TabIndex = 18;
            this.ambiance_Label2.Text = "Password :";
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambiance_Label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.ambiance_Label1.Location = new System.Drawing.Point(42, 149);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(72, 17);
            this.ambiance_Label1.TabIndex = 19;
            this.ambiance_Label1.Text = "Username :";
            // 
            // frm_log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 306);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.ambiance_Label2);
            this.Controls.Add(this.ambiance_Label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "frm_log_in";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frm_log_in_Load);
            this.Shown += new System.EventHandler(this.frm_log_in_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PlayUI_ControlBox playUI_ControlBox1;
        private System.Windows.Forms.Panel panel2;
        private Ambiance_Label ambiance_Label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private Ambiance_Label ambiance_Label2;
        private Ambiance_Label ambiance_Label1;
        private System.Windows.Forms.Label lblstatus;
    }
}