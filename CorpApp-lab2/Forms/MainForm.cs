using System;
using System.Drawing;
using System.Media;
using CorpApp_lab2.Repositories;
using System.Windows.Forms;

namespace CorpApp_lab2.Forms
{
    public partial class MainForm : Form
    {
        private readonly User _currentUser;

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
            PlaylistsDataGridView.DataSource = PlaylistsRepo.GetAll(_currentUser.UserId);
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
            TracksGridView.Columns[0].HeaderText = "Композиция";
            TracksGridView.Columns[1].HeaderText = "Исполнитель";
            TracksGridView.Columns[2].HeaderText = "Жанр";
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

            FillOrRefreshTracksGridView(playlist);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Eugene\Downloads\ellie-goulding-juice-wrld-hate-me(mp3-top.info).wav");
            player.Play();
        }
    }
}
