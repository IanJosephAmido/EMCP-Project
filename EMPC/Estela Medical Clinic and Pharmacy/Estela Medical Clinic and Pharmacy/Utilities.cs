using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Management;
using System.IO;
using System.Globalization;
using DevComponents.WinForms.Drawing;
using DevComponents;
using DevComponents.DotNetBar;

namespace Estela_Medical_Clinic_and_Pharmacy
{
    public class Utilities
    {       
        static Color tbFocusColor = Color.AliceBlue;
        public static Color TbFocusColor
        {
            get { return tbFocusColor; }
        }
        static Color tbDefaultColor = Color.White;
        public static Color TbDefaultColor
        {
            get { return tbDefaultColor; }
        }
        public static void beginInvokeHere(object sender)
        {
            if (sender is TextBox)
            {
                TextBox myTb = (TextBox)sender;
                if (myTb.Text.Length > 0)
                {
                    myTb.BeginInvoke(new MethodInvoker(myTb.SelectAll));
                }
            }
        }
        public static void convertdecimal(object sender)
        {
            if (sender is TextBox)
            {
                TextBox myTb = (TextBox)sender;
                if (myTb.Text.Length > 0)
                {
                    // myTb.BeginInvoke(new MethodInvoker(myTb.SelectAll));
                    myTb.Text = double.Parse(myTb.Text).ToString("N2");
                }
            }
        }

        public static void Initcap(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            if (sender is TextBox)
            {
                TextBox mytb = (TextBox)sender;
                mytb.Text = cultureInfo.TextInfo.ToTitleCase(mytb.Text.ToString());
            }
            else if (sender is MaskedTextBox)
            {
                MaskedTextBox mktb = (MaskedTextBox)sender;
                mktb.Text = cultureInfo.TextInfo.ToTitleCase(mktb.Text.ToString());
            }
            else if (sender is RichTextBox)
            {
                RichTextBox rtb = (RichTextBox)sender;
                rtb.Text = cultureInfo.TextInfo.ToTitleCase(rtb.Text.ToString());
            }
            else if (sender is DateTimePicker)
            {
                var dtp = (DateTimePicker)sender;
                dtp.Text = cultureInfo.TextInfo.ToTitleCase(dtp.Text.ToString());
            }
            else if (sender is ComboBox)
            {
                var cmb = (DateTimePicker)sender;
                cmb.Text = cultureInfo.TextInfo.ToTitleCase(cmb.Text.ToString());
            }



        }
        public static void OntbEnter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox myTb = (TextBox)sender;
                myTb.BackColor = Utilities.TbFocusColor;
            }
            else if (sender is MaskedTextBox)
            {
                MaskedTextBox mktb = (MaskedTextBox)sender;
                mktb.BackColor = Utilities.TbFocusColor;
            }
            else if (sender is RichTextBox)
            {
                RichTextBox rtb = (RichTextBox)sender;
                rtb.BackColor = Utilities.TbFocusColor;
            }
            else if (sender is DateTimePicker)
            {
                var dtp = (DateTimePicker)sender;
                dtp.BackColor = Utilities.TbFocusColor;
            }
        }
        public static void OnTbLeave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox myTb = (TextBox)sender;
                myTb.BackColor = Utilities.TbDefaultColor;
            }
            else if (sender is MaskedTextBox)
            {
                MaskedTextBox mktb = (MaskedTextBox)sender;
                mktb.BackColor = Utilities.TbDefaultColor;
            }
            else if (sender is RichTextBox)
            {
                RichTextBox rtb = (RichTextBox)sender;
                rtb.BackColor = Utilities.TbDefaultColor;
            }
            else if (sender is DateTimePicker)
            {
                var dtp = (DateTimePicker)sender;
                dtp.BackColor = Utilities.TbDefaultColor;
            }
        }
    }
}
