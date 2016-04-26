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
    public class Employee
    {
        private string employee_id;
        public string Employee_id
        {
            get { return employee_id; }
            set { employee_id = value; }
        }
        private string employee_lname;
        public string Employee_lname
        {
            get { return employee_lname; }
            set { employee_lname = value; }
        }
        private string employee_mname;
       public string Employee_mname
        {
            get { return employee_mname; }
            set { employee_mname = value; }
        }
        private string employee_fname;
        public string Employee_fname
        {
            get { return employee_fname; }
            set { employee_fname = value; }
        }
        private string employee_nname;
        public string Employee_nname
        {
            get { return employee_nname; }
            set { employee_nname = value; }
        }
        private string employee_address;    
        public string Employee_address
        {
            get { return employee_address; }
            set { employee_address = value; }
        }
        private string employee_bdate;
        public string Employee_bdate
        {
            get { return employee_bdate; }
            set { employee_bdate = value; }
        }
        private string employee_mstatus;
        public string Employee_mstatus
        {
            get { return employee_mstatus; }
            set { employee_mstatus = value; }
        }
        private string employee_gender;
        public string Employee_gender
        {
            get { return employee_gender; }
            set { employee_gender = value; }
        }
        private string employee_phone;
        public string Employee_phone
        {
            get { return employee_phone; }
            set { employee_phone = value; }
        }
        private string employee_emailaddress;
        public string Employee_emailaddress
        {
            get { return employee_emailaddress; }
            set { employee_emailaddress = value; }
        }
        private string employee_status;
        public string Employee_status
        {
            get { return employee_status; }
            set { employee_status = value; }
        }
        private string employee_piclocation;
        public string Employee_piclocation
        {
            get { return employee_piclocation; }
            set { employee_piclocation = value; }
        }
        private string employee_sss;
        public string Employee_sss
        {
            get { return employee_sss; }
            set { employee_sss = value; }
        }
        private string employee_tin;
        public string Employee_tin
        {
            get { return employee_tin; }
            set { employee_tin = value; }
        }
        private string employee_phic;
        public string Employee_phic
        {
            get { return employee_phic; }
            set { employee_phic = value; }
        }
        private string employee_ibig_gsis;
        public string Employee_ibig_gsis
        {
            get { return employee_ibig_gsis; }
            set { employee_ibig_gsis = value; }
        }
        private string employee_dl;
        public string Employee_dl
        {
            get { return employee_dl; }
            set { employee_dl = value; }
        }
        private string employee_createdby;
        public string Employee_createdby
        {
            get { return employee_createdby; }
            set { employee_createdby = value; }
        }
        private string employee_createddate;
        public string Employee_createddate
        {
            get { return employee_createddate; }
            set { employee_createddate = value; }
        }
        private string employee_editedby;
        public string Employee_editedby
        {
            get { return employee_editedby; }
            set { employee_editedby = value; }
        }
        private string employee_editeddate;
        public string Employee_editeddate
        {
            get { return employee_editeddate; }
            set { employee_editeddate = value; }
        }
        private string employee_type;
        public string Employee_type
        {
            get { return employee_type; }
            set { employee_type = value; }
        }

    }

    public class Query_Employee : Employee
    {
        bggQueryPgSql MyQuery = new bggQueryPgSql();
        repeatedFunction repfunc = new repeatedFunction();
        string MyString;



        public bool insert()
        {
            MyString = "insert into transaction.employee_master (employee_id,employee_lname, employee_mname,employee_fname,employee_nname,employee_address,employee_bdate,employee_mstatus,employee_gender,employee_phone,employee_emailaddress,employee_status,employee_piclocation,employee_sss,employee_tin,employee_phic,employee_ibig_gsis,employee_dl,employee_type)" +
                       " values ('"+ Employee_id + "', '"+ Employee_lname + "','"+ Employee_mname + "','"+ Employee_fname + "','"+ Employee_nname + "','"+ Employee_address + "','"+ Employee_bdate + "','"+ Employee_mstatus + "','"+ Employee_gender + "','"+ Employee_phone + "','"+ Employee_emailaddress + "','"+ Employee_status + "','"+ Employee_piclocation + "','"+ Employee_sss + "','"+ Employee_tin + "','"+ Employee_phic + "','"+ Employee_ibig_gsis + "','"+ Employee_dl + "', '"+ Employee_type + "')";
            return MyQuery.InsertUpdateDelete(MyString);
        }   
        public string GenerateIdNew(Random rnd)
        {
            MyString = "Select count(*) from transaction.employee_master where employee_id=";
            return repfunc.Generate_IdRandom(MyString, "estelamedicalclinicandpharmacy1234567890", rnd);
        }

        public DataTable GetDetails( DataTable mydt, string emp_id)
        {
            MyString = "select * from transaction.employee_master where employee_id = '"+emp_id+"'";
            return MyQuery.ViaDataTable(MyString, mydt);
        }

        public DataGridView GetEmployeeDetails(DataGridView myLv, string stat)
        {
            MyString = "select DISTINCT row_number() OVER (ORDER BY employee_status desc) || '.'::text AS sn, initcap(employee_fname)||' '||initcap(employee_mname)||'. '" +
                       "||initcap(employee_lname) as name,initcap(employee_address) as address, initcap(employee_gender) as gender,employee_phone as contact_num,employee_createdby as created_by,employee_createddate as created_date,employee_editedby as edited_by,employee_editeddate as edited_date,employee_id,initcap(case when employee_status = 't' then 'true' else 'false' end) as status from transaction.employee_master where employee_status = '" + stat + "' order by sn asc;";
            return MyQuery.ViaDataGridView(MyString, myLv);
        }

        public DataTable GetEmployeeViaTbAuto(DataTable myTb)
        {
            MyString = "select employee_id,initcap(employee_fname)||' '||initcap(employee_mname)||'. '||initcap(employee_lname) as name from transaction.employee_master where employee_status = 't' order by employee_fname asc";          
            return MyQuery.ViaDataTable(MyString, myTb);
        }
        public string getEmpname(string empid)
        {
            MyString = "select initcap(a.employee_fname)||' '||initcap(a.employee_mname)||'. '||initcap(a.employee_lname) as name from transaction.employee_master as a, transaction.useraccess as b where b.employee_id = a.employee_id and b.employee_id = '" + empid + "'";
            return MyQuery.ViaSingleData(MyString);
        }


    }
    



}
