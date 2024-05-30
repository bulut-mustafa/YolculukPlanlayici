namespace Kütüphane_Otomasyon.UserPages
{
    partial class frmUserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDashboard));
            btnShowRoute = new RJControls.RJButton();
            cmbMode = new RJControls.RJComboBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            rjButton1 = new RJControls.RJButton();
            cmbDestination = new RJControls.RJComboBox();
            cmbOrigin = new RJControls.RJComboBox();
            lblWelcome = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnShowRoute
            // 
            btnShowRoute.BackColor = Color.MediumSlateBlue;
            btnShowRoute.BackgroundColor = Color.MediumSlateBlue;
            btnShowRoute.BorderColor = Color.PaleVioletRed;
            btnShowRoute.BorderRadius = 10;
            btnShowRoute.BorderSize = 0;
            btnShowRoute.FlatAppearance.BorderSize = 0;
            btnShowRoute.FlatStyle = FlatStyle.Flat;
            btnShowRoute.ForeColor = Color.White;
            btnShowRoute.Location = new Point(513, 341);
            btnShowRoute.Name = "btnShowRoute";
            btnShowRoute.Size = new Size(152, 32);
            btnShowRoute.TabIndex = 3;
            btnShowRoute.Text = "Rota Oluştur";
            btnShowRoute.TextColor = Color.White;
            btnShowRoute.UseVisualStyleBackColor = false;
            btnShowRoute.Click += btnShowRoute_Click;
            // 
            // cmbMode
            // 
            cmbMode.AutoCompleteCustomSource.AddRange(new string[] { "DRIVING", "TRANSIT", "WALKING", "BICYCLING" });
            cmbMode.BackColor = SystemColors.Window;
            cmbMode.BorderColor = Color.MediumSlateBlue;
            cmbMode.BorderSize = 1;
            cmbMode.DropDownStyle = ComboBoxStyle.DropDown;
            cmbMode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMode.ForeColor = Color.DimGray;
            cmbMode.IconColor = Color.MediumSlateBlue;
            cmbMode.Items.AddRange(new object[] { "Deniz Yolu", "Otobüs", "Uçak", "Özel Araç", "Hepsi" });
            cmbMode.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbMode.ListTextColor = Color.DimGray;
            cmbMode.Location = new Point(513, 293);
            cmbMode.MinimumSize = new Size(200, 30);
            cmbMode.Name = "cmbMode";
            cmbMode.Padding = new Padding(1);
            cmbMode.Size = new Size(200, 32);
            cmbMode.TabIndex = 4;
            cmbMode.Texts = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(513, 116);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 5;
            label1.Text = "Kalkış Yeri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(513, 184);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 8;
            label4.Text = "Varış Yeri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(513, 256);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 9;
            label2.Text = "Yolculuk Türü";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(459, 464);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(513, 277);
            label3.Name = "label3";
            label3.Size = new Size(187, 13);
            label3.TabIndex = 11;
            label3.Text = "*farklı seçenekler için hepsi seçiniz.";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.BackgroundColor = Color.MediumSlateBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(513, 379);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(152, 32);
            rjButton1.TabIndex = 12;
            rjButton1.Text = "Kayıtlı Rotalar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // cmbDestination
            // 
            cmbDestination.AutoCompleteCustomSource.AddRange(new string[] { "DRIVING", "TRANSIT", "WALKING", "BICYCLING" });
            cmbDestination.BackColor = SystemColors.Window;
            cmbDestination.BorderColor = Color.MediumSlateBlue;
            cmbDestination.BorderSize = 1;
            cmbDestination.DropDownStyle = ComboBoxStyle.DropDown;
            cmbDestination.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDestination.ForeColor = Color.DimGray;
            cmbDestination.IconColor = Color.MediumSlateBlue;
            cmbDestination.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" });
            cmbDestination.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbDestination.ListTextColor = Color.DimGray;
            cmbDestination.Location = new Point(513, 208);
            cmbDestination.MinimumSize = new Size(200, 30);
            cmbDestination.Name = "cmbDestination";
            cmbDestination.Padding = new Padding(1);
            cmbDestination.Size = new Size(200, 32);
            cmbDestination.TabIndex = 13;
            cmbDestination.Texts = "";
            // 
            // cmbOrigin
            // 
            cmbOrigin.AutoCompleteCustomSource.AddRange(new string[] { "DRIVING", "TRANSIT", "WALKING", "BICYCLING" });
            cmbOrigin.BackColor = SystemColors.Window;
            cmbOrigin.BorderColor = Color.MediumSlateBlue;
            cmbOrigin.BorderSize = 1;
            cmbOrigin.DropDownStyle = ComboBoxStyle.DropDown;
            cmbOrigin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOrigin.ForeColor = Color.DimGray;
            cmbOrigin.IconColor = Color.MediumSlateBlue;
            cmbOrigin.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" });
            cmbOrigin.ListBackColor = Color.FromArgb(230, 228, 245);
            cmbOrigin.ListTextColor = Color.DimGray;
            cmbOrigin.Location = new Point(513, 140);
            cmbOrigin.MinimumSize = new Size(200, 30);
            cmbOrigin.Name = "cmbOrigin";
            cmbOrigin.Padding = new Padding(1);
            cmbOrigin.Size = new Size(200, 32);
            cmbOrigin.TabIndex = 14;
            cmbOrigin.Texts = "";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.MediumSlateBlue;
            lblWelcome.Location = new Point(583, 54);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(88, 21);
            lblWelcome.TabIndex = 15;
            lblWelcome.Text = "Hoşgeldin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(513, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.MediumSlateBlue;
            label5.Location = new Point(529, 80);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 17;
            label5.Text = "Profil";
            // 
            // frmUserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(810, 464);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(lblWelcome);
            Controls.Add(cmbOrigin);
            Controls.Add(cmbDestination);
            Controls.Add(rjButton1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(cmbMode);
            Controls.Add(btnShowRoute);
            Name = "frmUserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboard";
            Load += frmUserDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RJControls.RJButton btnShowRoute;
        private RJControls.RJComboBox cmbMode;
        private Label label1;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private RJControls.RJButton rjButton1;
        private RJControls.RJComboBox cmbDestination;
        private RJControls.RJComboBox cmbOrigin;
        private Label lblWelcome;
        private PictureBox pictureBox2;
        private Label label5;
    }
}