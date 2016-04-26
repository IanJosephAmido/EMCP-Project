using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Lib_emcp;
using System.Windows.Forms;

namespace Estela_Medical_Clinic_and_Pharmacy
{
    public partial class _Usr_type : UserControl
    {
        Query_Item_Type itemtypeQ = new Query_Item_Type();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        public bool status;
        public _Usr_type()
        {
            InitializeComponent();
            cmd_status.SelectedIndex = 0;
            update_status();
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
        void SetGrid(DataGridView dt)
        {
            dt.Columns["sn"].Width = 30;
            dt.Columns["name"].Width = 200;
            dt.Columns["discription"].Width = 200;
            dt.Columns["status"].Width = 100;          
            foreach (DataGridViewColumn col in dt.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Type().ShowDialog();
        }

        private void dataitems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetGrid(dataitems);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            btnsearch();

        }
        void btnsearch()
        {
             if (tb_search.Text.Length > 0)
            {
                dataitems = itemtypeQ.getdata(dataitems, status);
            }
            else
            {
                dataitems = itemtypeQ.getdata(dataitems, status, tb_search.Text.ToLower());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnsearch();
        }

        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnsearch();
            }
        }
    }
}
