using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bggPgSql;
using Lib_emcp;
using System.Windows.Forms;

namespace Estela_Medical_Clinic_and_Pharmacy
{
    public partial class Employee : Form
    {
        Query_Employee empmas = new Query_Employee();
        
        Random rand = new Random();
        public bool edit;
        public string emp_id;
        public string status;
        public string stat;

        public Employee()
        {
            InitializeComponent();
            cmd_status.SelectedIndex = 0;          
            edit = false;
        }
        public Employee(string _employee_id)
        {
            InitializeComponent();
            emp_id = _employee_id;        
            edit = true;
            getdatails();
            btn_save.Text = "Update";
        }

        void getdatails()
        {
            DataTable _emp_det = new DataTable();
            _emp_det = empmas.GetDetails(_emp_det, emp_id);
            foreach (DataRow rw in _emp_det.Rows)
            {
                tblastname.Text = rw["employee_lname"].ToString();
                tbminit.Text = rw["employee_mname"].ToString();
                tbfirstname.Text = rw["employee_fname"].ToString();
                tbnick.Text = rw["employee_nname"].ToString();
                rtbcityaddressnew.Text = rw["employee_address"].ToString();
                dtpbdatenew.Text = rw["employee_bdate"].ToString();
                cmbmaritalstatus.Text = rw["employee_mstatus"].ToString();
                cmbgendernew.Text = rw["employee_gender"].ToString();
                tbmobilenumnew.Text = rw["employee_phone"].ToString();
                tbemailaddnew.Text = rw["employee_emailaddress"].ToString();     
                status_tranlator(Convert.ToBoolean(rw["employee_status"].ToString()));
                tbsssnumnew.Text = rw["employee_sss"].ToString();
                tbtinnumnew.Text = rw["employee_tin"].ToString();
                tbphilhealthnumnew.Text = rw["employee_phic"].ToString();
                tbpagibignumnew.Text = rw["employee_ibig_gsis"].ToString();
                tbdriverlicensenew.Text = rw["employee_dl"].ToString();
                lbl_show_createdby.Text = rw["employee_createdby"].ToString();
                lbl_show_createddate.Text = rw["employee_createddate"].ToString();
                lbl_show_editedby.Text = rw["employee_editedby"].ToString();
                lbl_show_editeddate.Text = rw["employee_editeddate"].ToString();
                cmd_type.Text = rw["employee_type"].ToString().ToString();               
            }
            _emp_det.Clear();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Save_Emp()
        {
            empmas.Employee_id = empmas.GenerateIdNew(rand);
            empmas.Employee_lname = tblastname.Text.ToLower();
            empmas.Employee_mname = tbminit.Text.ToLower();
            empmas.Employee_fname = tbfirstname.Text.ToLower();
            empmas.Employee_nname = tbnick.Text.ToLower();
            empmas.Employee_address = rtbcityaddressnew.Text.ToLower();
            empmas.Employee_bdate = dtpbdatenew.Value.ToString().ToLower();
            empmas.Employee_mstatus = cmbmaritalstatus.Text.ToLower();
            empmas.Employee_gender = cmbgendernew.Text.ToLower();
            empmas.Employee_phone = tbmobilenumnew.Text.ToLower();
            empmas.Employee_emailaddress = tbemailaddnew.Text.ToLower();
            empmas.Employee_status = stat.ToString();
            empmas.Employee_piclocation = "";
            empmas.Employee_sss = tbsssnumnew.Text.ToLower();
            empmas.Employee_tin = tbtinnumnew.Text.ToLower();
            empmas.Employee_phic = tbphilhealthnumnew.Text.ToLower();
            empmas.Employee_ibig_gsis = tbpagibignumnew.Text.ToLower();
            empmas.Employee_dl = tbdriverlicensenew.Text.ToLower();
            empmas.Employee_type = cmd_type.Text.ToLower();
            empmas.insert();

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {               
                DialogResult ans = MessageBox.Show("Are you sure you want to save Employee Details and close this form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ans == DialogResult.Yes)
                {
                    Save_Emp();
                    //tabControl1.Enabled = false;
                    btn_close.Focus();
                } 
                
            }     
        }
        
        private void cmd_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmd_status.Text.ToLower() == "active") { stat = "True"; } else { stat = "False"; }
        }
        void status_tranlator(bool stat)
        {
            if (stat == true) { cmd_status.SelectedIndex = 0; } else { cmd_status.SelectedIndex = 1; }
        }

        private void Employee_Shown(object sender, EventArgs e)
        {
            tbfirstname.Focus();
        }
    }
}
