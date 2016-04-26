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
    public partial class AccessLevel : Form
    {
        Query_Employee empmas = new Query_Employee();
        Query_AccessLevel accessmas = new Query_AccessLevel();
        Query_AssignAccess assignaccess = new Query_AssignAccess();

        DataTable namewithnick;
        DataTable names;
        public bool edit;
        static string EmpId;
        static string AccessId;
        public AccessLevel()
        {
            InitializeComponent();

            namewithnick = new DataTable();
            names = new DataTable();
            namewithnick = empmas.GetEmployeeViaTbAuto(namewithnick);
            names.Columns.Add("id", typeof(string));
            names.Columns.Add("name", typeof(string));      
            edit = false;


            cmdaccesslvl = accessmas.SelectAllName(cmdaccesslvl);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

      

        void OnTextChangedNames(TextBox myTb)
        {
            if (edit == false)
            {
                names.Rows.Clear();

                if (myTb.Text.Length == 0)
                {                   
                    dataitemsname.Visible = false;
                }
                foreach (DataRow rw in namewithnick.Rows)
                {
                    if (rw[1].ToString().ToLower().Contains(myTb.Text.ToLower()))
                    {
                        names.Rows.Add(rw[0].ToString(), rw[1].ToString());
                    }
                }
                dataitemsname.DataSource = names;
                dataitemsname.ColumnHeadersVisible = false;

                if (edit == true)
                {
                    dataitemsname.Visible = false;
                }
                else
                {
                    dataitemsname.Visible = true;
                }

                dataitemsname.Columns[0].Width = 120;
                if (dataitemsname.Rows.Count > 0)
                {
                    dataitemsname.Rows[0].Selected = true;
                }
            }         
        }

        private void dataitemsname_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataitemsname.Columns["id"].Visible = false;
            dataitemsname.Columns["name"].Width = 268;
            foreach (DataGridViewRow row in dataitemsname.Rows)
            {
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dataitemsname_KeyDown(object sender, KeyEventArgs e)
        {
            if(dataitemsname.SelectedRows.Count == 1)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    tbempname.Text = dataitemsname.SelectedCells[1].Value.ToString();
                    EmpId = dataitemsname.SelectedCells[0].Value.ToString();
                    dataitemsname.Visible = false;

                    if (assignaccess.CheckIfAccessnameExists(EmpId) == true)
                    {
                        label7.Text = "This Employee is already have username and password.";
                        tbempname.Focus();
                        tbempname.SelectAll();
                    }
                    else
                    {
                        label7.Text = "";
                    }
                }                                              
            }
        }

        private void tb_employeename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (dataitemsname.Rows.Count > 0)
                {
                    dataitemsname.Focus();
                    dataitemsname.Rows[0].Selected = true;
                }
                if(e.KeyCode == Keys.Tab)
                {
                    //if (assignaccess.CheckIfAccessnameExists(EmpId) == true)
                    //{
                    //    label7.Text = "This Employee is already have username and password.";
                    //    tbempname.Focus();
                    //    tbempname.SelectAll();
                    //}
                }
            }
        } 
        private void tbcpassword_Leave(object sender, EventArgs e)
        {
            if (tbpassword.Text != tbcpassword.Text)
            {
                lblstatus.Text = "The password you entered don't match.Try again.";
                tbpassword.Focus();
                tbpassword.SelectAll();
            }
            else
            {
                lblstatus.Text = "";
            }
        }
        private void cmdaccesslvl_DropDown(object sender, EventArgs e)
        {
            cmdaccesslvl.Items.Clear();
            cmdaccesslvl = accessmas.SelectAllName(cmdaccesslvl);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            assignaccess.Employee_id = EmpId;
            assignaccess.Authorizedby_id = auth_id;
            assignaccess.Username = CryptorEngine.Encrypt(tbusername.Text, true);
            assignaccess.Password = CryptorEngine.Encrypt(tbpassword.Text, true);
            assignaccess.Access_level = accessmas.GetAccessID(cmdaccesslvl.Text.ToLower());
            if (assignaccess.insert())
            {
                lblstatus.Text = "Employee's login information.Successfully Saved!";
                tbempname.Text = "";
                tbusername_aut.Text = "";
                tbpassword_aut.Text = "";
                tbusername.Text = "";
                tbpassword.Text = "";
                tbcpassword.Text = "";
                cmdaccesslvl.Text = "";
                tbempname.Focus();
            }
        }
        private void cmdaccesslvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmdaccesslvl.SelectedIndex==1)
            {
                AccessId = accessmas.GetAccessID(cmdaccesslvl.Text.ToLower());
            }
        }
        string auth_id;
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if(assignaccess.StartLogin(CryptorEngine.Encrypt(tbusername_aut.Text, true), CryptorEngine.Encrypt(tbpassword_aut.Text, true)) == true)
            {
                auth_id = assignaccess.GetIDfromLogin(CryptorEngine.Encrypt(tbusername_aut.Text, true), CryptorEngine.Encrypt(tbpassword_aut.Text, true));
                groupBox2.Enabled = true;
                tbusername.Focus();
                groupBox1.Enabled = false;
            }
            else
            {
                tbusername_aut.Focus();
                tbusername_aut.SelectAll();
            }
            

        }

        private void tbpassword_aut_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnconfirm.PerformClick();
            }
        }

        private void tbempname_TextChanged(object sender, EventArgs e)
        {
            OnTextChangedNames(tbempname);
           
            if (tbempname.Text.Length == 0)
            {
                dataitemsname.Visible = false;
            }
        }

        private void tbempname_Leave(object sender, EventArgs e)
        {

            //if (assignaccess.CheckIfAccessnameExists(EmpId) == true)
            //{
            //    label7.Text = "This Employee is already have username and password.";
            //    tbempname.Focus();
            //    tbempname.SelectAll();
            //}
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AddAccesLevel().ShowDialog();
        }
    }
}
