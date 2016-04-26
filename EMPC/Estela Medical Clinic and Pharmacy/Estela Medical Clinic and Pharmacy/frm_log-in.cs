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
    public partial class frm_log_in : Form
    {
        Query_AssignAccess login = new Query_AssignAccess();
        public static string _empid;
        public frm_log_in()
        {
            InitializeComponent();         
        }

       
        private void frm_log_in_Shown(object sender, EventArgs e)
        {
            tb_username.Focus();
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }
        private void tb_username_Enter(object sender, EventArgs e)
        {
            tb_username.SelectAll();
            //lblstatus.Text = "";
            tb_username.BackColor = Color.WhiteSmoke;
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            tb_username.BackColor = Color.White;
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            tb_password.BackColor = Color.White;
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            tb_password.SelectAll();
            tb_password.BackColor = Color.WhiteSmoke;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _fadein();
        }
        void _fadein()
        {
            this.Opacity += 0.05;
            if (this.Opacity >= .95)
            {
                this.Opacity = 1;
                timer1.Enabled = false;
            }
        }

        private void frm_log_in_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (tb_username.Text.Length > 0 && tb_password.Text.Length > 0)
            {
                if (login.StartLogin(CryptorEngine.Encrypt(tb_username.Text, true), CryptorEngine.Encrypt(tb_password.Text, true)) == true)
                {
                    _empid = login.GetIDfromLogin(CryptorEngine.Encrypt(tb_username.Text, true), CryptorEngine.Encrypt(tb_password.Text, true));
                    new emcp_main().ShowDialog();
                    this.Hide();
                    this.Close();
                }
                else
                {                  
                    lblstatus.Text = "The username or password you entered is incorrect.Try again.";
                    tb_username.Focus();
                }
            }
        }

 

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            lblstatus.Text = "";
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            lblstatus.Text = "";
        }

        private void ambiance_Label3_Click(object sender, EventArgs e)
        {
            new emcp_main().ShowDialog();
        }
    }
}
