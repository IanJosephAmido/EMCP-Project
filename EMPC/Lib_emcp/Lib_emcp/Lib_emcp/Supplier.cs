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
    public class Supplier
    {
        private string supplier_id;
        public string Supplier_id
        {
            get { return supplier_id; }
            set { supplier_id = value; }
        }
        private string supplier_name;
        public string Supplier_name
        {
            get { return supplier_name; }
            set { supplier_name = value; }
        }
        private string supplier_code;
        public string Supplier_code
        {
            get { return supplier_code; }
            set { supplier_code = value; }
        }
        private string supplier_contct_person;
        public string Supplier_contct_person
        {
            get { return supplier_contct_person; }
            set { supplier_contct_person = value; }
        }
        private string supplier_contctnum;
        public string Supplier_contctnum
        {
            get { return supplier_contctnum; }
            set { supplier_contctnum = value; }
        }
        private string supplier_tinnum;
        public string Supplier_tinnum
        {
            get { return supplier_tinnum; }
            set { supplier_tinnum = value; }
        }
        private string supplier_address;
        public string Supplier_address
        {
            get { return supplier_address; }
            set { supplier_address = value; }
        }
        private string supplier_status;
        public string Supplier_status
        {
            get { return supplier_status; }
            set { supplier_status = value; }
        }
    }
    public class Query_Supplier : Supplier
    {
        bggQueryPgSql MyQuery = new bggQueryPgSql();
        repeatedFunction repfunc = new repeatedFunction();
        string myString;
        public string GenerateIdNew(Random rnd)
        {
            myString = "Select count(*) from transaction.supplier_mas where supplier_id=";
            return repfunc.Generate_IdRandom(myString, "estelamedicalclinicandpharmacysupplier1234567890", rnd);
        }
        public bool Insert()
        {
            myString = "insert into transaction.supplier_mas(supplier_id,supplier_name,supplier_code,supplier_contct_person,supplier_contctnum,supplier_tinnum,supplier_address,supplier_status) " +
                "values('" + Supplier_id + "','" + Supplier_name + "','" + Supplier_code + "','" + Supplier_contct_person + "','" + Supplier_contctnum + "','" + Supplier_tinnum + "','" + Supplier_address + "', '"+ Supplier_status + "')";
            return MyQuery.InsertUpdateDelete(myString);
        }
        public bool Update()
        {
            myString = "update transaction.supplier_mas set supplier_name = '" + Supplier_name + "',supplier_code = '" + Supplier_code + "', supplier_contct_person = '" + Supplier_contctnum + "', supplier_tinnum = '" + Supplier_tinnum + "',supplier_address = '" + Supplier_address + "',supplier_status = '"+ Supplier_status + "' where  supplier_id = '" + Supplier_id + "'";
            return MyQuery.InsertUpdateDelete(myString);           
        }
        public bool updatestat(bool stat,string id)
        {
            myString = "update transaction.supplier_mas set supplier_status = '" + stat + "' where supplier_id = '" + id + "'";
            return MyQuery.InsertUpdateDelete(myString);
        }
        public DataGridView GetSuppData(DataGridView mydg, bool stat)
        {
            myString = "select upper(supplier_code) as code,supplier_name as name,supplier_address as address,supplier_contct_person as contact_person,supplier_contctnum as contact_num, nullif(case when supplier_status = 'true' then 'Active' else 'Inactive' end, 'none') as status, supplier_id as id from transaction.supplier_mas where supplier_status = '" + stat + "'";
            return MyQuery.ViaDataGridView(myString, mydg);
        }
        public DataGridView GetSuppData(DataGridView mydg, bool stat, string search)
        {
            myString = "select * from (select upper(supplier_code) as code,supplier_name as name,supplier_address as address,supplier_contct_person as contact_person,supplier_contctnum as contact_num, nullif(case when supplier_status = 'true' then 'Active' else 'Inactive' end, 'none') as status,supplier_id as id from transaction.supplier_mas where supplier_status = '" + stat + "') as a where lower(a.name) like '%" + search + "%' order by a.name asc";
            return MyQuery.ViaDataGridView(myString, mydg);
        }
         public DataTable GetEditData(DataTable mydt,string id)
        {
            myString = "select * from transaction.supplier_mas where supplier_id = '" + id + "'";
            return MyQuery.ViaDataTable(myString, mydt);
        }
        public ComboBox getallsupp(ComboBox mycmb)
        {
            myString = "select supplier_name from transaction.supplier_mas where supplier_status = 't'";
            return MyQuery.ViaComboBox(myString, mycmb);
        }
    }



}
