namespace Estela_Medical_Clinic_and_Pharmacy
{
    partial class _Usr_Supplier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_Usr_Supplier));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataitems = new System.Windows.Forms.DataGridView();
            this.chkCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cntx_supp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlheader = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cmd_status = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataitems)).BeginInit();
            this.cntx_supp.SuspendLayout();
            this.pnlheader.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataitems);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 385);
            this.panel2.TabIndex = 9;
            // 
            // dataitems
            // 
            this.dataitems.AllowUserToAddRows = false;
            this.dataitems.AllowUserToDeleteRows = false;
            this.dataitems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            this.dataitems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataitems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataitems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataitems.ColumnHeadersHeight = 30;
            this.dataitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkCol});
            this.dataitems.ContextMenuStrip = this.cntx_supp;
            this.dataitems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataitems.GridColor = System.Drawing.SystemColors.Control;
            this.dataitems.Location = new System.Drawing.Point(0, 0);
            this.dataitems.Name = "dataitems";
            this.dataitems.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataitems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataitems.RowHeadersVisible = false;
            this.dataitems.RowHeadersWidth = 120;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataitems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataitems.Size = new System.Drawing.Size(1125, 385);
            this.dataitems.TabIndex = 153;
            this.dataitems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataitems_DataBindingComplete);
            // 
            // chkCol
            // 
            this.chkCol.HeaderText = "";
            this.chkCol.Name = "chkCol";
            this.chkCol.ReadOnly = true;
            this.chkCol.Width = 20;
            // 
            // cntx_supp
            // 
            this.cntx_supp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.statusToolStripMenuItem});
            this.cntx_supp.Name = "cntx_supp";
            this.cntx_supp.Size = new System.Drawing.Size(107, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem,
            this.inactiveToolStripMenuItem});
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.activeToolStripMenuItem.Text = "Active";
            this.activeToolStripMenuItem.Click += new System.EventHandler(this.activeToolStripMenuItem_Click);
            // 
            // inactiveToolStripMenuItem
            // 
            this.inactiveToolStripMenuItem.Name = "inactiveToolStripMenuItem";
            this.inactiveToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.inactiveToolStripMenuItem.Text = "Inactive";
            this.inactiveToolStripMenuItem.Click += new System.EventHandler(this.inactiveToolStripMenuItem_Click);
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlheader.Controls.Add(this.panel4);
            this.pnlheader.Controls.Add(this.panel3);
            this.pnlheader.Controls.Add(this.panel1);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(1125, 54);
            this.pnlheader.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tb_search);
            this.panel4.Controls.Add(this.cmd_status);
            this.panel4.Controls.Add(this.btn_search);
            this.panel4.Controls.Add(this.refresh);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(539, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 52);
            this.panel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status :";
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.White;
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.ForeColor = System.Drawing.Color.Black;
            this.tb_search.Location = new System.Drawing.Point(278, 17);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(197, 22);
            this.tb_search.TabIndex = 13;
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            // 
            // cmd_status
            // 
            this.cmd_status.BackColor = System.Drawing.Color.White;
            this.cmd_status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_status.ForeColor = System.Drawing.Color.Black;
            this.cmd_status.FormattingEnabled = true;
            this.cmd_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmd_status.Location = new System.Drawing.Point(126, 17);
            this.cmd_status.Name = "cmd_status";
            this.cmd_status.Size = new System.Drawing.Size(105, 21);
            this.cmd_status.TabIndex = 12;
            this.cmd_status.SelectedIndexChanged += new System.EventHandler(this.cmd_status_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_search.Location = new System.Drawing.Point(481, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 26);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // refresh
            // 
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(237, 13);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(35, 29);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 10;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(204, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 52);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 52);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "  SUPPLIER";
            // 
            // _Usr_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlheader);
            this.Name = "_Usr_Supplier";
            this.Size = new System.Drawing.Size(1125, 439);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataitems)).EndInit();
            this.cntx_supp.ResumeLayout(false);
            this.pnlheader.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ComboBox cmd_status;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.DataGridView dataitems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkCol;
        private System.Windows.Forms.ContextMenuStrip cntx_supp;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inactiveToolStripMenuItem;
    }
}
