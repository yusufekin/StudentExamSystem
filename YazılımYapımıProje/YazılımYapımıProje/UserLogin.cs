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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            switch (LoginUser(txtUsername.Text, txtPassword.Text))
            {
                case 1:
                    MessageBox.Show("Admin Ekranı");
                    break;
                case 2:
                    MessageBox.Show("Sınav sorumlusu ekranı");
                    break;
                case 3:
                    MessageBox.Show("Öğrenci ekranı");
                    break;
                default:
                    MessageBox.Show("Böyle bir kayıt yok!");
                    break;
            }
        }

        private int LoginUser(string username, string password)
        {
            int userType = 0;

            const string conStr = @"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();

            SqlCommand cmd = new SqlCommand("Select * From Users", connection);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (Convert.ToString(dr["UserName"]) == username &&
                    Convert.ToString(dr["Password"]) == password)
                {
                    userType = Convert.ToInt32(dr["UserTypeID"]);
                    break;
                }
            }

            return userType;
        }

        #region Designer

        private void lblSifreUnut_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(300);
            openChildForm(new RefreshPassword());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(300);
            openChildForm(new SignUp());
            
        }

        private void panelChildForm_MouseMove(object sender, MouseEventArgs e)
        {
            lblStick3.Visible = false;

        }

        private void lblForgotPassword_MouseMove(object sender, MouseEventArgs e)
        {
            lblStick3.Visible = true;
        }

        #endregion

        #region UserTexts_Placholder

        private string[] texts = new string[] { "Kullanıcı Adı", "Şifre" };
        private void textBox_Enter(object sender, EventArgs e)
        {
            var selectedTextBox = ((TextBox)sender);

            if (selectedTextBox.Text == texts[selectedTextBox.TabIndex])
            {
                selectedTextBox.Text = "";
                selectedTextBox.ForeColor = Color.Black;
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
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
