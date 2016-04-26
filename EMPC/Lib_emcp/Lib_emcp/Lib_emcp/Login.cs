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
    public class Login
    {
        private string employee_id;
        public string Employee_id
        {
            get { return employee_id; }
            set { employee_id = value; }
        }
    }
}
