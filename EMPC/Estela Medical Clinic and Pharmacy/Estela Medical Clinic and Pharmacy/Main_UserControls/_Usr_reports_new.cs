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
    public partial class _Usr_reports_new : UserControl
    {
        _Usr_billing_reports billingreport;
        _Usr_Philhealth phlreport;
        public _Usr_reports_new()
        {
            InitializeComponent();

            billingreport = new _Usr_billing_reports();
            phlreport = new _Usr_Philhealth();

            billingreport.Dock = DockStyle.Fill;
            phlreport.Dock = DockStyle.Fill;

            controladd();
            addcontrol("billing_rep");
        }
        private void addcontrol(string section)
        {
            pnlbody.Controls[section].BringToFront();
        }

        void controladd()
        {
            pnlbody.Controls.Add(billingreport);
            pnlbody.Controls.Add(phlreport);

            billingreport.Name = "billing_rep";
            phlreport.Name = "phl_rep";
        }
    }
}
