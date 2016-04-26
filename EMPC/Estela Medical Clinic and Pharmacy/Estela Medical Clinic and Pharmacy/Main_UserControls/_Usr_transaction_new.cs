using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estela_Medical_Clinic_and_Pharmacy
{
    public partial class _Usr_transaction_new : UserControl
    {
        _Usr_Admission admission;
        _Usr_Billing billing;
        _Usr_Search_Patient Srchpatient;
        _Usr_diagnostics diag;

        public _Usr_transaction_new()
        {
            InitializeComponent();

            admission = new _Usr_Admission();
            billing = new _Usr_Billing();
            Srchpatient = new _Usr_Search_Patient();
            diag = new _Usr_diagnostics();

            admission.Dock = DockStyle.Fill;
            billing.Dock = DockStyle.Fill;
            Srchpatient.Dock = DockStyle.Fill;
            diag.Dock = DockStyle.Fill;


            controladd();
            addcontrol("admission");
        }

        private void addcontrol(string section)
        {
            pnlbody.Controls[section].BringToFront();
        }

        public void controladd()
        {
            pnlbody.Controls.Add(admission);
            pnlbody.Controls.Add(billing);
            pnlbody.Controls.Add(Srchpatient);
            pnlbody.Controls.Add(diag);



            admission.Name = "admission";
            billing.Name = "billing";
            Srchpatient.Name = "search_patient";
            diag.Name = "diag";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            addcontrol("admission");
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addcontrol("billing");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addcontrol("search_patient");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addcontrol("diag");
        }
    }
}
