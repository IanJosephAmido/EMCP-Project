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
    public partial class Generic : Form
    {
        Query_Generic genericQ = new Query_Generic();
        Random rand = new Random();
        public bool status;
        public Generic()
        {
            InitializeComponent();
            cmb_status.SelectedIndex = 0;
            getstatus();
        }
        void getstatus()
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
        private void btn_save_Click(object sender, EventArgs e)
        {
            genericQ.Generic_id = genericQ.GenerateIdNew(rand);
            genericQ.Generic_name = tb_name.Text;
            genericQ.Generic_desc = tb_disc.Text;
            genericQ.Generic_stat = status.ToString();
            if(genericQ.insert())
            {
                this.Close();
            }
        }
    }
}
