using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazılımYapımıProje
{
    public partial class RefreshPassword : Form
    {
        public RefreshPassword()
        {
            InitializeComponent();
        }

        private void btnRefreshPassword_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(300);

            const string conStr = @"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conStr);

            bool userNameMailCorrect = UserNameMailControl(connection, txtUsername.Text, txtEmail.Text);

            if (userNameMailCorrect)
            {
                UpdatePassword(connection, txtUsername.Text, txtPassword.Text);
                this.Close();
            }
            else
                MessageBox.Show("E-mail veya Kullanıcı Adı hatalı!");

        }

        private bool UserNameMailControl(SqlConnection con, string userName, string mail)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Users Where UserName = '" + userName + "' " +
                                            "and Mail = '" + mail + "' ", con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                con.Close();
                return true;
            }

            con.Close();
            return false;
        }

        private void UpdatePassword(SqlConnection con, string userName, string password)
        {
            if(txtPassword.Text == txtPassword2.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Users Set Password = '" + txtPassword.Text + "' " +
                                             "Where UserName = '" + txtUsername.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Güncellendi");
            }
            else
            {
                MessageBox.Show("Lütfen girilen şifrelerin eşleştiğinden emin olun!");
            }
        }

        #region UserTexts_PlaceHolder

        private string[] texts = new string[] { "Kullanıcı Adı", "E-Posta", "Şifre", "Şifreyi Doğrula" };
        private void TextBox_Enter(object sender, EventArgs e)
        {
            var selectedTextBox = ((TextBox)sender);

            if (selectedTextBox.Text == texts[selectedTextBox.TabIndex])
            {
                selectedTextBox.Text = "";
                selectedTextBox.ForeColor = Color.Black;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            var selectedTextBox = ((TextBox)sender);

            if (selectedTextBox.Text == "")
            {
                selectedTextBox.Text = texts[selectedTextBox.TabIndex];
                selectedTextBox.ForeColor = Color.FromArgb(109, 109, 109);
            }
        }

        #endregion

        
    }
}
