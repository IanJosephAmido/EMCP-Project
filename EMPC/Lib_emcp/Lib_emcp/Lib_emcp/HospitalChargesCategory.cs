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
    public class HospitalChargesCategory
    {
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string discription;
        public string Discription
        {
            get { return discription; }
            set { discription = value; }
        }
        private string category_id;
        public string Category_id
        {
            get { return category_id; }
            set { category_id = value; }
        }
    }
    public class Query_HospitalChargesCategory : HospitalChargesCategory
    {
        bggQueryPgSql MyQuery = new bggQueryPgSql();
        repeatedFunction repfunc = new repeatedFunction();
        string myString;
        //ChargesCategory
        public string GenerateIdNew(Random rnd)
        {
            myString = "Select count(*) from transaction.chargecategory_master where category_id=";
            return repfunc.Generate_IdRandom(myString, "estelamedicalclinicandpharmacy1234567890", rnd);
        }
        public bool Insert()
        {
            myString = "insert into transaction.chargecategory_master(status,name,discription,category_id) values ('"+Status+"','"+Name+"','"+Discription+"','"+Category_id+"')";
            return MyQuery.InsertUpdateDelete(myString);
        }

        public ComboBox getcategoryname(ComboBox cmd)
        {
            myString = "select initcap(name) as name,category_id as id from transaction.chargecategory_master where status = 't'";
            return MyQuery.ViaComboBox(myString, cmd);
        }      
        public string GetCategoryId(string name)
        {
            myString = "select category_id as id from transaction.chargecategory_master where status = 't' and name = '" + name + "'";
            return MyQuery.ViaSingleData(myString);
        }
        public string GetCategoryname(string id)
        {
            myString = "select name from  transaction.chargecategory_master where category_id = '" + id + "'";
            return MyQuery.ViaSingleData(myString);
        }
        public DataTable getcategoryname(DataTable mydt)
        {
            myString = "select initcap(name) as name,category_id as id from transaction.chargecategory_master where status = 't'";
            return MyQuery.ViaDataTable(myString, mydt);
        }


        //

















    }
       
}   



