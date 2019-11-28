using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CorpApp_lab2.Repositories
{
    public static class AuthRepo
    {
        public static User Authentication(string login, string password)
        {
            User user;

            using (var dbContext = new AudioPlayerDbContext())
            {
                var passwordHash = AuthUtils.GetHash(password);

                user = dbContext.Users.FirstOrDefault(usr => usr.UserLogin == login && usr.PasswordHash == passwordHash);

            }

            return user;
        }
    }
}
