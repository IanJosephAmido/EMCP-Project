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
    public partial class _Usr_patient : UserControl
    {
        Query_Patient patient_mas = new Query_Patient();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        public _Usr_patient()
        {
            InitializeComponent();
           
            cmd_status.SelectedIndex = 0;
            cmd_type.SelectedIndex = 0;
            statcmd();
        }
        void SetGrid(DataGridView dt)
        {
            dt.Columns["sn"].Width = 30;
            dt.Columns["type"].Width = 100;
            dt.Columns["name"].Width = 250;
            dt.Columns["address"].Width = 300;
            dt.Columns["gender"].Width = 60;
            dt.Columns["contact_num"].Width = 120;
            dt.Columns["phic_num"].Width = 120;
            dt.Columns["mc_num"].Width = 120;
            dt.Columns["id"].Visible = false;
            foreach (DataGridViewColumn col in dt.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Patient().ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btn_search.PerformClick();
            //if (stat == true)
            //{
            //    dataitems_patient = patient_mas.GetEmployeeDetails(dataitems_patient, stat.ToString());
            //    foreach (DataGridViewColumn col in dataitems_patient.Columns)
            //    {
            //        col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
            //    }
            //}
            //else
            //{
            //    dataitems_patient = patient_mas.GetEmployeeDetails(dataitems_patient, stat.ToString());
            //    foreach (DataGridViewColumn col in dataitems_patient.Columns)
            //    {
            //        col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
            //    }
            //}
        }
        bool stat;

        private void cmd_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            statcmd();
        }
        void statcmd()
        {

            if (cmd_status.SelectedIndex == 0)
            {
                stat = true;
            }
            else
            {
                stat = false;
            }
        }

        private void dataitems_patient_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetGrid(dataitems_patient);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(tb_search.Text.Length > 0)
            {
                if(cmd_type.Text == "All")
                {
                    patient_mas.GetPatient1(dataitems_patient, tb_search.Text.ToLower(), stat.ToString());
                }
                else
                {
                    patient_mas.GetPatient(dataitems_patient, tb_search.Text.ToLower(), cmd_type.Text, stat.ToString());
                }
                
            }
            else
            {
                if(cmd_type.Text == "All")
                {
                    patient_mas.GetPatient(dataitems_patient, stat.ToString());
                }
                else
                {
                    patient_mas.GetPatient(dataitems_patient, stat.ToString(), cmd_type.Text);
                }
                
            }
        }

        private void cmd_status_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void cmd_status_Leave(object sender, EventArgs e)
        {
           
        }

        private void cmd_status_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            statcmd();
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
            
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataitems_patient.SelectedRows.Count == 1)
            {
                new Patient(dataitems_patient.SelectedRows[0].Cells["id"].Value.ToString()).ShowDialog();
            }
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataitems_patient.SelectedRows.Count >0)
            {
                patient_mas.update_stat(true, dataitems_patient.SelectedRows[0].Cells["id"].Value.ToString());
            }
        }

        private void inactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataitems_patient.SelectedRows.Count > 0)
            {
                patient_mas.update_stat(false, dataitems_patient.SelectedRows[0].Cells["id"].Value.ToString());
            }
        }

        private void dataitems_patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
