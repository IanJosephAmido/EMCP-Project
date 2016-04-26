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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            cmd_patient.SelectedIndex = 0;
            
        }
    }
}
