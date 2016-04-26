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
    public partial class _Usr_hospital_charges : UserControl
    {
        Query_HospitalChargesCategory _categories = new Query_HospitalChargesCategory();
        Query_HospitalChargesDet _charges = new Query_HospitalChargesDet();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        public bool status;
        public _Usr_hospital_charges()
        {
            InitializeComponent();
            cmd_category = _categories.getcategoryname(cmd_category);
            cmd_status.SelectedIndex = 0;
            cmd_category.SelectedIndex = 0;
            update_status();
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new HospitalCharges().ShowDialog();
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
            dt.Columns["category"].Width = 200;
            dt.Columns["charge_name"].Width = 200;
            dt.Columns["charge_discription"].Width = 200;
            dt.Columns["hospital_fee"].Width = 100;
            dt.Columns["phic_fee"].Width = 100;
            dt.Columns["mc_fee"].Width = 100;
            dt.Columns["status"].Width = 80;
            dt.Columns["id"].Visible = false;
            dt.Columns["trx_num"].Visible = false;
            foreach (DataGridViewColumn col in dt.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
            }
        }

        private void dataitems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetGrid(dataitems);
        }

        private void cmd_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_status();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_search.Text.Length > 0)
            {
                if (cmd_category.Text == "All")
                {
                    dataitems = _charges.Getdetailsall(dataitems, status, tb_search.Text.ToLower());
                }
                else
                {
                    dataitems = _charges.Getdetails(dataitems, status, cmd_category.Text, tb_search.Text.ToLower());
                }
            }
            else
            {
                if (cmd_category.Text == "All")
                {
                    dataitems = _charges.Getdetails(dataitems, status);
                }
                else
                {
                    dataitems = _charges.Getdetails(dataitems, status, cmd_category.Text);
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataitems.SelectedRows.Count > 0)
            {
                new HospitalCharges(dataitems.SelectedRows[0].Cells["trx_num"].Value.ToString(), status).ShowDialog();
            }
        }
        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataitems.SelectedRows.Count > 0)
            {
                _charges.update_stat(true, dataitems.SelectedRows[0].Cells["trx_num"].Value.ToString());
            }
        }
        private void inactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataitems.SelectedRows.Count > 0)
            {
                _charges.update_stat(false, dataitems.SelectedRows[0].Cells["trx_num"].Value.ToString());
            }
        }
    }
}
