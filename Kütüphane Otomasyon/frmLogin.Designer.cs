namespace Kütüphane_Otomasyon
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtUsername = new RJControls.RJTextBox();
            lgnBtn = new RJControls.RJButton();
            txtPassword = new RJControls.RJTextBox();
            ogrLgnBtn = new RJControls.RJRadioButton();
            prsnLgnBtn = new RJControls.RJRadioButton();
            label1 = new Label();
            label2 = new Label();
            sgnUpBtn = new RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(459, 464);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(445, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(8, 8);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(591, 121);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 64);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BorderColor = Color.MediumSlateBlue;
            txtUsername.BorderFocusColor = Color.MediumSlateBlue;
            txtUsername.BorderRadius = 10;
            txtUsername.BorderSize = 1;
            txtUsername.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(520, 191);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(7);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.DarkGray;
            txtUsername.PlaceholderText = "Kullanıcı Adı";
            txtUsername.Size = new Size(205, 32);
            txtUsername.TabIndex = 5;
            txtUsername.Texts = "";
            txtUsername.UnderlinedStyle = false;
            // 
            // lgnBtn
            // 
            lgnBtn.BackColor = Color.MediumSlateBlue;
            lgnBtn.BackgroundColor = Color.MediumSlateBlue;
            lgnBtn.BorderColor = Color.PaleVioletRed;
            lgnBtn.BorderRadius = 15;
            lgnBtn.BorderSize = 0;
            lgnBtn.FlatAppearance.BorderSize = 0;
            lgnBtn.FlatStyle = FlatStyle.Flat;
            lgnBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lgnBtn.ForeColor = Color.White;
            lgnBtn.Location = new Point(520, 321);
            lgnBtn.Name = "lgnBtn";
            lgnBtn.Size = new Size(205, 40);
            lgnBtn.TabIndex = 6;
            lgnBtn.Text = "Giriş Yap";
            lgnBtn.TextColor = Color.White;
            lgnBtn.UseVisualStyleBackColor = false;
            lgnBtn.Click += lgnBtn_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderColor = Color.MediumSlateBlue;
            txtPassword.BorderFocusColor = Color.Navy;
            txtPassword.BorderRadius = 10;
            txtPassword.BorderSize = 1;
            txtPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(520, 229);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(10, 7, 10, 7);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "Şifre";
            txtPassword.Size = new Size(205, 32);
            txtPassword.TabIndex = 7;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = false;
            // 
            // ogrLgnBtn
            // 
            ogrLgnBtn.AutoSize = true;
            ogrLgnBtn.CheckedColor = Color.MediumSlateBlue;
            ogrLgnBtn.Location = new Point(537, 267);
            ogrLgnBtn.MinimumSize = new Size(0, 21);
            ogrLgnBtn.Name = "ogrLgnBtn";
            ogrLgnBtn.Padding = new Padding(10, 0, 0, 0);
            ogrLgnBtn.Size = new Size(80, 21);
            ogrLgnBtn.TabIndex = 8;
            ogrLgnBtn.TabStop = true;
            ogrLgnBtn.Text = "Kullanıcı";
            ogrLgnBtn.UnCheckedColor = Color.Gray;
            ogrLgnBtn.UseVisualStyleBackColor = true;
            ogrLgnBtn.CheckedChanged += ogrLgnBtn_CheckedChanged;
            // 
            // prsnLgnBtn
            // 
            prsnLgnBtn.AutoSize = true;
            prsnLgnBtn.CheckedColor = Color.MediumSlateBlue;
            prsnLgnBtn.Location = new Point(537, 294);
            prsnLgnBtn.MinimumSize = new Size(0, 21);
            prsnLgnBtn.Name = "prsnLgnBtn";
            prsnLgnBtn.Padding = new Padding(10, 0, 0, 0);
            prsnLgnBtn.Size = new Size(80, 21);
            prsnLgnBtn.TabIndex = 9;
            prsnLgnBtn.TabStop = true;
            prsnLgnBtn.Text = "Personel";
            prsnLgnBtn.UnCheckedColor = Color.Gray;
            prsnLgnBtn.UseVisualStyleBackColor = true;
            prsnLgnBtn.CheckedChanged += prsnLgnBtn_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(570, 30);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 10;
            label1.Text = "Hoşgeldin!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(561, 52);
            label2.Name = "label2";
            label2.Size = new Size(123, 13);
            label2.TabIndex = 11;
            label2.Text = "İlerlemek için giriş yap.";
            // 
            // sgnUpBtn
            // 
            sgnUpBtn.BackColor = Color.DarkSeaGreen;
            sgnUpBtn.BackgroundColor = Color.DarkSeaGreen;
            sgnUpBtn.BorderColor = Color.PaleVioletRed;
            sgnUpBtn.BorderRadius = 15;
            sgnUpBtn.BorderSize = 0;
            sgnUpBtn.FlatAppearance.BorderSize = 0;
            sgnUpBtn.FlatStyle = FlatStyle.Flat;
            sgnUpBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sgnUpBtn.ForeColor = Color.Black;
            sgnUpBtn.Location = new Point(520, 367);
            sgnUpBtn.Name = "sgnUpBtn";
            sgnUpBtn.Size = new Size(205, 40);
            sgnUpBtn.TabIndex = 12;
            sgnUpBtn.Text = "KayıtOl";
            sgnUpBtn.TextColor = Color.Black;
            sgnUpBtn.UseVisualStyleBackColor = false;
            sgnUpBtn.Click += sgnUpBtn_Clck;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sgnUpBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(prsnLgnBtn);
            Controls.Add(ogrLgnBtn);
            Controls.Add(txtPassword);
            Controls.Add(lgnBtn);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gündoğru Turizm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private RJControls.RJTextBox txtUsername;
        private RJControls.RJButton lgnBtn;
        private RJControls.RJTextBox txtPassword;
        private RJControls.RJRadioButton ogrLgnBtn;
        private RJControls.RJRadioButton prsnLgnBtn;
        private Label label1;
        private Label label2;
        private RJControls.RJButton sgnUpBtn;
    }
}