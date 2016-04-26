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
    public class Item_Type
    {
        private string type_id;
        public string Type_id
        {
            get { return type_id; }
            set { type_id = value; }
        }
        private string type_name;
        public string Type_name
        {
            get { return type_name; }
            set { type_name = value; }
        }
        private string type_desc;
        public string Type_desc
        {
            get { return type_desc; }
            set { type_desc = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
    public class Query_Item_Type : Item_Type
    {
        bggQueryPgSql MyQuery = new bggQueryPgSql();
        repeatedFunction repfunc = new repeatedFunction();
        string myString;
        public string GenerateIdNew(Random rnd)
        {
            myString = "Select count(*) from transaction.item_type where type_id=";
            return repfunc.Generate_IdRandom(myString, "estelamedicalclinicandpharmacysupplier1234567890", rnd);
        }
        public bool insert()
        {
            myString = "insert into transaction.item_type(type_id,type_name,type_desc,status) values ('" + Type_id + "','" + Type_name + "','" + Type_desc + "','" + Status + "');";
            return MyQuery.InsertUpdateDelete(myString);
        }
        public DataGridView getdata(DataGridView mydg, bool status)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY type_name desc) || '.'::text AS sn, initcap(type_name) as name,initcap(type_desc) as discription,nullif(case when status = 'true' then 'Active' else 'Inactive' end, 'none') as status from  transaction.item_type where status = '" + status + "' order by sn asc";
            return MyQuery.ViaDataGridView(myString, mydg);
        }
        public DataGridView getdata(DataGridView mydg, bool status,string search)
        {
            myString = "select DISTINCT row_number() OVER(ORDER BY type_name desc) || '.'::text AS sn, initcap(type_name) as name, initcap(type_desc) as discription, nullif(case when status = 'true' then 'Active' else 'Inactive' end, 'none') as status from transaction.item_type where status = '" + status + "' and type_name like '%" + search + "%' order by sn asc";
            return MyQuery.ViaDataGridView(myString, mydg);
        }
        public ComboBox fillcmb(ComboBox mycmb)
        {
            myString = "select initcap(type_name) from transaction.item_type where status = 't'";
            return MyQuery.ViaComboBox(myString, mycmb);
        }
        public string getid(string typename)
        {
            myString = "select type_id from transaction.item_type where type_name = '" + typename + "' and status = 't'";
            return MyQuery.ViaSingleData(myString);
        }
          

    }
}
