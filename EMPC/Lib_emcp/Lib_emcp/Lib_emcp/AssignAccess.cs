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
    public class AssignAccess
    {
        private string employee_id;
        public string Employee_id
        {
            get { return employee_id; }
            set { employee_id = value; }
        }
        private string authorizedby_id;
        public string Authorizedby_id
        {
            get { return authorizedby_id; }
            set { authorizedby_id = value; }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string access_level;
        public string Access_level
        {
            get { return access_level; }
            set { access_level = value; }
        }
        

    }
    public class Query_AssignAccess  : AssignAccess
    {
        bggQueryPgSql MyQuery = new bggQueryPgSql();
        repeatedFunction repfunc = new repeatedFunction();
        string MyString;

        public string GenerateIdNew(Random rnd, TextBox tbchar)
        {
            MyString = "Select count(*) from transaction.useraccess where employee_id=";
            return repfunc.Generate_IdRandom(MyString, tbchar.ToString(), rnd);
        }
        public bool insert()
        {
            MyString = "insert into transaction.useraccess (employee_id,authorizedby_id,username,password,access_level) values ('" + Employee_id + "','" + Authorizedby_id + "','" + Username + "','" + Password + "','"+ Access_level + "')";
            return MyQuery.InsertUpdateDelete(MyString);
        }
        int count;
        public bool CheckIfAccessnameExists(string accessid)
        {
            count = 0;
            MyString = "Select count(*) from transaction.useraccess where employee_id = '" + accessid + "';";
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

        public bool StartLogin(string username, string password)
        {
            count = 0;
            MyString = "select count(*) from transaction.useraccess where username = '" + username + "' and password = '"+ password + "';";
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
        public string GetIDfromLogin(string username, string password)
        {
            MyString = "select employee_id from transaction.useraccess where username = '" + username + "' and password = '" + password + "';";
            return MyQuery.ViaSingleData(MyString);

        }
        

    }
}
