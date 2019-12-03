using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorpApp_lab2.DataTransferObjects;

namespace CorpApp_lab2.Repositories
{
    public static class MusicTracksRepo
    {
        public static IEnumerable<MusicTrackDto> GetAllOfUser(int userId)
        {
            var musicTrackDtos = new List<MusicTrackDto>();

            using (var dbContext = new AudioPlayerDbContext())
            {
                var musicTracks = dbContext.MusicTracks.Include("Genres").Include("Users").Include("Playlists")
                    .Where(x => x.UploadUserId == userId).ToList();

                foreach (var musicTrack in musicTracks)
                {
                    musicTrackDtos.Add(new MusicTrackDto
                    {
                        Id = musicTrack.TrackId,
                        Name = musicTrack.TrackName,
                        AuthorName = musicTrack.TrackAuthor,
                        GenreName = musicTrack.Genres.GenreName
                    });
                }
            }

            return musicTrackDtos;
        }

        public static IEnumerable<MusicTrackDto> GetAllInPlaylist(Playlist playlist)
        {
            var musicTrackDtos = new List<MusicTrackDto>();

            using (var dbContext = new AudioPlayerDbContext())
            {
                var musicTracks = dbContext.MusicTracks.Include("Genres").Include("Users").Include("Playlists").
                    Where(x => x.Playlists.Any(p => p.PlaylistId == playlist.PlaylistId)).ToList();

                foreach (var musicTrack in musicTracks)
                {
                    musicTrackDtos.Add(new MusicTrackDto
                    {
                        Id = musicTrack.TrackId,
                        Name = musicTrack.TrackName,
                        AuthorName = musicTrack.TrackAuthor,
                        GenreName = musicTrack.Genres.GenreName
                    });
                }
            }

            return musicTrackDtos;
        }

        public static void AddOrUpdate(MusicTrack musicTrack)
        {
            using (var dbContext = new AudioPlayerDbContext())
            {
                dbContext.MusicTracks.AddOrUpdate(musicTrack);
                dbContext.SaveChanges();
            }
        }
    }
}
