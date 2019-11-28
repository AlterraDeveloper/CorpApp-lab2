using System;
using System.Windows.Forms;
using CorpApp_lab2.Repositories;

namespace CorpApp_lab2.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var user = AuthRepo.Authentication(loginTxtBox.Text, pswdTxtBox.Text);

            if (user == null)
            {
                MessageBox.Show("Неверный логин\\пароль", "Ошибка");
            }
            else
            {
                Hide();
                var mainForm = new MainForm(user);
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            new SignInForm().Show();
        }
    }
}
