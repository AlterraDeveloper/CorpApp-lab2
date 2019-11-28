using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CorpApp_lab2.Repositories
{
    public static class PlaylistsRepo
    {
        public static IEnumerable<Playlist> GetAll(int userId)
        {
            using (var dbContext = new AudioPlayerDbContext())
            {
                return dbContext.Playlists.Where(x => x.PlaylistOwnerId == userId).ToList();
            }
        }
        
        public static void AddOrUpdate(Playlist playlist)
        {
            using (var dbContext = new AudioPlayerDbContext())
            {
                dbContext.Playlists.AddOrUpdate(playlist);
                dbContext.SaveChanges();
            }
        }

        public static void Delete(Playlist playlist)
        {
            using (var dbContext = new AudioPlayerDbContext())
            {
                dbContext.Playlists.Remove(playlist);
                dbContext.SaveChanges();

            }
        }
    }
}
