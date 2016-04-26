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
    public partial class Category : Form
    {
        Query_Category categoryQ = new Query_Category();
        Query_Item_Type itemtypeQ = new Query_Item_Type();
        TextInfo txt = CultureInfo.CurrentCulture.TextInfo;
        Random rand = new Random();
        bool status;
        public Category()
        {
            InitializeComponent();
            cmb_status.SelectedIndex = 0;
            cmb_type = itemtypeQ.fillcmb(cmb_type);
            update_status();
        }
        void update_status()
        {
            if (cmb_status.Text == "Active")
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            categoryQ.Cat_id = categoryQ.GenerateIdNew(rand);         
            categoryQ.Cat_name = tb_name.Text;
            categoryQ.Cat_desc = tb_disc.Text;
            categoryQ.Status = status.ToString();
            categoryQ.Type = itemtypeQ.getid(cmb_type.Text.ToLower());
            if(categoryQ.insert())
            {
                this.Close();
            }
        }
    }
}
