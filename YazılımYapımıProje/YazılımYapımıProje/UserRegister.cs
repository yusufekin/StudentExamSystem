using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace YazılımYapımıProje
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(500);

            List<TextBox> textBoxes = new List<TextBox>()
            {
                txtUsername,
                txtPassword,
                txtEmail,
                txtPhoneNumber,
                txtName,
                txtSurname
            };

            if (Control(textBoxes))
            {
                AddUser();
                ScreenClear(textBoxes);
            }
            else
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
        }

        public void ScreenClear(List<TextBox> textBoxes)
        {
            for (int i = 0; i < textBoxes.Count; i++)
            {
                textBoxes[i].Text = texts[i];
                textBoxes[i].ForeColor = Color.FromArgb(109, 109, 109);
            }

            rdbtnStudent.Checked = false;
            rdbtnExamManager.Checked = false;
        }

        #region AddUser
        /*
        >>> Bu fonksiyon kullanıcı bilgilerini form sayfasından çekip
        >>> sınav sorumlusu tipinde veya öğrenci tipinde bir nesne oluşturur.
        */
        private void AddUser()
        {
            try
            {
                Dictionary<string, string> userInfo = new Dictionary<string, string>
                {
                    { "UserName", txtUsername.Text },
                    { "Name", txtName.Text },
                    { "Surname", txtSurname.Text },
                    { "Password", txtPassword.Text },
                    { "Mail", txtEmail.Text },
                };

                string userType = rdbtnStudent.Checked ? "Öğrenci" : "Sınav Sorumlusu";
                RegisterFactory registerFactory = new RegisterFactory();
                IRegisterProcedure register = registerFactory.CreateRegistryObject(userType, userInfo);
                userInfo = null;
                register.CreateAccount();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion
        
        #region TextBox_Control
        /*
        >>> Bu Fonksiyon tüm textboxları kontrol eder. İlgili textboxlardan 
        >>> birinin bile içeriği boş ise "false" değerini döndürür, aksi durumda "true"
        >>> değerini döndürür.
        */
        private bool Control(List<TextBox> textBoxes)
        {
            foreach (var textbox in textBoxes)
            {
                if (textbox.Text == "" || textbox.Text == texts[textbox.TabIndex])
                    return false;
            }
            return true;
        }
        #endregion

        #region UserTexts_Placholder
        private string[] texts = new string[] { "Kullanıcı Adı", "Yeni Şifre", "E-Posta", "Telefon", "Adın", "Soyadın" };

        /*
        >>> Bu kısımda herhangi bir textbox'a girilirse/tıklanırsa(Enter)
        >>> veya herhangi bir tetbox'dan çıkılırsa(Leave) Aşağıdaki fonksiyonlar tetiklenir.
        >>> Bu fonksiyonlar ilgili textbox'ın tıklandığında içeriğini boşaltır. Böylece 
        >>> bir placeholder görünümü elde edilmiş olunur.
        */
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
