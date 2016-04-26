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
    public class Patient
    {
        private string patient_status;
        public string Patient_status
        {
            get { return patient_status; }
            set { patient_status = value; }
        }
        private string patient_type;
        public string Patient_type
        {
            get { return patient_type; }
            set { patient_type = value; }
        }
        private string patient_lname;
        public string Patient_lname
        {
            get { return patient_lname; }
            set { patient_lname = value; }
        }
        private string patient_fname;
        public string Patient_fname
        {
            get { return patient_fname; }
            set { patient_fname = value; }
        }
        private string patient_mname;
        public string Patient_mname
        {
            get { return patient_mname; }
            set { patient_mname = value; }
        }
        private string patient_bdate;
        public string Patient_bdate
        {
            get { return patient_bdate; }
            set { patient_bdate = value; }
        }
        private string patient_mstatus;
        public string Patient_mstatus
        {
            get { return patient_mstatus; }
            set { patient_mstatus = value; }
        }   
        private string patient_gender;
        public string Patient_gender
        {
            get { return patient_gender; }
            set { patient_gender = value; }
        }
        private string patient_address1;
        public string Patient_address1
        {
            get { return patient_address1; }
            set { patient_address1 = value; }
        }
        private string patient_address2;
        public string Patient_address2
        {
            get { return patient_address2; }
            set { patient_address2 = value; }
        }
        private string patient_contactnum;
        public string Patient_contactnum
        {
            get { return patient_contactnum; }
            set { patient_contactnum = value; }
        }
        private string patient_telnum;
        public string Patient_telnum
        {
            get { return patient_telnum; }
            set { patient_telnum = value; }
        }
        private string patient_phicnum;
        public string Patient_phicnum
        {
            get { return patient_phicnum; }
            set { patient_phicnum = value; }
        }

        private string patient_mc_insurance;
        public string Patient_mc_insurance
        {
            get { return patient_mc_insurance; }
            set { patient_mc_insurance = value; }
        }
        private string patient_id;
        public string Patient_id
        {
            get { return patient_id; }
            set { patient_id = value; }
        }
    }

    public class Query_Patient : Patient
    {
        bggQueryPgSql MyQuery = new bggQueryPgSql();
        repeatedFunction repfunc = new repeatedFunction();
        string myString;
        public string GenerateIdNew(Random rnd)
        {
            myString = "Select count(*) from transaction.patient_master where patient_id=";
            return repfunc.Generate_IdRandom(myString, "estelamedicalclinicandpharmacypatient1234567890", rnd);
        }
        public bool Insert()
        {
            myString = "insert into transaction.patient_master(patient_id,patient_status,patient_type,patient_lname,patient_fname,patient_mname,patient_bdate,patient_mstatus,patient_gender,patient_address1,patient_address2,patient_contactnum,patient_telnum,patient_phicnum,patient_mc_insurance) " +
                "values('"+ Patient_id + "','" + Patient_status + "','" + Patient_type + "','" + Patient_lname + "','" + Patient_fname + "','" + Patient_mname + "','" + Patient_bdate + "','" + Patient_mstatus + "','" + Patient_gender + "','" + Patient_address1 + "','" + Patient_address2 + "','" + Patient_contactnum + "','" + Patient_telnum + "','" + Patient_phicnum + "','" + Patient_mc_insurance + "')";
            return MyQuery.InsertUpdateDelete(myString);
        }
        public DataTable ToUpdate(DataTable mydt,string id)
        {
            myString = "select * from transaction.patient_master where patient_id = '"+id+"'";
            return MyQuery.ViaDataTable(myString,mydt);
        }
        public bool update()
        {
            myString = "update transaction.patient_master set patient_status = '" + Patient_status + "',patient_type = '" + Patient_type + "',patient_lname = '" + Patient_lname + "',patient_fname = '" + Patient_fname + "',patient_mname = '" + Patient_mname + "',patient_bdate = '" + Patient_bdate + "',patient_mstatus = '" + Patient_mstatus + "',patient_gender = '" + Patient_gender + "',patient_address1 = '" + Patient_address1 + "',patient_address2 = '" + Patient_address2 + "',patient_contactnum = '" + Patient_contactnum + "',patient_telnum = '" + Patient_telnum + "',patient_phicnum = '" + Patient_phicnum + "',patient_mc_insurance = '" + Patient_mc_insurance + "' where patient_id = '" + Patient_id + "'";
            return MyQuery.InsertUpdateDelete(myString);
        }
        public bool update_stat(bool stat, string id)
        {
            myString = "update transaction.patient_master set patient_status = '" + stat + "' where patient_id = '" + id + "'";
            return MyQuery.InsertUpdateDelete(myString);
        }
        public DataGridView GetPatient(DataGridView myLv, string stat)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY patient_fname desc) || '.'::text AS sn,patient_type as type,initcap(patient_fname)||' '||initcap(patient_mname)||' '||initcap(patient_lname) as name,initcap(patient_address1)||' '||initcap(patient_address2) as address,patient_gender as gender,patient_contactnum as contact_num,patient_phicnum as phic_num,patient_mc_insurance as mc_num,patient_id as id from transaction.patient_master where patient_status = '" + stat + "' order by sn asc;";
            return MyQuery.ViaDataGridView(myString, myLv);
        }
        public DataGridView GetPatient(DataGridView myLv, string stat,string type)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY patient_fname desc) || '.'::text AS sn,patient_type as type,initcap(patient_fname)||' '||initcap(patient_mname)||' '||initcap(patient_lname) as name,initcap(patient_address1)||' '||initcap(patient_address2) as address,patient_gender as gender,patient_contactnum as contact_num,patient_phicnum as phic_num,patient_mc_insurance as mc_num,patient_id as id from transaction.patient_master where patient_status = '" + stat + "' and patient_type = '" + type + "' order by sn asc;";
            return MyQuery.ViaDataGridView(myString, myLv);
        }
        public DataGridView GetPatient(DataGridView mydt,string tbsearch,string type,string stat)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY p.name desc,p.*) || '.'::text AS sn, p.* from (select patient_type as type,initcap(patient_fname)||' '||initcap(patient_mname)||' '||initcap(patient_lname) as name,initcap(patient_address1)||' '||initcap(patient_address2) as address,patient_gender as gender,patient_contactnum as contact_num,patient_phicnum as phic_num,patient_mc_insurance as mc_num,patient_id as id from transaction.patient_master where patient_status = '" + stat + "' and patient_type = '" + type + "') as p where lower(p.name) like '%" + tbsearch + "%' or p.contact_num like '%" + tbsearch + "%' order by sn asc;";
            return MyQuery.ViaDataGridView(myString, mydt);
        }
        public DataGridView GetPatient1(DataGridView mydt, string tbsearch, string stat)
        {
            myString = "select DISTINCT row_number() OVER (ORDER BY p.name desc,p.*) || '.'::text AS sn, p.* from (select patient_type as type,initcap(patient_fname)||' '||initcap(patient_mname)||' '||initcap(patient_lname) as name,initcap(patient_address1)||' '||initcap(patient_address2) as address,patient_gender as gender,patient_contactnum as contact_num,patient_phicnum as phic_num,patient_mc_insurance as mc_num,patient_id as id from transaction.patient_master where patient_status = '" + stat + "') as p where lower(p.name) like '%" + tbsearch + "%' or p.contact_num like '%" + tbsearch + "%' order by sn asc;";
            return MyQuery.ViaDataGridView(myString, mydt);
        }



    }




        
}
