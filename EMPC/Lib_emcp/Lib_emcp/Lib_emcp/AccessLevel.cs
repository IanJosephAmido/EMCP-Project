using System;
using System.Collections.Generic;
using bggPgSql;
using vallib3._;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_emcp
{
    public class AccessLevel
    {
        private string access_id;
        public string Access_id
        {
            get { return access_id; }
            set { access_id = value; }
        }
        private string access_name;
        public string Access_name
        {
            get { return access_name; }
            set { access_name = value; }
        }
        private string access_remarks;
        public string Access_remarks
        {
            get { return access_remarks; }
            set { access_remarks = value; }
        }
        private bool access_status;
        public bool Access_status
        {
            get { return access_status; }
            set { access_status = value; }
        }
    }
    public class Query_AccessLevel : AccessLevel
    {
        bggQueryPgSql MyQuery = new bggQueryPgSql();
        repeatedFunction repfunc = new repeatedFunction();
        string MyString;

        public string GenerateIdNew(Random rnd,TextBox tbchar)
        {
            MyString = "Select count(*) from transaction.accesslevel_master where access_id=";
            return repfunc.Generate_IdRandom(MyString,tbchar.ToString(), rnd);
        }
        public bool insert()
        {
            MyString = "insert into transaction.accesslevel_master (access_name,access_remarks,access_status,access_id) values ('"+ Access_name + "','"+ Access_remarks + "','"+ Access_status + "','"+ Access_id + "')";
            return MyQuery.InsertUpdateDelete(MyString);
        }
       

        public ComboBox SelectAllName(ComboBox cmd)
        {
            MyString = "select initcap(access_name) from transaction.accesslevel_master where access_status = 't'";
            return MyQuery.ViaComboBox(MyString, cmd);
        }
        public DataTable SelectAllName(DataTable mydt)
        {
            MyString = "select initcap(access_name) as name ,access_id as id from transaction.accesslevel_master where access_status = 't'";
            return MyQuery.ViaDataTable(MyString, mydt);
        }


        public string GetAccessID(string accessname)
        {
            MyString = "select access_id from transaction.accesslevel_master where access_name = '"+ accessname + "'";
            return MyQuery.ViaSingleData(MyString);
        }
        public DataGridView GetData(DataGridView mydg,bool stat)
        {
            MyString = "select DISTINCT row_number() OVER (ORDER BY access_name desc) || '.'::text AS sn,initcap(access_name) as name , nullif(case when access_status = 'true' then 'Active' else 'Inactive' end, 'none') as status from transaction.accesslevel_master where access_status = '" + stat + "' order by sn asc";
            return MyQuery.ViaDataGridView(MyString, mydg);
        }
        public DataGridView GetData(DataGridView mydg, bool stat, string search)
        {
            MyString = "select DISTINCT row_number() OVER (ORDER BY access_name desc) || '.'::text AS sn,initcap(access_name) as name , nullif(case when access_status = 'true' then 'Active' else 'Inactive' end, 'none') as status from transaction.accesslevel_master where access_status = '" + stat + "' and lower(access_name) like '%" + search + "%' order by sn asc";
            return MyQuery.ViaDataGridView(MyString, mydg);
        }


        int count;
        public bool CheckIfAccessnameExists(string accessname)
        {
            count = 0;
            MyString = "Select count(*) from transaction.accesslevel_master where access_name = '" + accessname + "';";
            count = int.Parse(MyQuery.ViaSingleData(MyString));
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }



}
