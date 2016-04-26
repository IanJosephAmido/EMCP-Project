using System;
using vallib3._;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_emcp;
using System.Globalization;

namespace Estela_Medical_Clinic_and_Pharmacy
{
    public partial class Items : Form
    {
        Query_Items itemmas = new Query_Items();
        Query_Supplier suppQ = new Query_Supplier();
        Query_Item_Type itemtypeQ = new Query_Item_Type();
        Query_Generic geniricQ = new Query_Generic();
        Query_Category categoryQ = new Query_Category();
        CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
        //TextInfo textInfo = cultureInfo.TextInfo;
        public Items()
        {
            InitializeComponent();
            lblencodedname.Text = "Ian Joseph Amido";
            lblencodedtime.Text = DateTime.Now.ToLongTimeString();
            lbleditname.Text = "Gwyneth Lavilla";
            lbledittime.Text = DateTime.UtcNow.ToLongTimeString();


            cmb_supp = suppQ.getallsupp(cmb_supp);
            cmb_type = itemtypeQ.fillcmb(cmb_type);
            cmb_category = categoryQ.fillcmb(cmb_category);
            tb_generic = geniricQ.GetGenericTextBoxAuto(tb_generic);
            cmb_status.SelectedIndex = 0;
            cmb_status.Enabled = false;
        }      

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_unit_Leave(object sender, EventArgs e)
        {
            Utilities.OnTbLeave(sender, e);
            tb_unit.Text = double.Parse(tb_unit.Text).ToString("N2");
        }

        void leave(object sender, EventArgs e)
        {
            Utilities.convertdecimal(sender);
            Utilities.OnTbLeave(sender, e);
        }
        void enter(object sender, EventArgs e)
        {
            Utilities.OntbEnter(sender, e);
            Utilities.beginInvokeHere(sender);

        }

        private void tb_unit_Leave_1(object sender, EventArgs e)
        {
            Utilities.OnTbLeave(sender, e);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tb_unit_Leave_2(object sender, EventArgs e)
        {
            Utilities.OnTbLeave(sender, e);
            tb_unit.Text = cultureInfo.TextInfo.ToUpper(tb_unit.Text.ToString());
        }

        private void tb_pckunit_Leave(object sender, EventArgs e)
        {
            Utilities.OnTbLeave(sender, e);
            tb_pckunit.Text = cultureInfo.TextInfo.ToUpper(tb_pckunit.Text.ToString());
        }

        private void tb_cseunit_Leave(object sender, EventArgs e)
        {
            Utilities.OnTbLeave(sender, e);
            tb_cseunit.Text = cultureInfo.TextInfo.ToUpper(tb_cseunit.Text.ToString());
        }

      

        private void tb_description_Leave(object sender, EventArgs e)
        {
            Utilities.Initcap(sender, e);
            Utilities.OnTbLeave(sender, e);
        }

        private void tb_generic_Leave(object sender, EventArgs e)
        {
            Utilities.Initcap(sender, e);
            Utilities.OnTbLeave(sender, e);
        }

        private void tb_description_Enter(object sender, EventArgs e)
        {
            Utilities.OntbEnter(sender, e);
            Utilities.beginInvokeHere(sender);
        }

        private void tb_itembox_Enter(object sender, EventArgs e)
        {
            Utilities.OntbEnter(sender, e);
            Utilities.beginInvokeHere(sender);
        }

        private void tb_generic_Enter(object sender, EventArgs e)
        {
            Utilities.OntbEnter(sender, e);
            Utilities.beginInvokeHere(sender);
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
         
        }

        private void lnk_addcat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Category().ShowDialog();
        }
    }
}
