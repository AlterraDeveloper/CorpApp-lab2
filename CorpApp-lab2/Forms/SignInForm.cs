using System;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Windows.Forms;

namespace CorpApp_lab2.Forms
{
    public partial class SignInForm : Form
    {
        private User _user;

        public SignInForm()
        {
            InitializeComponent();

            FullNameTxtBox.TextChanged += ResetBackground;
            LoginTxtBox.TextChanged += ResetBackground;
            PasswordTxtBox.TextChanged += ResetBackground;
            ConfirmPasswordTxtBox.TextChanged += ResetBackground;

            _user = new User();
        }

        public SignInForm(User user) : this()
        {
            signInBtn.Text = "Сохранить";

            if (user != null)
            {
                _user = user;
                FullNameTxtBox.Text = _user.UserFullName;
                LoginTxtBox.Text = _user.UserLogin;
                PasswordTxtBox.Text = _user.PasswordHash;
                ConfirmPasswordTxtBox.Text = _user.PasswordHash;
            }
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {

            if (FullNameTxtBox.Text == string.Empty)
            {
                FullNameTxtBox.BackColor = Color.IndianRed;
                return;
            }
            if (LoginTxtBox.Text == string.Empty)
            {
                LoginTxtBox.BackColor = Color.IndianRed;
                return;
            }

            if (PasswordTxtBox.Text == string.Empty || ConfirmPasswordTxtBox.Text == string.Empty || PasswordTxtBox.Text != ConfirmPasswordTxtBox.Text)
            {
                PasswordTxtBox.BackColor = Color.IndianRed;
                ConfirmPasswordTxtBox.BackColor = Color.IndianRed;
                return;
            }

            using (var dbContext = new AudioPlayerDbContext())
            {
                _user.UserFullName = FullNameTxtBox.Text;
                _user.UserLogin = LoginTxtBox.Text;
                if (_user.PasswordHash != PasswordTxtBox.Text)
                    _user.PasswordHash = AuthUtils.GetHash(PasswordTxtBox.Text);

                dbContext.Users.AddOrUpdate(_user);
                dbContext.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ResetBackground(object sender, EventArgs e)
        {
            if (sender is Control control && control.Text != string.Empty)
            {
                control.ResetBackColor();
            }
        }
    }
}
