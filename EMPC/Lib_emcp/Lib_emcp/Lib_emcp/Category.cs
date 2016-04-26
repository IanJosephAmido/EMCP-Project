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
    public class Category
    {
        private string cat_id;
        public string Cat_id
        {
            get { return cat_id; }
            set { cat_id = value; }
        }
        private string cat_name;
        public string Cat_name
        {
            get { return cat_name; }
            set { cat_name = value; }
        }
        private string cat_desc;
        public string Cat_desc
        {
            get { return cat_desc; }
            set { cat_desc = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    public class Query_Category : Category
    {
        bggQueryPgSql MyQuery = new bggQueryPgSql();
        repeatedFunction repfunc = new repeatedFunction();
        string myString;
        public string GenerateIdNew(Random rnd)
        {
            myString = "Select count(*) from transaction.category where cat_id=";
            return repfunc.Generate_IdRandom(myString, "estelamedicalclinicandpharmacysupplier1234567890", rnd);
        }
        public bool insert()
        {
            myString = "insert into transaction.category(cat_id,cat_name,cat_desc,status,type) values ('" + Cat_id + "','" + Cat_name + "','" + Cat_desc + "','" + Status + "','" + Type + "');";
            return MyQuery.InsertUpdateDelete(myString);
        }
        public DataGridView getdata(DataGridView mydg, bool status)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY cat_name desc) || '.'::text AS sn, initcap(cat_name) as name,initcap(cat_desc) as discription,nullif(case when b.status = 'true' then 'Active' else 'Inactive' end, 'none') as status,initcap(a.type_name) as item_type from  transaction.category as b,transaction.item_type as a where type = a.type_id and b.status = '" + status + "' order by sn asc";
            return MyQuery.ViaDataGridView(myString, mydg);
        }
        public DataGridView getdata(DataGridView mydg, bool status,string search)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY cat_name desc) || '.'::text AS sn, initcap(cat_name) as name,initcap(cat_desc) as discription,nullif(case when b.status = 'true' then 'Active' else 'Inactive' end, 'none') as status,initcap(a.type_name) as item_type from  transaction.category as b,transaction.item_type as a where type = a.type_id and b.status = '" + status + "' and lower(cat_name) like '%" + search + "%' order by sn asc";
            return MyQuery.ViaDataGridView(myString, mydg);
        }
        public ComboBox fillcmb(ComboBox mycmb)
        {
            myString = "select initcap(cat_name) from transaction.category where status = 't'";
            return MyQuery.ViaComboBox(myString, mycmb);
        }
    }
}
