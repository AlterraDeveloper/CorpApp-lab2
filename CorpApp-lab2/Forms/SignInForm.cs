using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorpApp_lab2.Forms
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();

            FullNameTxtBox.TextChanged += ResetBackground;
            LoginTxtBox.TextChanged += ResetBackground;
            PasswordTxtBox.TextChanged += ResetBackground;
            ConfirmPasswordTxtBox.TextChanged += ResetBackground;
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

            if(PasswordTxtBox.Text == string.Empty || ConfirmPasswordTxtBox.Text == string.Empty || PasswordTxtBox.Text != ConfirmPasswordTxtBox.Text)
            {
                PasswordTxtBox.BackColor = Color.IndianRed;
                ConfirmPasswordTxtBox.BackColor = Color.IndianRed;
                return;
            }

            using (var dbContext = new AudioPlayerDbContext())
            {
                var user = new User
                {
                    UserFullName = FullNameTxtBox.Text,
                    UserLogin = LoginTxtBox.Text,
                    PasswordHash = AuthUtils.GetHash(PasswordTxtBox.Text)
                };

                dbContext.Users.Add(user);
                dbContext.SaveChanges();
            }

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
