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
    public partial class _Usr_maintenance_new : UserControl
    {
        _Usr_patient patient;
        _Usr_items item;
        _Usr_hospital_charges hoscharges;
        _Usr_Supplier supplier;
        _Usr_employee employee;
        _Usr_AccessLevel accesslev;
        _Urs_Category category;
        _Urs_Generic generic;
        _Usr_type type;
      

        public _Usr_maintenance_new()
        {
            InitializeComponent();

            patient = new _Usr_patient();
            item = new _Usr_items();
            hoscharges = new _Usr_hospital_charges();
            supplier = new _Usr_Supplier();
            employee = new _Usr_employee();
            accesslev = new _Usr_AccessLevel();
            category = new _Urs_Category();
            generic = new _Urs_Generic();
            type = new _Usr_type();
               

            patient.Dock = DockStyle.Fill;
            item.Dock = DockStyle.Fill;
            hoscharges.Dock = DockStyle.Fill;
            supplier.Dock = DockStyle.Fill;
            employee.Dock = DockStyle.Fill;
            accesslev.Dock = DockStyle.Fill;
            category.Dock = DockStyle.Fill;
            generic.Dock = DockStyle.Fill;
            type.Dock = DockStyle.Fill;


            controladd();
            addcontrol("patient");
        }
        private void addcontrol(string section)
        {
            pnlbody.Controls[section].BringToFront();
        }
        public void controladd()
        {
            pnlbody.Controls.Add(patient);
            pnlbody.Controls.Add(item);
            pnlbody.Controls.Add(hoscharges);
            pnlbody.Controls.Add(supplier);
            pnlbody.Controls.Add(employee);
            pnlbody.Controls.Add(accesslev);
            pnlbody.Controls.Add(category);
            pnlbody.Controls.Add(generic);
            pnlbody.Controls.Add(type);

            patient.Name = "patient";
            item.Name = "item";
            hoscharges.Name = "hospitalcharges";
            supplier.Name = "supp";
            employee.Name = "employee";
            accesslev.Name = "accesslevel";
            category.Name = "category";
            generic.Name = "generic";
            type.Name = "type";


   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addcontrol("patient");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addcontrol("item");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addcontrol("hospitalcharges");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addcontrol("employee");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addcontrol("supp");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addcontrol("accesslevel");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addcontrol("type");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addcontrol("category");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addcontrol("generic");
        }
    }
}
