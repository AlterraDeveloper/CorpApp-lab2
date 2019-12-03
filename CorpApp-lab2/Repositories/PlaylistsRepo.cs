using System.Collections.Generic;
using System.Data.Entity;
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
                return dbContext.Playlists.Include("MusicTracks").Include("Users").Where(x => x.PlaylistOwnerId == userId).ToList();
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
                //dbContext.Entry(playlist).State = EntityState.Deleted;
                dbContext.Playlists.Remove(playlist);
                dbContext.SaveChanges();

            }
        }

        public static Playlist GetById(int id)
        {
            using (var dbContext = new AudioPlayerDbContext())
            {
                return dbContext.Playlists.Include("MusicTracks").FirstOrDefault(x => x.PlaylistId == id);
            }
        }
    }
}
