using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib_emcp;
using System.Windows.Forms;

namespace Estela_Medical_Clinic_and_Pharmacy
{
    public partial class AddAccesLevel : Form
    {
        Query_AccessLevel accessmas = new Query_AccessLevel();
        static bool _stat;
        public AddAccesLevel()
        {
            InitializeComponent();
            cmd_status.SelectedIndex = 0;
            
        }       

        private void AddAccesLevel_Shown(object sender, EventArgs e)
        {
            tbaccessname.Focus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        string accesslvl_id;
        Random rand = new Random();
        private void btnsave_Click(object sender, EventArgs e)
        {

            if(tbaccessname.Text.Length>0&&cmd_status.Text.Length>0)
            {
                accessmas.Access_status = _stat;
                accessmas.Access_name = tbaccessname.Text.ToLower();
                accessmas.Access_remarks = tbremarks.Text.ToLower();
                accesslvl_id = accessmas.GenerateIdNew(rand, tbaccessname);
                accessmas.Access_id = accesslvl_id.ToString();
                if (!accessmas.CheckIfAccessnameExists(accessmas.Access_name) == true)
                {
                    if (accessmas.insert())
                    {
                        tbaccessname.Text = "";
                        tbremarks.Text = "";
                        cmd_status.SelectedIndex = 0;
                        lblstatus.Text = "SAVED!";


                    }
                }
                else
                {
                    lblstatus.Text = "Already exists!";
                }
               

            }
        }

        private void cmd_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmd_status.SelectedIndex == 0) { _stat = true; } else { _stat = false; }; 
        }

        private void tbaccessname_Click(object sender, EventArgs e)
        {
           
        }

        private void tbaccessname_Enter(object sender, EventArgs e)
        {
            lblstatus.Text = "";
            tbaccessname.SelectAll();
        }

        private void AddAccesLevel_Load(object sender, EventArgs e)
        {

        }
    }
}
