using CorpApp_lab2.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CorpApp_lab2.Forms
{
    public partial class AddPlaylistForm : Form
    {
        private readonly Playlist _playlist;

        public AddPlaylistForm(Playlist playlist)
        {
            InitializeComponent();

            _playlist = playlist;

            PlaylistNameTxtBox.Text = _playlist.PlaylistName;

            PlaylistNameTxtBox.TextChanged += ResetBackground;
        }

        private void AddPlaylistBtn_Click(object sender, EventArgs e)
        {
            if (PlaylistNameTxtBox.Text != string.Empty)
            {
                _playlist.PlaylistName = PlaylistNameTxtBox.Text;
                PlaylistsRepo.AddOrUpdate(_playlist);
                DialogResult = DialogResult.OK;
                Close();
            }               
            else PlaylistNameTxtBox.BackColor = Color.IndianRed;
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
