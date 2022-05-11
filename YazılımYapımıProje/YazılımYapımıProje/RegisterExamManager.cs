using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YazılımYapımıProje
{
    public class RegisterExamManager : IRegisterProcedure
    {
        public Dictionary<string, string> userInfo;
        private const string conStr = @"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True";
        public void CreateAccount()
        {
            SqlConnection connection = new SqlConnection(conStr);
            RegisterManager.ControlAndPrintDatabase(this.userInfo, connection, 2);
        }
    }
}
