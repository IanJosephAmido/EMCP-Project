using System;
using System.Windows.Forms;
using bggPgSql;

namespace Estela_Medical_Clinic_and_Pharmacy
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //private static void Main()
        //{
        //    string path = Application.StartupPath;
        //    bggQueryPgSql conn = new bggQueryPgSql();
        //    conn.StartConnectionIni("" + path + "/connection.ini");

        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new frm_log_in());
        //}

        static void Main(string[] args)
        {
            bggQueryPgSql conn = new bggQueryPgSql();
            conn.StartConnectionIni("" + Application.StartupPath + "\\connection.ini");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_log_in());
        }
    }
}
