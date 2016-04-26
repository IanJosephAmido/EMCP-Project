using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estela_Medical_Clinic_and_Pharmacy
{
    public partial class emcp_main : Form
    {
        _Usr_transaction_new _transaction;
        _Usr_maintenance_new _maintenance;
        _Usr_reports_new _reports;

        public emcp_main()
        {
            InitializeComponent();

            _transaction = new _Usr_transaction_new();
            _maintenance = new _Usr_maintenance_new();
            _reports = new _Usr_reports_new();

            _transaction.Dock = DockStyle.Fill;
            _maintenance.Dock = DockStyle.Fill;
            _reports.Dock = DockStyle.Fill;

            controladd();
            addcontrol("_transactions");
            DateTime dt = new DateTime();
            label5.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToLongTimeString();
        }

        public void controladd()
        {

            pnlbody.Controls.Add(_transaction);
            pnlbody.Controls.Add(_maintenance);
            pnlbody.Controls.Add(_reports);



            _transaction.Name = "_transactions";
            _maintenance.Name = "_maintenances";
            _reports.Name = "_reports";
        }
        private void addcontrol(string section)
        {
            pnlbody.Controls[section].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addcontrol("_maintenances");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addcontrol("_transactions");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addcontrol("_reports");
        }
    }
}
