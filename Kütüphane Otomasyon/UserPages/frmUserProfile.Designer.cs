namespace Kütüphane_Otomasyon.UserPages
{
    partial class frmUserProfile
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
            deleteBtn = new RJControls.RJButton();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            lbl = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblType = new Label();
            lblUsername = new Label();
            btnChangePassword = new RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Red;
            deleteBtn.BackgroundColor = Color.Red;
            deleteBtn.BorderColor = Color.PaleVioletRed;
            deleteBtn.BorderRadius = 15;
            deleteBtn.BorderSize = 0;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(24, 391);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(205, 40);
            deleteBtn.TabIndex = 35;
            deleteBtn.Text = "Hesabı Sil";
            deleteBtn.TextColor = Color.White;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(144, 22);
            label1.TabIndex = 33;
            label1.Text = "Kullanıcı Bilgileri";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(12, 60);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 64);
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(12, 147);
            lbl.Name = "lbl";
            lbl.Size = new Size(80, 20);
            lbl.TabIndex = 42;
            lbl.Text = "Ad Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 44;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 268);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 47;
            label4.Text = "Kullanıcı Adı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 238);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 46;
            label5.Text = "Kullanıcı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 208);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 45;
            label6.Text = "Telefon :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(110, 147);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 48;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(110, 147);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 20);
            lblName.TabIndex = 49;
            lblName.Text = "Ad Soyad :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(110, 177);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 20);
            lblEmail.TabIndex = 51;
            lblEmail.Text = "Ad Soyad :";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.Location = new Point(110, 208);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(80, 20);
            lblPhone.TabIndex = 52;
            lblPhone.Text = "Ad Soyad :";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblType.Location = new Point(110, 238);
            lblType.Name = "lblType";
            lblType.Size = new Size(80, 20);
            lblType.TabIndex = 53;
            lblType.Text = "Ad Soyad :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(110, 268);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 54;
            lblUsername.Text = "Ad Soyad :";
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.SeaGreen;
            btnChangePassword.BackgroundColor = Color.SeaGreen;
            btnChangePassword.BorderColor = Color.PaleVioletRed;
            btnChangePassword.BorderRadius = 15;
            btnChangePassword.BorderSize = 0;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(24, 345);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(205, 40);
            btnChangePassword.TabIndex = 60;
            btnChangePassword.Text = "Şifre Değiştir";
            btnChangePassword.TextColor = Color.White;
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // frmUserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 460);
            Controls.Add(btnChangePassword);
            Controls.Add(lblUsername);
            Controls.Add(lblType);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(lbl);
            Controls.Add(deleteBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Name = "frmUserProfile";
            Text = "frmUserProfile";
            Load += frmUserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RJControls.RJComboBox cmbType;
        private RJControls.RJButton deleteBtn;
        private Label label1;
        private PictureBox pictureBox3;
        private Label lbl;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblType;
        private Label lblUsername;
        private RJControls.RJButton btnChangePassword;
    }
}