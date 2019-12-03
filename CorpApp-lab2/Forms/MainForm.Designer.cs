namespace CorpApp_lab2.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TracksGridView = new System.Windows.Forms.DataGridView();
            this.searchQueryTxtBox = new System.Windows.Forms.TextBox();
            this.searchTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resetSearchBtn = new System.Windows.Forms.Button();
            this.PlaylistContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaylistsDataGridView = new System.Windows.Forms.DataGridView();
            this.CurrentUserLabel = new System.Windows.Forms.Label();
            this.UserContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.войтиСДругогоАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьДанныеПрофиляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TracksContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьТрекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьТрекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TracksGridView)).BeginInit();
            this.PlaylistContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistsDataGridView)).BeginInit();
            this.UserContextMenuStrip.SuspendLayout();
            this.TracksContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TracksGridView
            // 
            this.TracksGridView.AllowUserToAddRows = false;
            this.TracksGridView.AllowUserToDeleteRows = false;
            this.TracksGridView.AllowUserToResizeRows = false;
            this.TracksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TracksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TracksGridView.Location = new System.Drawing.Point(328, 103);
            this.TracksGridView.MultiSelect = false;
            this.TracksGridView.Name = "TracksGridView";
            this.TracksGridView.ReadOnly = true;
            this.TracksGridView.RowHeadersVisible = false;
            this.TracksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TracksGridView.Size = new System.Drawing.Size(572, 484);
            this.TracksGridView.TabIndex = 0;
            this.TracksGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TracksGridView_MouseClick);
            // 
            // searchQueryTxtBox
            // 
            this.searchQueryTxtBox.Location = new System.Drawing.Point(328, 63);
            this.searchQueryTxtBox.Name = "searchQueryTxtBox";
            this.searchQueryTxtBox.Size = new System.Drawing.Size(280, 20);
            this.searchQueryTxtBox.TabIndex = 2;
            // 
            // searchTypeCmbBox
            // 
            this.searchTypeCmbBox.FormattingEnabled = true;
            this.searchTypeCmbBox.Items.AddRange(new object[] {
            "По названию",
            "По исполнителю",
            "По жанру"});
            this.searchTypeCmbBox.Location = new System.Drawing.Point(614, 62);
            this.searchTypeCmbBox.Name = "searchTypeCmbBox";
            this.searchTypeCmbBox.Size = new System.Drawing.Size(121, 21);
            this.searchTypeCmbBox.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(741, 60);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Поиск";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск музыкальных композиций";
            // 
            // resetSearchBtn
            // 
            this.resetSearchBtn.Location = new System.Drawing.Point(823, 59);
            this.resetSearchBtn.Name = "resetSearchBtn";
            this.resetSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.resetSearchBtn.TabIndex = 6;
            this.resetSearchBtn.Text = "Сбросить";
            this.resetSearchBtn.UseVisualStyleBackColor = true;
            this.resetSearchBtn.Click += new System.EventHandler(this.resetSearchBtn_Click);
            // 
            // PlaylistContextMenuStrip
            // 
            this.PlaylistContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPlaylist,
            this.EditPlaylist,
            this.DeletePlaylist});
            this.PlaylistContextMenuStrip.Name = "PlaylistContextMenuStrip";
            this.PlaylistContextMenuStrip.Size = new System.Drawing.Size(182, 70);
            // 
            // AddPlaylist
            // 
            this.AddPlaylist.Name = "AddPlaylist";
            this.AddPlaylist.Size = new System.Drawing.Size(181, 22);
            this.AddPlaylist.Text = "Добавить плейлист";
            this.AddPlaylist.Click += new System.EventHandler(this.AddPlaylist_Click);
            // 
            // EditPlaylist
            // 
            this.EditPlaylist.Name = "EditPlaylist";
            this.EditPlaylist.Size = new System.Drawing.Size(181, 22);
            this.EditPlaylist.Text = "Редактировать";
            this.EditPlaylist.Click += new System.EventHandler(this.EditPlaylist_Click);
            // 
            // DeletePlaylist
            // 
            this.DeletePlaylist.Name = "DeletePlaylist";
            this.DeletePlaylist.Size = new System.Drawing.Size(181, 22);
            this.DeletePlaylist.Text = "Удалить";
            this.DeletePlaylist.Click += new System.EventHandler(this.DeletePlaylist_Click);
            // 
            // PlaylistsDataGridView
            // 
            this.PlaylistsDataGridView.AllowUserToAddRows = false;
            this.PlaylistsDataGridView.AllowUserToDeleteRows = false;
            this.PlaylistsDataGridView.AllowUserToResizeRows = false;
            this.PlaylistsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlaylistsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlaylistsDataGridView.Location = new System.Drawing.Point(13, 103);
            this.PlaylistsDataGridView.MultiSelect = false;
            this.PlaylistsDataGridView.Name = "PlaylistsDataGridView";
            this.PlaylistsDataGridView.ReadOnly = true;
            this.PlaylistsDataGridView.RowHeadersVisible = false;
            this.PlaylistsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlaylistsDataGridView.Size = new System.Drawing.Size(288, 484);
            this.PlaylistsDataGridView.TabIndex = 7;
            this.PlaylistsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlaylistsDataGridView_CellClick);
            this.PlaylistsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaylistsDataGridView_MouseClick);
            // 
            // CurrentUserLabel
            // 
            this.CurrentUserLabel.AutoSize = true;
            this.CurrentUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUserLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CurrentUserLabel.Location = new System.Drawing.Point(13, 13);
            this.CurrentUserLabel.Name = "CurrentUserLabel";
            this.CurrentUserLabel.Size = new System.Drawing.Size(0, 20);
            this.CurrentUserLabel.TabIndex = 8;
            this.CurrentUserLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CurrentUserLabel_MouseClick);
            // 
            // UserContextMenuStrip
            // 
            this.UserContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.войтиСДругогоАккаунтаToolStripMenuItem,
            this.редактироватьДанныеПрофиляToolStripMenuItem});
            this.UserContextMenuStrip.Name = "UserContextMenuStrip";
            this.UserContextMenuStrip.Size = new System.Drawing.Size(252, 48);
            // 
            // войтиСДругогоАккаунтаToolStripMenuItem
            // 
            this.войтиСДругогоАккаунтаToolStripMenuItem.Name = "войтиСДругогоАккаунтаToolStripMenuItem";
            this.войтиСДругогоАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.войтиСДругогоАккаунтаToolStripMenuItem.Text = "Войти с другого аккаунта";
            this.войтиСДругогоАккаунтаToolStripMenuItem.Click += new System.EventHandler(this.войтиСДругогоАккаунтаToolStripMenuItem_Click);
            // 
            // редактироватьДанныеПрофиляToolStripMenuItem
            // 
            this.редактироватьДанныеПрофиляToolStripMenuItem.Name = "редактироватьДанныеПрофиляToolStripMenuItem";
            this.редактироватьДанныеПрофиляToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.редактироватьДанныеПрофиляToolStripMenuItem.Text = "Редактировать данные профиля";
            this.редактироватьДанныеПрофиляToolStripMenuItem.Click += new System.EventHandler(this.редактироватьДанныеПрофиляToolStripMenuItem_Click);
            // 
            // TracksContextMenuStrip
            // 
            this.TracksContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТрекToolStripMenuItem,
            this.редактироватьТрекToolStripMenuItem});
            this.TracksContextMenuStrip.Name = "TracksContextMenuStrip";
            this.TracksContextMenuStrip.Size = new System.Drawing.Size(182, 48);
            // 
            // добавитьТрекToolStripMenuItem
            // 
            this.добавитьТрекToolStripMenuItem.Name = "добавитьТрекToolStripMenuItem";
            this.добавитьТрекToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.добавитьТрекToolStripMenuItem.Text = "Добавить трек";
            this.добавитьТрекToolStripMenuItem.Click += new System.EventHandler(this.добавитьТрекToolStripMenuItem_Click);
            // 
            // редактироватьТрекToolStripMenuItem
            // 
            this.редактироватьТрекToolStripMenuItem.Name = "редактироватьТрекToolStripMenuItem";
            this.редактироватьТрекToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.редактироватьТрекToolStripMenuItem.Text = "Редактировать трек";
            this.редактироватьТрекToolStripMenuItem.Click += new System.EventHandler(this.редактироватьТрекToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 599);
            this.Controls.Add(this.CurrentUserLabel);
            this.Controls.Add(this.PlaylistsDataGridView);
            this.Controls.Add(this.resetSearchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTypeCmbBox);
            this.Controls.Add(this.searchQueryTxtBox);
            this.Controls.Add(this.TracksGridView);
            this.Name = "MainForm";
            this.Text = "Аудиоплеер";
            ((System.ComponentModel.ISupportInitialize)(this.TracksGridView)).EndInit();
            this.PlaylistContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistsDataGridView)).EndInit();
            this.UserContextMenuStrip.ResumeLayout(false);
            this.TracksContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TracksGridView;
        private System.Windows.Forms.TextBox searchQueryTxtBox;
        private System.Windows.Forms.ComboBox searchTypeCmbBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetSearchBtn;
        private System.Windows.Forms.ContextMenuStrip PlaylistContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddPlaylist;
        private System.Windows.Forms.ToolStripMenuItem EditPlaylist;
        private System.Windows.Forms.ToolStripMenuItem DeletePlaylist;
        private System.Windows.Forms.DataGridView PlaylistsDataGridView;
        private System.Windows.Forms.Label CurrentUserLabel;
        private System.Windows.Forms.ContextMenuStrip UserContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem войтиСДругогоАккаунтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьДанныеПрофиляToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip TracksContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьТрекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьТрекToolStripMenuItem;
    }
}

