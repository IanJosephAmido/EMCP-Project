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
    public partial class AddChargeCategory : Form
    {
        Query_HospitalChargesCategory caterogy = new Query_HospitalChargesCategory();
        Random rand = new Random();
        bool edit;
        public AddChargeCategory()
        {
            InitializeComponent();
            cmd_status.SelectedIndex = 0;
            
            edit = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
           
                caterogy.Category_id = caterogy.GenerateIdNew(rand);
                caterogy.Status = stat.ToString();
                caterogy.Name = tb_name.Text;
                caterogy.Discription = tb_discription.Text;

                if (caterogy.Insert())
                {
                    edit = true;
                    lbl_status.Text = "Successfuly Saved !";
                    tb_name.Text = "";
                    tb_discription.Text = "";
                    tb_name.SelectAll();
                    //this.Close();
                }
            
            
        }
        bool stat;
        private void cmd_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmd_status.Text.ToLower() == "active")
            {
                stat = true;
            }
            else
            {
                stat = false;
            }
        }

        private void tb_name_Enter(object sender, EventArgs e)
        {
            lbl_status.Text = "";
        }
    }
}
