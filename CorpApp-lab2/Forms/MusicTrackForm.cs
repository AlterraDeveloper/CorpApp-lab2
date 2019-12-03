using CorpApp_lab2.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CorpApp_lab2.Forms
{
    public partial class MusicTrackForm : Form
    {
        private readonly MusicTrack _musicTrack;

        public MusicTrackForm(MusicTrack musicTrack)
        {
            InitializeComponent();

            _musicTrack = musicTrack;

            TrackNameTxtBox.TextChanged += ResetBackground;
            TrackAuthorTxtBox.TextChanged += ResetBackground;
            GenreCmbBox.TextChanged += ResetBackground;
            PlaylistCmbBox.TextChanged += ResetBackground;

            TrackNameTxtBox.Text = _musicTrack.TrackName;
            TrackAuthorTxtBox.Text = _musicTrack.TrackAuthor;
            GenreCmbBox.DataSource = GenresRepo.GetAll();
            PlaylistCmbBox.DataSource = PlaylistsRepo.GetAll(_musicTrack.UploadUserId);

            GenreCmbBox.DisplayMember = "GenreName";
            GenreCmbBox.ValueMember = "GenreId";

            PlaylistCmbBox.DisplayMember = "PlaylistName";
            PlaylistCmbBox.ValueMember = "PlaylistId";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (TrackNameTxtBox.Text == string.Empty)
            {
                TrackNameTxtBox.BackColor = Color.IndianRed;
                return;
            }

            if (TrackAuthorTxtBox.Text == string.Empty)
            {
                TrackAuthorTxtBox.BackColor = Color.IndianRed;
                return;
            }

            if (GenreCmbBox.Text == string.Empty)
            {
                GenreCmbBox.BackColor = Color.IndianRed;
                return;
            }

            _musicTrack.TrackName = TrackNameTxtBox.Text;
            _musicTrack.TrackAuthor = TrackAuthorTxtBox.Text;
            _musicTrack.GenreId = GenresRepo.GetByName(GenreCmbBox.Text).GenreId;
            if (PlaylistCmbBox.Text != string.Empty)
            {
                var playlist = PlaylistsRepo.GetById((int) PlaylistCmbBox.SelectedValue);
                playlist.MusicTracks.Add(_musicTrack);
                PlaylistsRepo.AddOrUpdate(playlist);
            }

            MusicTracksRepo.AddOrUpdate(_musicTrack);

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
