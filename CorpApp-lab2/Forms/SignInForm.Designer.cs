namespace CorpApp_lab2.Forms
{
    partial class SignInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FullNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя в системе";
            // 
            // FullNameTxtBox
            // 
            this.FullNameTxtBox.Location = new System.Drawing.Point(130, 26);
            this.FullNameTxtBox.Name = "FullNameTxtBox";
            this.FullNameTxtBox.Size = new System.Drawing.Size(241, 20);
            this.FullNameTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин";
            // 
            // LoginTxtBox
            // 
            this.LoginTxtBox.Location = new System.Drawing.Point(130, 64);
            this.LoginTxtBox.Name = "LoginTxtBox";
            this.LoginTxtBox.Size = new System.Drawing.Size(241, 20);
            this.LoginTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пароль еще раз";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(130, 109);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(241, 20);
            this.PasswordTxtBox.TabIndex = 6;
            // 
            // ConfirmPasswordTxtBox
            // 
            this.ConfirmPasswordTxtBox.Location = new System.Drawing.Point(130, 135);
            this.ConfirmPasswordTxtBox.Name = "ConfirmPasswordTxtBox";
            this.ConfirmPasswordTxtBox.PasswordChar = '*';
            this.ConfirmPasswordTxtBox.Size = new System.Drawing.Size(241, 20);
            this.ConfirmPasswordTxtBox.TabIndex = 7;
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(34, 176);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(337, 23);
            this.signInBtn.TabIndex = 8;
            this.signInBtn.Text = "Зарегистрироваться";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 228);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.ConfirmPasswordTxtBox);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullNameTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTxtBox;
        private System.Windows.Forms.Button signInBtn;
    }
}