using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpApp_lab2.Repositories
{
    public static class GenresRepo
    {
        public static Genre GetByName(string genreName)
        {
            using (var dbContext = new AudioPlayerDbContext())
            {
                return dbContext.Genres.FirstOrDefault(x => x.GenreName == genreName);
            }
        }

        public static IEnumerable<Genre> GetAll()
        {
            using (var dbContext = new AudioPlayerDbContext())
            {
                return dbContext.Genres.ToList();
            }
        }
    }
}
