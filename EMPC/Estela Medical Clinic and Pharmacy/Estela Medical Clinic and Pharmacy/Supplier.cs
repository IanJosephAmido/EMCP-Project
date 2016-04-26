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
    public partial class Supplier : Form
    {
        Query_Supplier supplier = new Query_Supplier();
        Random rand = new Random();
        public bool edit;
        public string supp_id;
        public bool status;
        public Supplier()
        {
            InitializeComponent();
            cmbstatus.SelectedIndex = 0;
            edit = false;
            supp_id = supplier.GenerateIdNew(rand);
            update_status();
        }
        public Supplier(string id)
        {
            InitializeComponent();
            cmbstatus.SelectedIndex = 0;
            cmbstatus.Enabled = true;
            edit = true;
            supp_id = id;
            update_status();
            getdata();
            btn_save.Text = "Update";

        }

        void getdata()
        {
            DataTable mydt = new DataTable();
            mydt = supplier.GetEditData(mydt, supp_id);
            foreach (DataRow rw in mydt.Rows)
            {
                cmbstatus.Text = rw["supplier_status"].ToString();
                tb_sname.Text = rw["supplier_name"].ToString();
                tb_scode.Text = rw["supplier_code"].ToString();
                tbcontactperson.Text = rw["supplier_contct_person"].ToString();
                tbcontactnum.Text = rw["supplier_contctnum"].ToString();
                tbTinNum.Text = rw["supplier_tinnum"].ToString();
                tbaddress.Text = rw["supplier_address"].ToString();             
            }
            mydt.Clear();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            supplier.Supplier_id = supp_id;
            supplier.Supplier_status = status.ToString();
            supplier.Supplier_name = tb_sname.Text.Replace("'","");
            supplier.Supplier_code = tb_scode.Text.Replace("'", "");
            supplier.Supplier_contctnum = tbcontactnum.Text.Replace("'", "");
            supplier.Supplier_contct_person = tbcontactperson.Text.Replace("'", "");
            supplier.Supplier_tinnum = tbTinNum.Text.Replace("'", "");
            supplier.Supplier_address = tbaddress.Text.Replace("'", "");           
            if (edit == false)
            {
              if(supplier.Insert())
                {
                    panel3.Enabled = false;
                    lblstatus.Text = "Successfuly Saved!";
                }
            }
            else
            {
                if(supplier.Update())
                {
                    panel3.Enabled = false;
                    lblstatus.Text = "Successfuly Updated!";
                }
            }
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        void update_status()
        {
            if (cmbstatus.Text.ToLower() == "active")
            {
                status = true;
            }
            else
            {
                status = false;
            }
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

        private void tb_scode_Leave(object sender, EventArgs e)
        {
            Utilities.OnTbLeave(sender, e);
        }

        private void tb_scode_Enter(object sender, EventArgs e)
        {
            Utilities.OntbEnter(sender, e);
        }
    }
}
