namespace CorpApp_lab2.Forms
{
    partial class MusicTrackForm
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
            this.TrackNameTxtBox = new System.Windows.Forms.TextBox();
            this.TrackAuthorTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenreCmbBox = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PlaylistCmbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TrackNameTxtBox
            // 
            this.TrackNameTxtBox.Location = new System.Drawing.Point(156, 26);
            this.TrackNameTxtBox.Name = "TrackNameTxtBox";
            this.TrackNameTxtBox.Size = new System.Drawing.Size(177, 20);
            this.TrackNameTxtBox.TabIndex = 0;
            // 
            // TrackAuthorTxtBox
            // 
            this.TrackAuthorTxtBox.Location = new System.Drawing.Point(156, 68);
            this.TrackAuthorTxtBox.Name = "TrackAuthorTxtBox";
            this.TrackAuthorTxtBox.Size = new System.Drawing.Size(177, 20);
            this.TrackAuthorTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название трека";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Автор(ы) трека";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Жанр";
            // 
            // GenreCmbBox
            // 
            this.GenreCmbBox.FormattingEnabled = true;
            this.GenreCmbBox.Location = new System.Drawing.Point(154, 110);
            this.GenreCmbBox.Name = "GenreCmbBox";
            this.GenreCmbBox.Size = new System.Drawing.Size(179, 21);
            this.GenreCmbBox.TabIndex = 5;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(83, 213);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(162, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Плейлист";
            // 
            // PlaylistCmbBox
            // 
            this.PlaylistCmbBox.FormattingEnabled = true;
            this.PlaylistCmbBox.Location = new System.Drawing.Point(154, 153);
            this.PlaylistCmbBox.Name = "PlaylistCmbBox";
            this.PlaylistCmbBox.Size = new System.Drawing.Size(179, 21);
            this.PlaylistCmbBox.TabIndex = 8;
            // 
            // MusicTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 258);
            this.Controls.Add(this.PlaylistCmbBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.GenreCmbBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackAuthorTxtBox);
            this.Controls.Add(this.TrackNameTxtBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusicTrackForm";
            this.Text = "MusicTrackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TrackNameTxtBox;
        private System.Windows.Forms.TextBox TrackAuthorTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GenreCmbBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PlaylistCmbBox;
    }
}