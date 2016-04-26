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
    public class Generic
    {
        private string generic_id;
        public string Generic_id
        {
            get { return generic_id; }
            set { generic_id = value; }
        }
        private string generic_name;
        public string Generic_name
        {
            get { return generic_name; }
            set { generic_name = value; }
        }
        private string generic_desc;
        public string Generic_desc
        {
            get { return generic_desc; }
            set { generic_desc = value; }
        }
        private string generic_stat;
        public string Generic_stat
        {
            get { return generic_stat; }
            set { generic_stat = value; }
        }

    }
    public class Query_Generic : Generic
    {
        bggQueryPgSql MyQuery = new bggQueryPgSql();
        repeatedFunction repfunc = new repeatedFunction();
        string myString;
        public string GenerateIdNew(Random rnd)
        {
            myString = "Select count(*) from transaction.generic where generic_id=";
            return repfunc.Generate_IdRandom(myString, "estelamedicalclinicandpharmacysupplier1234567890", rnd);
        }
        public bool insert()
        {
            myString = "insert into transaction.generic(generic_id,generic_name,generic_desc,generic_stat) values ('" + Generic_id + "','" + Generic_name + "','" + Generic_desc + "','" + Generic_stat + "');";
            return MyQuery.InsertUpdateDelete(myString);
        }
        public DataGridView getdata(DataGridView mydg, bool status)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY generic_name desc) || '.'::text AS sn, initcap(generic_name) as name,initcap(generic_desc) as discription,nullif(case when generic_stat = 'true' then 'Active' else 'Inactive' end, 'none') as status from  transaction.generic where generic_stat = '" + status + "' order by sn asc";
            return MyQuery.ViaDataGridView(myString, mydg);
        }
        public DataGridView getdata(DataGridView mydg, bool status, string search)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY generic_name desc) || '.'::text AS sn, initcap(generic_name) as name,initcap(generic_desc) as discription,nullif(case when generic_stat = 'true' then 'Active' else 'Inactive' end, 'none') as status from  transaction.generic where generic_stat = '" + status + "' and generic_name like '%" + search + "%' order by sn asc";
            return MyQuery.ViaDataGridView(myString, mydg);
        }
        public TextBox GetGenericTextBoxAuto(TextBox myTb)
        {
            myString = "Select generic_name from transaction.generic order by generic_name";
            return MyQuery.ViaTextbox_AutoCompleteCustomSource(myString, myTb);
        }
    }
     
}
