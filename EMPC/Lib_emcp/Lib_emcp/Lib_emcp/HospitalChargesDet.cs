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
    public class HospitalChargesDet
    {
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        private string category_id;
        public string Category_id
        {
            get { return category_id; }
            set { category_id = value; }
        }
        private string charge_discription;
        public string Charge_discription
        {
            get { return charge_discription; }
            set { charge_discription = value; }
        }
        private string charge_name;
        public string Charge_name
        {
            get { return charge_name; }
            set { charge_name = value; }
        }
        private string hospital_fee;
        public string Hospital_fee
        {
            get { return hospital_fee; }
            set { hospital_fee = value; }
        }
        private string phic_fee;
        public string Phic_fee
        {
            get { return phic_fee; }
            set { phic_fee = value; }
        }
        private string mc_fee;
        public string Mc_fee
        {
            get { return mc_fee; }
            set { mc_fee = value; }
        }
        private string trx_num;
        public string Trx_num
        {
            get { return trx_num; }
            set { trx_num = value; }
        }
    }
    public class Query_HospitalChargesDet : HospitalChargesDet
    {
        bggQueryPgSql MyQuery = new bggQueryPgSql();
        repeatedFunction repfunc = new repeatedFunction();
        string myString;
        string serialnum;

        public string GetLastSerialNum(string year)
        {
            myString = "Select trx_num from transaction.hospital_charges where trx_num like '" + year + "%-_______'  order by trx_num desc limit 1";
            serialnum = MyQuery.ViaSingleData(myString);
            string result;
            if (serialnum == null || serialnum.Length > 12)
            {
                result = year + "-0000000";
            }
            else
            {
                result = serialnum;
            }
            return result;
        }

        public bool Insert()
        {
            myString = "insert into transaction.hospital_charges(status,date,category_id,charge_discription,charge_name,hospital_fee,phic_fee,mc_fee,trx_num) values ('" + Status + "','" + Date + "','" + Category_id + "','" + Charge_discription + "','" + Charge_name + "','" + Hospital_fee + "','" + Phic_fee + "','" + Mc_fee + "','" + Trx_num + "')";
            return MyQuery.InsertUpdateDelete(myString);
        }

        public bool Update()
        {
            myString = "update transaction.hospital_charges set status = '" + Status + "',date = '" + Date + "',category_id = '" + Category_id + "',charge_discription = '" + Charge_discription + "',charge_name = '" + Charge_name + "',hospital_fee = '" + Hospital_fee + "',phic_fee = '" + Phic_fee + "',mc_fee = '" + Mc_fee + "' where trx_num = '" + Trx_num + "'";
            return MyQuery.InsertUpdateDelete(myString);
        }
        public bool update_stat(bool stat, string serial)
        {
            myString = "update transaction.hospital_charges set status = '" + stat + "' where trx_num = '" + serial + "'";
            return MyQuery.InsertUpdateDelete(myString);
        }

        public DataGridView Getdetails(DataGridView mydg,bool stat)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY a.status desc) || '.'::text AS sn, b.name as category,charge_name,charge_discription,hospital_fee,phic_fee,mc_fee,initcap(case when a.status = 't' then 'Active' else 'Inactive' end) as status,a.id as id ,trx_num from transaction.hospital_charges as a,transaction.chargecategory_master as b where a.status = '" + stat + "' and a.category_id = b.category_id order by sn asc";
            return MyQuery.ViaDataGridView(myString, mydg);
        }
        public DataGridView Getdetails(DataGridView mydg,bool stat,string category)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY a.status desc) || '.'::text AS sn, b.name as category,charge_name,charge_discription,hospital_fee,phic_fee,mc_fee,initcap(case when a.status = 't' then 'Active' else 'Inactive' end) as status,a.id as id,trx_num from transaction.hospital_charges as a,transaction.chargecategory_master as b where a.status = '" + stat + "' and a.category_id = b.category_id and b.name = '" + category + "' order by sn asc";
            return MyQuery.ViaDataGridView(myString, mydg);
        }
        public DataGridView Getdetails(DataGridView mydg,bool stat,string category,string search)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY p.category desc) || '.'::text AS sn, p.* from (select b.name as category,charge_name,charge_discription,hospital_fee,phic_fee,mc_fee,initcap(case when a.status = 't' then 'Ative' else 'Inactive' end) as status,a.id as id,trx_num from transaction.hospital_charges as a,transaction.chargecategory_master as b where a.status = '" + Status + "' and a.category_id = b.category_id and b.name = '" + category + "') as p where lower(p.category) like '%" + search + "%' or lower(p.charge_name) like '%" + search + "%' order by sn asc";
            return MyQuery.ViaDataGridView(myString, mydg);
        }
        public DataGridView Getdetailsall(DataGridView mydg, bool stat, string search)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY p.category desc) || '.'::text AS sn, p.* from (select b.name as category,charge_name,charge_discription,hospital_fee,phic_fee,mc_fee,initcap(case when a.status = 't' then 'Active' else 'Inactive' end) as status,a.id as id,trx_num from transaction.hospital_charges as a,transaction.chargecategory_master as b where a.status = '" + Status + "' and a.category_id = b.category_id) as p where lower(p.category) like '%" + search + "%' or lower(p.charge_name) like '%" + search + "%' order by sn asc";
            return MyQuery.ViaDataGridView(myString, mydg);
        }

        public DataTable getalldata(DataTable mydt,bool stat,string serialnum)
        {
            myString = "select * from transaction.hospital_charges where trx_num = '" + serialnum + "' and status = '" + stat + "'";
            return MyQuery.ViaDataTable(myString, mydt);
        }

    }
}
