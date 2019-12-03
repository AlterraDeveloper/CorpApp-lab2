using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpApp_lab2.Repositories
{
    public static class UsersRepo
    {
        public static User GetUser(int id)
        {
            using (var dbContext = new AudioPlayerDbContext())
            {
                return dbContext.Users.FirstOrDefault(x => x.UserId == id);
            }
        }
    }
}
