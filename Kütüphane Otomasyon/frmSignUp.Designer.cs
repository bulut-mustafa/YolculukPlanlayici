namespace Kütüphane_Otomasyon
{
    partial class frmSignUp
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
            pictureBox3 = new PictureBox();
            txtUsername = new RJControls.RJTextBox();
            label1 = new Label();
            txtPassCheck = new RJControls.RJTextBox();
            sgnUpBtn = new RJControls.RJButton();
            label2 = new Label();
            txtName = new RJControls.RJTextBox();
            txtMail = new RJControls.RJTextBox();
            txtPassword = new RJControls.RJTextBox();
            txtLastName = new RJControls.RJTextBox();
            cmbType = new RJControls.RJComboBox();
            txtPhone = new RJControls.RJPhoneMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(126, 65);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 64);
            pictureBox3.TabIndex = 13;
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
            txtUsername.Location = new Point(22, 173);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(7);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.DarkGray;
            txtUsername.PlaceholderText = "Kullanıcı Adı";
            txtUsername.Size = new Size(257, 32);
            txtUsername.TabIndex = 14;
            txtUsername.Texts = "";
            txtUsername.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(240, 22);
            label1.TabIndex = 19;
            label1.Text = "Gündoğdu'ya Hoşgeldin!";
            // 
            // txtPassCheck
            // 
            txtPassCheck.BackColor = SystemColors.Window;
            txtPassCheck.BorderColor = Color.MediumSlateBlue;
            txtPassCheck.BorderFocusColor = Color.Navy;
            txtPassCheck.BorderRadius = 10;
            txtPassCheck.BorderSize = 1;
            txtPassCheck.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassCheck.ForeColor = Color.DimGray;
            txtPassCheck.Location = new Point(22, 323);
            txtPassCheck.Multiline = false;
            txtPassCheck.Name = "txtPassCheck";
            txtPassCheck.Padding = new Padding(10, 7, 10, 7);
            txtPassCheck.PasswordChar = true;
            txtPassCheck.PlaceholderColor = Color.DarkGray;
            txtPassCheck.PlaceholderText = "Şifre Tekrar";
            txtPassCheck.Size = new Size(257, 32);
            txtPassCheck.TabIndex = 16;
            txtPassCheck.Texts = "";
            txtPassCheck.UnderlinedStyle = false;
            // 
            // sgnUpBtn
            // 
            sgnUpBtn.BackColor = Color.MediumSlateBlue;
            sgnUpBtn.BackgroundColor = Color.MediumSlateBlue;
            sgnUpBtn.BorderColor = Color.PaleVioletRed;
            sgnUpBtn.BorderRadius = 15;
            sgnUpBtn.BorderSize = 0;
            sgnUpBtn.FlatAppearance.BorderSize = 0;
            sgnUpBtn.FlatStyle = FlatStyle.Flat;
            sgnUpBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sgnUpBtn.ForeColor = Color.White;
            sgnUpBtn.Location = new Point(43, 404);
            sgnUpBtn.Name = "sgnUpBtn";
            sgnUpBtn.Size = new Size(205, 40);
            sgnUpBtn.TabIndex = 21;
            sgnUpBtn.Text = "Kayıt Ol";
            sgnUpBtn.TextColor = Color.White;
            sgnUpBtn.UseVisualStyleBackColor = false;
            sgnUpBtn.Click += sgnUpBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(22, 49);
            label2.Name = "label2";
            label2.Size = new Size(127, 13);
            label2.TabIndex = 20;
            label2.Text = "Kayıt olmak için doldur.";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.BorderColor = Color.MediumSlateBlue;
            txtName.BorderFocusColor = Color.MediumSlateBlue;
            txtName.BorderRadius = 10;
            txtName.BorderSize = 1;
            txtName.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.DimGray;
            txtName.Location = new Point(22, 135);
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.Padding = new Padding(7);
            txtName.PasswordChar = false;
            txtName.PlaceholderColor = Color.DarkGray;
            txtName.PlaceholderText = "Ad";
            txtName.Size = new Size(132, 32);
            txtName.TabIndex = 22;
            txtName.Texts = "";
            txtName.UnderlinedStyle = false;
            // 
            // txtMail
            // 
            txtMail.BackColor = SystemColors.Window;
            txtMail.BorderColor = Color.MediumSlateBlue;
            txtMail.BorderFocusColor = Color.Navy;
            txtMail.BorderRadius = 10;
            txtMail.BorderSize = 1;
            txtMail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.ForeColor = Color.DimGray;
            txtMail.Location = new Point(22, 211);
            txtMail.Multiline = false;
            txtMail.Name = "txtMail";
            txtMail.Padding = new Padding(10, 7, 10, 7);
            txtMail.PasswordChar = false;
            txtMail.PlaceholderColor = Color.DarkGray;
            txtMail.PlaceholderText = "Mail Adresi";
            txtMail.Size = new Size(257, 32);
            txtMail.TabIndex = 23;
            txtMail.Texts = "";
            txtMail.UnderlinedStyle = false;
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
            txtPassword.Location = new Point(22, 285);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(10, 7, 10, 7);
            txtPassword.PasswordChar = true;
            txtPassword.PlaceholderColor = Color.DarkGray;
            txtPassword.PlaceholderText = "Şifre";
            txtPassword.Size = new Size(257, 32);
            txtPassword.TabIndex = 24;
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = false;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.Window;
            txtLastName.BorderColor = Color.MediumSlateBlue;
            txtLastName.BorderFocusColor = Color.MediumSlateBlue;
            txtLastName.BorderRadius = 10;
            txtLastName.BorderSize = 1;
            txtLastName.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.ForeColor = Color.DimGray;
            txtLastName.Location = new Point(160, 135);
            txtLastName.Multiline = false;
            txtLastName.Name = "txtLastName";
            txtLastName.Padding = new Padding(7);
            txtLastName.PasswordChar = false;
            txtLastName.PlaceholderColor = Color.DarkGray;
            txtLastName.PlaceholderText = "Soyad";
            txtLastName.Size = new Size(119, 32);
            txtLastName.TabIndex = 26;
            txtLastName.Texts = "";
            txtLastName.UnderlinedStyle = false;
            // 
            // cmbType
            // 
            cmbType.AutoCompleteCustomSource.AddRange(new string[] { "Öğrenci", "Normal" });
            cmbType.BackColor = Color.WhiteSmoke;
            cmbType.BorderColor = Color.MediumSlateBlue;
            cmbType.BorderSize = 1;
            cmbType.DropDownStyle = ComboBoxStyle.DropDown;
            cmbType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbType.ForeColor = Color.DimGray;
            cmbType.IconColor = Color.MediumSlateBlue;
            cmbType.Items.AddRange(new object[] { "Öğrenci", "Normal" });
            cmbType.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbType.ListTextColor = Color.DimGray;
            cmbType.Location = new Point(22, 361);
            cmbType.MinimumSize = new Size(200, 30);
            cmbType.Name = "cmbType";
            cmbType.Padding = new Padding(1);
            cmbType.Size = new Size(257, 30);
            cmbType.TabIndex = 28;
            cmbType.Texts = "Kullanıcı Türü";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Window;
            txtPhone.BorderColor = Color.MediumSlateBlue;
            txtPhone.BorderFocusColor = Color.Navy;
            txtPhone.BorderRadius = 10;
            txtPhone.BorderSize = 1;
            txtPhone.Location = new Point(22, 249);
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.Padding = new Padding(10, 7, 10, 7);
            txtPhone.PlaceholderColor = Color.DarkGray;
            txtPhone.PlaceholderText = "";
            txtPhone.Size = new Size(257, 30);
            txtPhone.TabIndex = 29;
            txtPhone.Texts = "(   )    -";
            txtPhone.UnderlinedStyle = false;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 460);
            Controls.Add(txtPhone);
            Controls.Add(cmbType);
            Controls.Add(txtLastName);
            Controls.Add(txtPassword);
            Controls.Add(txtMail);
            Controls.Add(txtName);
            Controls.Add(sgnUpBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassCheck);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox3);
            Name = "frmSignUp";
            Text = "frmSignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private RJControls.RJTextBox txtUsername;
        private Label label1;
        private RJControls.RJTextBox txtPassCheck;
        private RJControls.RJButton sgnUpBtn;
        private Label label2;
        private RJControls.RJTextBox txtName;
        private RJControls.RJTextBox txtMail;
        private RJControls.RJTextBox txtPassword;
        private RJControls.RJTextBox txtLastName;
        private RJControls.RJComboBox cmbType;
        private RJControls.RJPhoneMaskedTextBox txtPhone;
    }
}