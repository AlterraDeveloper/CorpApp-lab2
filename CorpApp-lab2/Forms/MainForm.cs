using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using CorpApp_lab2.Repositories;
using System.Windows.Forms;
using CorpApp_lab2.DataTransferObjects;

namespace CorpApp_lab2.Forms
{
    public partial class MainForm : Form
    {
        private User _currentUser;

        public MainForm(User user)
        {
            InitializeComponent();

            _currentUser = user;

            CurrentUserLabel.Text = "Пользователь : " + _currentUser.UserFullName;

            FillOrRefreshTracksGridView();

            FillOrRefreshPlaylistsGridView();

        }


        private void FillOrRefreshPlaylistsGridView()
        {
            var playlists = PlaylistsRepo.GetAll(_currentUser.UserId).ToList();
            playlists.Add(new Playlist
            {
                PlaylistName = "Загруженные мною"
            });
            playlists = playlists.OrderBy(x => x.PlaylistId).ToList();
            PlaylistsDataGridView.DataSource = playlists;
            PlaylistsDataGridView.Columns[0].Visible = false;
            PlaylistsDataGridView.Columns[1].HeaderText = "Плейлисты";
            PlaylistsDataGridView.Columns[2].Visible = false;
            PlaylistsDataGridView.Columns[3].Visible = false;
            PlaylistsDataGridView.Columns[4].Visible = false;
        }

        private void FillOrRefreshTracksGridView(Playlist playlist = null)
        {
            var tracks = playlist == null ? MusicTracksRepo.GetAllOfUser(_currentUser.UserId) : MusicTracksRepo
                .GetAllInPlaylist(playlist);
            TracksGridView.DataSource = tracks;
            TracksGridView.Columns[0].Visible = false;
            TracksGridView.Columns[1].HeaderText = "Композиция";
            TracksGridView.Columns[2].HeaderText = "Исполнитель";
            TracksGridView.Columns[3].HeaderText = "Жанр";
        }

        private void PlaylistsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            var currentMouseOverRow = PlaylistsDataGridView.HitTest(e.X, e.Y).RowIndex;

            if (currentMouseOverRow >= 0)
            {
                PlaylistsDataGridView.Rows[currentMouseOverRow].Selected = true;
            }

            PlaylistContextMenuStrip.Show(PlaylistsDataGridView, new Point(e.X, e.Y));
        }

        private void AddPlaylist_Click(object sender, EventArgs e)
        {

            var playlist = new Playlist
            {
                PlaylistOwnerId = _currentUser.UserId
            };

            if (new AddPlaylistForm(playlist).ShowDialog() == DialogResult.OK)
            {
                FillOrRefreshPlaylistsGridView();
            }

        }

        private void EditPlaylist_Click(object sender, EventArgs e)
        {
            var selectedRow = PlaylistsDataGridView.SelectedRows[0];

            var playlist = (Playlist)selectedRow.DataBoundItem;

            if (new AddPlaylistForm(playlist).ShowDialog() == DialogResult.OK)
            {
                FillOrRefreshPlaylistsGridView();
            }
        }

        private void DeletePlaylist_Click(object sender, EventArgs e)
        {
            var selectedRow = PlaylistsDataGridView.SelectedRows[0];

            var playlist = (Playlist)selectedRow.DataBoundItem;

            PlaylistsRepo.Delete(playlist);
        }


        private void PlaylistsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = PlaylistsDataGridView.SelectedRows[0];

            var playlist = (Playlist)selectedRow.DataBoundItem;

            if (playlist.PlaylistId == 0)
            {
                FillOrRefreshTracksGridView();
            }
            else
            {
                FillOrRefreshTracksGridView(playlist);
            }
        }

        private void CurrentUserLabel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            UserContextMenuStrip.Show((Control)sender,new Point(e.X,e.Y));
        }

        private void войтиСДругогоАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var authForm = new AuthForm();
            authForm.Show(this);
        }

        private void редактироватьДанныеПрофиляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new SignInForm(_currentUser).ShowDialog(this) == DialogResult.OK)
            {
                CurrentUserLabel.Text = "Пользователь : " + UsersRepo.GetUser(_currentUser.UserId).UserFullName;
            }
        }

        private void TracksGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            var currentMouseOverRow = TracksGridView.HitTest(e.X, e.Y).RowIndex;

            if (currentMouseOverRow >= 0)
            {
                TracksGridView.Rows[currentMouseOverRow].Selected = true;
            }

            TracksContextMenuStrip.Show(TracksGridView, new Point(e.X, e.Y));
        }

        private void добавитьТрекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var musicTrack = new MusicTrack
            {
                UploadUserId = _currentUser.UserId
            }; 

            new MusicTrackForm(musicTrack).Show(this);

            FillOrRefreshTracksGridView();
        }

        private void редактироватьТрекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = TracksGridView.SelectedRows[0];

            var musicTrackDto = (MusicTrackDto)selectedRow.DataBoundItem;

            var genre = GenresRepo.GetByName(musicTrackDto.GenreName);

            var musicTrack = new MusicTrack
            {
                TrackAuthor = musicTrackDto.AuthorName,
                TrackName = musicTrackDto.Name,
                TrackId = musicTrackDto.Id,
                UploadUserId = _currentUser.UserId,
                GenreId = genre.GenreId,
                Genres = genre
            };

            new MusicTrackForm(musicTrack).Show(this);

            FillOrRefreshTracksGridView();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            var selectedRow = PlaylistsDataGridView.SelectedRows[0];

            var playlist = (Playlist)selectedRow.DataBoundItem;

            var tracks = playlist.PlaylistId == 0
                ? MusicTracksRepo.GetAllOfUser(_currentUser.UserId)
                : MusicTracksRepo.GetAllInPlaylist(playlist);

            switch (searchTypeCmbBox.Text)
            {
                case "По названию":
                    TracksGridView.DataSource = tracks.Where(x => x.Name.Contains(searchQueryTxtBox.Text)).ToList();
                    break;
                case "По исполнителю":
                    TracksGridView.DataSource = tracks.Where(x => x.AuthorName.Contains(searchQueryTxtBox.Text)).ToList();
                    break;
                case "По жанру":
                    TracksGridView.DataSource = tracks.Where(x => x.GenreName.Contains(searchQueryTxtBox.Text)).ToList();
                    break;
            }
        }

        private void resetSearchBtn_Click(object sender, EventArgs e)
        {
            searchQueryTxtBox.ResetText();
            searchTypeCmbBox.ResetText();

            var selectedRow = PlaylistsDataGridView.SelectedRows[0];

            var playlist = (Playlist)selectedRow.DataBoundItem;

            if (playlist.PlaylistId == 0)
            {
                FillOrRefreshTracksGridView();

            }
            else
            {
                FillOrRefreshTracksGridView(playlist);
            }
        }
    }
}
