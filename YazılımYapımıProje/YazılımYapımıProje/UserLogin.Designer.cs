
namespace YazılımYapımıProje
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblStick3 = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.imgPasswordIcon = new System.Windows.Forms.PictureBox();
            this.imgUserIcon = new System.Windows.Forms.PictureBox();
            this.lblStick1 = new System.Windows.Forms.Label();
            this.lblStick2 = new System.Windows.Forms.Label();
            this.lblHeaderStick = new System.Windows.Forms.Label();
            this.imgLoginIcon = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.Location = new System.Drawing.Point(117, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 33);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Şifre";
            this.txtPassword.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.Location = new System.Drawing.Point(118, 41);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(193, 33);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Kullanıcı Adı";
            this.txtUsername.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnLogin.Location = new System.Drawing.Point(112, 160);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(197, 49);
            this.btnLogin.TabIndex = 37;
            this.btnLogin.Text = "GİRİŞ";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.btnRegister);
            this.panelChildForm.Controls.Add(this.lblStick3);
            this.panelChildForm.Controls.Add(this.lblForgotPassword);
            this.panelChildForm.Controls.Add(this.imgPasswordIcon);
            this.panelChildForm.Controls.Add(this.imgUserIcon);
            this.panelChildForm.Controls.Add(this.lblStick1);
            this.panelChildForm.Controls.Add(this.lblStick2);
            this.panelChildForm.Controls.Add(this.txtUsername);
            this.panelChildForm.Controls.Add(this.btnLogin);
            this.panelChildForm.Controls.Add(this.txtPassword);
            this.panelChildForm.Location = new System.Drawing.Point(61, 204);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(412, 530);
            this.panelChildForm.TabIndex = 38;
            this.panelChildForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelChildForm_MouseMove);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnRegister.Location = new System.Drawing.Point(112, 225);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(197, 49);
            this.btnRegister.TabIndex = 60;
            this.btnRegister.Text = "KAYIT OL";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblStick3
            // 
            this.lblStick3.BackColor = System.Drawing.Color.Blue;
            this.lblStick3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStick3.ForeColor = System.Drawing.Color.White;
            this.lblStick3.Location = new System.Drawing.Point(194, 339);
            this.lblStick3.Name = "lblStick3";
            this.lblStick3.Size = new System.Drawing.Size(125, 2);
            this.lblStick3.TabIndex = 57;
            this.lblStick3.Visible = false;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.lblForgotPassword.Location = new System.Drawing.Point(196, 323);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(130, 17);
            this.lblForgotPassword.TabIndex = 55;
            this.lblForgotPassword.Text = "Şifreni mi unuttun ?";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblSifreUnut_Click);
            this.lblForgotPassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblForgotPassword_MouseMove);
            // 
            // imgPasswordIcon
            // 
            this.imgPasswordIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgPasswordIcon.Image")));
            this.imgPasswordIcon.Location = new System.Drawing.Point(51, 93);
            this.imgPasswordIcon.Name = "imgPasswordIcon";
            this.imgPasswordIcon.Size = new System.Drawing.Size(60, 38);
            this.imgPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPasswordIcon.TabIndex = 40;
            this.imgPasswordIcon.TabStop = false;
            // 
            // imgUserIcon
            // 
            this.imgUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgUserIcon.Image")));
            this.imgUserIcon.Location = new System.Drawing.Point(51, 38);
            this.imgUserIcon.Name = "imgUserIcon";
            this.imgUserIcon.Size = new System.Drawing.Size(60, 38);
            this.imgUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUserIcon.TabIndex = 39;
            this.imgUserIcon.TabStop = false;
            // 
            // lblStick1
            // 
            this.lblStick1.BackColor = System.Drawing.Color.Black;
            this.lblStick1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStick1.ForeColor = System.Drawing.Color.White;
            this.lblStick1.Location = new System.Drawing.Point(117, 75);
            this.lblStick1.Name = "lblStick1";
            this.lblStick1.Size = new System.Drawing.Size(193, 2);
            this.lblStick1.TabIndex = 41;
            // 
            // lblStick2
            // 
            this.lblStick2.BackColor = System.Drawing.Color.Black;
            this.lblStick2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStick2.ForeColor = System.Drawing.Color.White;
            this.lblStick2.Location = new System.Drawing.Point(116, 131);
            this.lblStick2.Name = "lblStick2";
            this.lblStick2.Size = new System.Drawing.Size(193, 2);
            this.lblStick2.TabIndex = 40;
            // 
            // lblHeaderStick
            // 
            this.lblHeaderStick.BackColor = System.Drawing.Color.Black;
            this.lblHeaderStick.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeaderStick.ForeColor = System.Drawing.Color.White;
            this.lblHeaderStick.Location = new System.Drawing.Point(24, 178);
            this.lblHeaderStick.Name = "lblHeaderStick";
            this.lblHeaderStick.Size = new System.Drawing.Size(490, 5);
            this.lblHeaderStick.TabIndex = 58;
            // 
            // imgLoginIcon
            // 
            this.imgLoginIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgLoginIcon.Image")));
            this.imgLoginIcon.Location = new System.Drawing.Point(164, 25);
            this.imgLoginIcon.Name = "imgLoginIcon";
            this.imgLoginIcon.Size = new System.Drawing.Size(206, 120);
            this.imgLoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLoginIcon.TabIndex = 59;
            this.imgLoginIcon.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 774);
            this.Controls.Add(this.imgLoginIcon);
            this.Controls.Add(this.lblHeaderStick);
            this.Controls.Add(this.panelChildForm);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoginIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox imgPasswordIcon;
        private System.Windows.Forms.PictureBox imgUserIcon;
        private System.Windows.Forms.Label lblStick1;
        private System.Windows.Forms.Label lblStick2;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblStick3;
        private System.Windows.Forms.Label lblHeaderStick;
        private System.Windows.Forms.PictureBox imgLoginIcon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRegister;
    }
}

