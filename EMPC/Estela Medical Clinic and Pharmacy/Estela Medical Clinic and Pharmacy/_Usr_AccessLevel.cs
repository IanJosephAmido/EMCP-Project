using System;
using vallib3._;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Lib_emcp;

namespace Estela_Medical_Clinic_and_Pharmacy
{
    public partial class _Usr_AccessLevel : UserControl
    {
        Query_AccessLevel _accesslev = new Query_AccessLevel();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        public bool status;            
        public _Usr_AccessLevel()
        {
            InitializeComponent();
            update_status();
            cmd_status.SelectedIndex = 0;
        }
        void SetGrid(DataGridView dt)
        {
            dt.Columns["sn"].Width = 30;
            dt.Columns["name"].Width = 150;
            dt.Columns["status"].Width = 80;         
            foreach (DataGridViewColumn col in dt.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
            }
        }


        void update_status()
        {
            if (cmd_status.Text == "Active")
            {
                status = true;
            }
            else
            {
                status = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new AccessLevel().ShowDialog();
        }

        private void cmd_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_status();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(tb_search.Text.Length > 0)
            {
                dataitems = _accesslev.GetData(dataitems, status, tb_search.Text.ToLower());
            }
            else
            {
                dataitems = _accesslev.GetData(dataitems, status);
            }
        }

        private void dataitems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetGrid(dataitems);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btn_search_Click(sender, e);
        }

        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }
    }
}
