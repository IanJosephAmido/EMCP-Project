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
    public partial class Type : Form
    {
        Query_Item_Type itemtypeQ = new Query_Item_Type();
        Random rand = new Random();
        bool status;
        public Type()
        {
            InitializeComponent();
            cmb_status.SelectedIndex = 0;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            itemtypeQ.Type_id = itemtypeQ.GenerateIdNew(rand);
            itemtypeQ.Status = status.ToString();
            itemtypeQ.Type_name = tb_name.Text;
            itemtypeQ.Type_desc = tb_disc.Text;
            if(itemtypeQ.insert())
            {
                this.Close();
            }
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_status.Text == "Active")
            {
                status = true;
            }
            else
            {
                status = false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
