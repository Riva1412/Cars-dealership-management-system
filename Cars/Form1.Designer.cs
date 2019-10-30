namespace Login_panal
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.createAccBtn = new System.Windows.Forms.Button();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.resetPassBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.googleImg = new System.Windows.Forms.PictureBox();
            this.facebookImg = new System.Windows.Forms.PictureBox();
            this.rememberMeCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.googleImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookImg)).BeginInit();
            this.SuspendLayout();
            // 
            // createAccBtn
            // 
            this.createAccBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccBtn.ForeColor = System.Drawing.Color.White;
            this.createAccBtn.Image = ((System.Drawing.Image)(resources.GetObject("createAccBtn.Image")));
            this.createAccBtn.Location = new System.Drawing.Point(43, 123);
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Size = new System.Drawing.Size(183, 46);
            this.createAccBtn.TabIndex = 3;
            this.createAccBtn.Text = "Create account";
            this.createAccBtn.UseVisualStyleBackColor = true;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtBox.Location = new System.Drawing.Point(574, 125);
            this.emailTxtBox.MaxLength = 50;
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(318, 23);
            this.emailTxtBox.TabIndex = 0;
            // 
            // resetPassBtn
            // 
            this.resetPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetPassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassBtn.ForeColor = System.Drawing.Color.White;
            this.resetPassBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetPassBtn.Image")));
            this.resetPassBtn.Location = new System.Drawing.Point(43, 201);
            this.resetPassBtn.Name = "resetPassBtn";
            this.resetPassBtn.Size = new System.Drawing.Size(183, 46);
            this.resetPassBtn.TabIndex = 4;
            this.resetPassBtn.Text = "Reset password";
            this.resetPassBtn.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.Control;
            this.loginBtn.Location = new System.Drawing.Point(777, 410);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(164, 46);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(574, 189);
            this.passwordTxtBox.MaxLength = 100;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(318, 23);
            this.passwordTxtBox.TabIndex = 1;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(460, 119);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(95, 29);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Email :";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(411, 183);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(144, 29);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Password :";
            // 
            // googleImg
            // 
            this.googleImg.BackColor = System.Drawing.Color.Transparent;
            this.googleImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.googleImg.Image = ((System.Drawing.Image)(resources.GetObject("googleImg.Image")));
            this.googleImg.Location = new System.Drawing.Point(139, 410);
            this.googleImg.Name = "googleImg";
            this.googleImg.Size = new System.Drawing.Size(68, 66);
            this.googleImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.googleImg.TabIndex = 7;
            this.googleImg.TabStop = false;
            // 
            // facebookImg
            // 
            this.facebookImg.BackColor = System.Drawing.Color.Transparent;
            this.facebookImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.facebookImg.Image = ((System.Drawing.Image)(resources.GetObject("facebookImg.Image")));
            this.facebookImg.Location = new System.Drawing.Point(30, 410);
            this.facebookImg.Name = "facebookImg";
            this.facebookImg.Size = new System.Drawing.Size(69, 66);
            this.facebookImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookImg.TabIndex = 8;
            this.facebookImg.TabStop = false;
            // 
            // rememberMeCB
            // 
            this.rememberMeCB.AutoSize = true;
            this.rememberMeCB.BackColor = System.Drawing.Color.Transparent;
            this.rememberMeCB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberMeCB.ForeColor = System.Drawing.Color.Black;
            this.rememberMeCB.Location = new System.Drawing.Point(574, 235);
            this.rememberMeCB.Name = "rememberMeCB";
            this.rememberMeCB.Size = new System.Drawing.Size(128, 22);
            this.rememberMeCB.TabIndex = 9;
            this.rememberMeCB.Text = "Remember me";
            this.rememberMeCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rememberMeCB.UseVisualStyleBackColor = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 496);
            this.Controls.Add(this.rememberMeCB);
            this.Controls.Add(this.facebookImg);
            this.Controls.Add(this.googleImg);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.resetPassBtn);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.createAccBtn);
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.googleImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAccBtn;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Button resetPassBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.PictureBox googleImg;
        private System.Windows.Forms.PictureBox facebookImg;
        private System.Windows.Forms.CheckBox rememberMeCB;
    }
}

