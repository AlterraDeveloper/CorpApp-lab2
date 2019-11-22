using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CorpApp_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var context = new AudioPlayerDbContext())
            {
                dataGridView1.DataSource = context.Genres.ToList();


                //var user = new User
                //{
                //    UserLogin = "admin",
                //    UserFullName = "Kiselev Eugene",
                //    IsAdmin = true,
                //    PasswordHash =
                //        Encoding.ASCII.GetString(
                //            new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes("123")))
                //};
                //context.Users.Add(user);
                //context.SaveChanges();
            }
        }
    }
}
