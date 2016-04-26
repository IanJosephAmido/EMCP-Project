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
   
    public partial class _Usr_Supplier : UserControl
    {
        Query_Supplier supplier = new Query_Supplier();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        public bool status;
        public _Usr_Supplier()
        {
            InitializeComponent();
            cmd_status.SelectedIndex = 0;
            update_status();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Supplier().ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(tb_search.Text.Length > 0)
            {
                if (status == true)
                {
                    supplier.GetSuppData(dataitems, true, tb_search.Text.ToLower());
                }
                else
                {
                    supplier.GetSuppData(dataitems, false, tb_search.Text.ToLower());
                }
            }
            else
            {               
                if (status == true)
                {
                    supplier.GetSuppData(dataitems, true);
                }
                else
                {
                    supplier.GetSuppData(dataitems, false);
                }

            }
        }

        private void cmd_status_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        private void refresh_Click(object sender, EventArgs e)
        {
            btn_search.PerformClick();
        }
        void SetGrid(DataGridView dt)
        {
            dt.Columns["code"].Width = 90;
            dt.Columns["name"].Width = 200;
            dt.Columns["address"].Width = 200;
            dt.Columns["contact_person"].Width = 150;
            dt.Columns["contact_num"].Width = 100;
            dt.Columns["status"].Width = 50;          
            dt.Columns["id"].Visible = false;
            foreach (DataGridViewColumn col in dt.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
            }
        }

        private void dataitems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetGrid(dataitems);
        }

        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataitems.SelectedRows.Count == 1)
            {
                new Supplier(dataitems.SelectedRows[0].Cells["id"].Value.ToString()).ShowDialog();
            }
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataitems.SelectedRows.Count == 1)
            {
                supplier.updatestat(true, dataitems.SelectedRows[0].Cells["id"].Value.ToString());
            }            
        }

        private void inactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataitems.SelectedRows.Count == 1)
            {
                supplier.updatestat(false, dataitems.SelectedRows[0].Cells["id"].Value.ToString());
            }
        }
    }
}
