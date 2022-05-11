using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YazılımYapımıProje
{
    public static class RegisterManager
    {
        private static Dictionary<string, string> UserInfo;
        private static SqlConnection Connection;
        private static int UserTypeID;

        /*
        >>> Bu fonksiyon gelen nesnesinin (Öğrenci, Sınav sorumlusu)
        >>> bilgilerini alır ve kullanıcı adı daha önce kullanılmamış ise 
        >>> veri tabanında bir kayıt oluşturur.
        */
        public static void ControlAndPrintDatabase(Dictionary<string, string> userInfo, SqlConnection connection, int userTypeID)
        {
            UserInfo = userInfo;
            Connection = connection;
            UserTypeID = userTypeID;
            
            if (UserNameControl() == false)
                PrintToDatabase();
            else
                System.Windows.Forms.MessageBox.Show("Kullanıcı adı kullanılmakta!");
        }
        private static void PrintToDatabase()
        {
            try
            {
                Connection.Open();

                SqlCommand command = new SqlCommand("Insert Into Users " +
                                                    "(UserName, Name, Surname, Mail, Password, UserTypeID)" +
                                                    "values " +
                                                    "(@UserName, @Name, @Surname, @Mail, @Password, @UserTypeID)", Connection);

                foreach (string value in UserInfo.Keys)
                {
                    command.Parameters.AddWithValue(Convert.ToString(value), UserInfo[value]);
                }

                command.Parameters.AddWithValue("UserTypeID", UserTypeID);
                command.ExecuteNonQuery();
                Connection.Close();

                System.Windows.Forms.MessageBox.Show("Kayıt Başarıyla oluşturuldu!");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
        }

        private static bool UserNameControl()
        {
            Connection.Open();

            SqlCommand cmd = new SqlCommand("Select * From Users", Connection);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (Convert.ToString(dr["UserName"]) == UserInfo["UserName"])
                {
                    Connection.Close();
                    return true;
                }
            }

            Connection.Close();
            return false;
        }
    }
}
