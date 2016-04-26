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

    public partial class _Usr_employee : UserControl
    {
        Query_Employee empl = new Query_Employee();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;

        public _Usr_employee()
        {
            InitializeComponent();          
            cmd_stat.SelectedIndex = 0;
            statcmd();
           
        }
        void SetGrid(DataGridView dt)
        {
           
            dt.Columns["sn"].Width = 30;
            dt.Columns["name"].Width = 200;
            dt.Columns["address"].Width = 200;
            dt.Columns["gender"].Width = 100;
            dt.Columns["contact_num"].Width = 180;
            dt.Columns["created_by"].Width = 200;
            dt.Columns["created_date"].Width = 150;
            dt.Columns["edited_by"].Width = 200;
            dt.Columns["edited_date"].Width = 150;
            dt.Columns["status"].Width = 100;
            dt.Columns["employee_id"].Visible = false;
            


            foreach (DataGridViewColumn col in dt.Columns)
            {
                col.HeaderText = txt.ToTitleCase(col.HeaderText).Replace("_", " ");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new Employee().ShowDialog();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            new Employee().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(stat == true)
            {
                dataitems = empl.GetEmployeeDetails(dataitems, stat.ToString());
            }
            else
            {
                dataitems = empl.GetEmployeeDetails(dataitems, stat.ToString());
            }
        }
        bool stat;
        private void cmd_stat_SelectedIndexChanged(object sender, EventArgs e)
        {
            statcmd();
        }
        void statcmd()
        {

            if (cmd_stat.SelectedIndex == 0)
            {
                stat = true;
            }
            else
            {
                stat = false;
            }
        }

        private void dataitems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetGrid(dataitems);
        }

        private void dataitems_MouseDown(object sender, MouseEventArgs e)
        {
            if (dataitems.SelectedRows.Count == 1)
            {
                if (e.Button == MouseButtons.Right)
                {                
                    editToolStripMenuItem.Visible = true;
                    setStatusToolStripMenuItem.Visible = true;
                }
            }
        }

        private void dataitems_MouseClick(object sender, MouseEventArgs e)
        {
            if(dataitems.SelectedRows.Count == 1)
            {

            }
        }
        private void dataitems_DoubleClick(object sender, EventArgs e)
        {
            editToolStripMenuItem.PerformClick();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataitems.SelectedRows.Count == 1)
            {
                new Employee(dataitems.SelectedRows[0].Cells["employee_id"].Value.ToString()).ShowDialog();
            }
        }

      

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
