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
using vallib3._;
using System.Windows.Forms;

namespace Estela_Medical_Clinic_and_Pharmacy
{   
    public partial class HospitalCharges : Form
    {
           
        Query_HospitalChargesCategory _categories = new Query_HospitalChargesCategory();
        Query_HospitalChargesDet _chargesdet = new Query_HospitalChargesDet();
        repeatedFunction repfunc = new repeatedFunction();
        public bool edit;
        public string trxnum;
        public bool stat;
        public HospitalCharges()
        {
            InitializeComponent();
            cmd_status.SelectedIndex = 0;
            cmd_status.Enabled = false;
            edit = false;
            cmd_category = _categories.getcategoryname(cmd_category);
            tb_trxnum.Enabled = false;
            gettrxnum();
        }
        public HospitalCharges(string _trxnum,bool _status)
        {
            InitializeComponent();
            trxnum = _trxnum;
            stat = _status;     
                   
            //cmd_status.SelectedIndex = 0;
            //cmd_status.Enabled = false;
            edit = true;
            cmd_category = _categories.getcategoryname(cmd_category);
            tb_trxnum.Enabled = false;
            btn_savenew.Text = "Update and Close";
            getdata();
            SetStatus();
            //gettrxnum();
        }
        void SetStatus()
        {
            if(stat == true)
            {
                cmd_status.SelectedIndex = 0;
            }
            else
            {
                cmd_status.SelectedIndex = 1;
            }
        }
        string category_name;
        void getdata()
        {
            DataTable mydt = new DataTable();
            mydt = _chargesdet.getalldata(mydt, stat, trxnum);
            foreach (DataRow rw in mydt.Rows)
            {
                cmd_status.Text = status.ToString();
                tb_trxnum.Text = trxnum;
                dtp_date.Text = rw["date"].ToString();               
                cmd_category.Text = _categories.GetCategoryname(rw["category_id"].ToString());
                tb_chargename.Text = rw["charge_name"].ToString();
                tb_discription.Text = rw["charge_discription"].ToString();
                tb_hpcharge.Text = rw["hospital_fee"].ToString();
                tb_phicfee.Text = rw["phic_fee"].ToString();
                tb_mc.Text = rw["mc_fee"].ToString();                         
            }
            mydt.Clear();
        }     
        string serialnum;
        string lastserialnum;
        void gettrxnum()
        {
            if(edit == false)
            {
                lastserialnum = _chargesdet.GetLastSerialNum(DateTime.Now.Year.ToString());
                serialnum = repfunc.Generate_SerialNum(lastserialnum);
                tb_trxnum.Text = serialnum;
            }
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AddChargeCategory().ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_category_DropDown(object sender, EventArgs e)
        {
            
        }
        string Charge_Category_Id;
        private void cmd_category_Leave(object sender, EventArgs e)
        {
            if(cmd_category.Text.Length!=1)
            {
                Charge_Category_Id = _categories.GetCategoryId(cmd_category.Text.ToString());
            }
            
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
           
            _chargesdet.Trx_num = tb_trxnum.Text;                     
            _chargesdet.Status = status.ToString();
            _chargesdet.Date = dtp_date.Value.ToShortDateString();
            _chargesdet.Category_id = Charge_Category_Id;
            _chargesdet.Charge_discription = tb_discription.Text;
            _chargesdet.Charge_name = tb_chargename.Text;
            _chargesdet.Hospital_fee = tb_hpcharge.Text;
            _chargesdet.Phic_fee = tb_phicfee.Text;
            _chargesdet.Mc_fee = tb_mc.Text;       
            if (edit == false)
            {
                if (_chargesdet.Insert())
                {
                    lbl_status.Text = "Successfuly Saved !";
                    cmd_category.Text = "";
                    tb_chargename.Text = "";
                    tb_discription.Text = "";
                    tb_hpcharge.Text = "";
                    tb_mc.Text = "";
                    tb_phicfee.Text = "";
                    cmd_category.SelectAll();
                    gettrxnum();
                }
            }
            else
            {
               if(_chargesdet.Update())
                {
                    this.Close();
                }
            }
        }
            
        
        public bool status;
        private void cmd_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmd_status.Text == "Active") { status = true; } else { status = false; }             
        }

        private void cmd_category_Enter(object sender, EventArgs e)
        {
            lbl_status.Text = "";
        }
    }
}
