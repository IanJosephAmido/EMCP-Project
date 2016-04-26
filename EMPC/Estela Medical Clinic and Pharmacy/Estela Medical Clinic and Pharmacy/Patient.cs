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
using Lib_emcp;

namespace Estela_Medical_Clinic_and_Pharmacy
{
    public partial class Patient : Form
    {
        Query_Patient patient_mas = new Query_Patient();
        Random rand = new Random();
        bool edit;
        string pat_id;
        public Patient()
        {
            InitializeComponent();
            cmd_status.SelectedIndex = 0;
            cmd_status.Enabled = false;
            edit = false;
            pat_id = patient_mas.GenerateIdNew(rand);
        }
        public Patient(string patient_id)
        {
            InitializeComponent();
            cmd_status.SelectedIndex = 0;
            cmd_status.Enabled = true;
            edit = true;
            btn_save.Text = "Update";
            pat_id = patient_id;
            getdatails(); 
        }
        void getdatails()
        {
            DataTable _emp_det = new DataTable();
            _emp_det = patient_mas.ToUpdate(_emp_det, pat_id);
            foreach (DataRow rw in _emp_det.Rows)
            {               
                cmd_type.Text = rw["patient_type"].ToString();
                tb_lname.Text = rw["patient_lname"].ToString();
                tb_fname.Text = rw["patient_fname"].ToString();
                tb_mname.Text = rw["patient_mname"].ToString();
                dtp_bdate.Value = Convert.ToDateTime(rw["patient_bdate"].ToString());
                cmd_mstatus.Text = rw["patient_mstatus"].ToString();
                cmd_gender.Text = rw["patient_gender"].ToString();
                tb_address1.Text = rw["patient_address1"].ToString();
                tb_address2.Text = rw["patient_address2"].ToString();
                tb_contactnum.Text = rw["patient_contactnum"].ToString();
                tb_telnum.Text = rw["patient_telnum"].ToString();
                tb_phicnum.Text = rw["patient_phicnum"].ToString();
                tb_MC.Text = rw["patient_mc_insurance"].ToString();
                cmd_status.Text = rw["patient_status"].ToString();                                 
            }
            _emp_det.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            patient_mas.Patient_id = pat_id;
            patient_mas.Patient_status = status.ToString();
            patient_mas.Patient_type = cmd_type.Text;
            patient_mas.Patient_lname = tb_lname.Text;
            patient_mas.Patient_fname = tb_fname.Text;
            patient_mas.Patient_mname = tb_mname.Text;
            patient_mas.Patient_bdate = dtp_bdate.Value.ToShortDateString();
            patient_mas.Patient_mstatus = cmd_mstatus.Text;
            patient_mas.Patient_gender = cmd_gender.Text;
            patient_mas.Patient_address1 = tb_address1.Text;
            patient_mas.Patient_address2 = tb_address2.Text;
            patient_mas.Patient_contactnum = tb_contactnum.Text;
            patient_mas.Patient_telnum = tb_telnum.Text;
            patient_mas.Patient_phicnum = tb_phicnum.Text;
            patient_mas.Patient_mc_insurance = tb_MC.Text;
            if (edit == false)
            {              
                if (patient_mas.Insert())
                {
                    lbl_status.Text = "Successfuly Saved!";                    
                    tb_lname.Text = "";
                    tb_fname.Text = "";
                    tb_mname.Text = "";
                    dtp_bdate.Text = "";             
                    tb_address1.Text = "";
                    tb_address2.Text = "";
                    tb_contactnum.Text = "";
                    tb_telnum.Text = "";
                    tb_phicnum.Text = "";
                    tb_MC.Text = "";
                    tb_lname.SelectAll();    
                }
            }
            else
            {
               if(patient_mas.update())
                {
                    lbl_status.Text = "Successfuly Updated!";
                    tb_lname.Enabled = false;
                    tb_fname.Enabled = false;
                    tb_mname.Enabled = false;
                    dtp_bdate.Enabled = false;
                    tb_address1.Enabled = false;
                    tb_address2.Enabled = false;
                    tb_contactnum.Enabled = false;
                    tb_telnum.Enabled = false;
                    tb_phicnum.Enabled = false;
                    tb_MC.Enabled = false;
                    cmd_gender.Enabled = false;
                    cmd_mstatus.Enabled = false;
                    cmd_status.Enabled = false;
                    cmd_type.Enabled = false;
                    
                }                
            }
                        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }
        bool status;
        private void cmd_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmd_status.Text.ToLower() == "active")
            {
                status = true;
            }
            else
            {
                status = false;
            }

        }

        private void tb_lname_Leave(object sender, EventArgs e)
        {
            Utilities.Initcap(sender, e);
            Utilities.OnTbLeave(sender, e);
        }
       
        private void tb_fname_Leave(object sender, EventArgs e)
        {
            Utilities.Initcap(sender, e);
        }

        private void tb_mname_Leave(object sender, EventArgs e)
        {
            Utilities.Initcap(sender, e);
        }

        private void tb_mname_TextChanged(object sender, EventArgs e)
        {
            if(tb_mname.Text.Length > 0)
            {

            }
        }

        private void tb_lname_Enter(object sender, EventArgs e)
        {
            lbl_status.Text = "";
        }

        void leave(object sender, EventArgs e)
        {
            Utilities.Initcap(sender, e);
            Utilities.OnTbLeave(sender, e);
        }
        void enter(object sender, EventArgs e)
        {
            Utilities.Initcap(sender, e);
            Utilities.OntbEnter(sender, e);
        }
    }
}
