namespace CorpApp_lab2.Forms
{
    partial class AddPlaylistForm
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
            this.PlaylistNameTxtBox = new System.Windows.Forms.TextBox();
            this.AddPlaylistBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlaylistNameTxtBox
            // 
            this.PlaylistNameTxtBox.Location = new System.Drawing.Point(22, 23);
            this.PlaylistNameTxtBox.Name = "PlaylistNameTxtBox";
            this.PlaylistNameTxtBox.Size = new System.Drawing.Size(274, 20);
            this.PlaylistNameTxtBox.TabIndex = 1;
            // 
            // AddPlaylistBtn
            // 
            this.AddPlaylistBtn.Location = new System.Drawing.Point(98, 65);
            this.AddPlaylistBtn.Name = "AddPlaylistBtn";
            this.AddPlaylistBtn.Size = new System.Drawing.Size(121, 23);
            this.AddPlaylistBtn.TabIndex = 2;
            this.AddPlaylistBtn.Text = "Сохранить";
            this.AddPlaylistBtn.UseVisualStyleBackColor = true;
            this.AddPlaylistBtn.Click += new System.EventHandler(this.AddPlaylistBtn_Click);
            // 
            // AddPlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 117);
            this.Controls.Add(this.AddPlaylistBtn);
            this.Controls.Add(this.PlaylistNameTxtBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPlaylistForm";
            this.Text = "AddPlaylistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PlaylistNameTxtBox;
        private System.Windows.Forms.Button AddPlaylistBtn;
    }
}