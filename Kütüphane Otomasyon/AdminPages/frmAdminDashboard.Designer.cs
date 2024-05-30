namespace Kütüphane_Otomasyon.AdminPages
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            KALKIŞ = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtkalkisYeri = new RJControls.RJTextBox();
            eklebtn = new RJControls.RJButton();
            silbtn = new RJControls.RJButton();
            düzenlebtn = new RJControls.RJButton();
            TxtvarisYeri = new RJControls.RJTextBox();
            Txtsüre = new RJControls.RJTextBox();
            Txtfiyat = new RJControls.RJTextBox();
            CmdyolculukTürü = new RJControls.RJComboBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            rjButton1 = new RJControls.RJButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // KALKIŞ
            // 
            KALKIŞ.AutoSize = true;
            KALKIŞ.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            KALKIŞ.Location = new Point(12, 32);
            KALKIŞ.Name = "KALKIŞ";
            KALKIŞ.Size = new Size(70, 25);
            KALKIŞ.TabIndex = 0;
            KALKIŞ.Text = "KALKIŞ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(159, 32);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 6;
            label1.Text = "VARIŞ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 132);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 7;
            label2.Text = "YOLCULUK TÜRÜ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 20);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(461, 32);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 9;
            label4.Text = "SÜRE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(306, 32);
            label5.Name = "label5";
            label5.Size = new Size(57, 25);
            label5.TabIndex = 10;
            label5.Text = "FİYAT";
            // 
            // TxtkalkisYeri
            // 
            TxtkalkisYeri.BackColor = SystemColors.Window;
            TxtkalkisYeri.BorderColor = Color.MediumSlateBlue;
            TxtkalkisYeri.BorderFocusColor = Color.HotPink;
            TxtkalkisYeri.BorderRadius = 10;
            TxtkalkisYeri.BorderSize = 2;
            TxtkalkisYeri.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtkalkisYeri.ForeColor = Color.DimGray;
            TxtkalkisYeri.Location = new Point(12, 60);
            TxtkalkisYeri.Multiline = false;
            TxtkalkisYeri.Name = "TxtkalkisYeri";
            TxtkalkisYeri.Padding = new Padding(10, 7, 10, 7);
            TxtkalkisYeri.PasswordChar = false;
            TxtkalkisYeri.PlaceholderColor = Color.DarkGray;
            TxtkalkisYeri.PlaceholderText = "";
            TxtkalkisYeri.Size = new Size(131, 40);
            TxtkalkisYeri.TabIndex = 14;
            TxtkalkisYeri.Texts = "";
            TxtkalkisYeri.UnderlinedStyle = false;
            // 
            // eklebtn
            // 
            eklebtn.BackColor = Color.MediumSlateBlue;
            eklebtn.BackgroundColor = Color.MediumSlateBlue;
            eklebtn.BorderColor = Color.PaleVioletRed;
            eklebtn.BorderRadius = 20;
            eklebtn.BorderSize = 0;
            eklebtn.FlatAppearance.BorderSize = 0;
            eklebtn.FlatStyle = FlatStyle.Flat;
            eklebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            eklebtn.ForeColor = Color.White;
            eklebtn.Location = new Point(12, 226);
            eklebtn.Name = "eklebtn";
            eklebtn.Size = new Size(117, 49);
            eklebtn.TabIndex = 15;
            eklebtn.Text = "Ekle";
            eklebtn.TextColor = Color.White;
            eklebtn.UseVisualStyleBackColor = false;
            eklebtn.Click += eklebtn_Click;
            // 
            // silbtn
            // 
            silbtn.BackColor = Color.MediumSlateBlue;
            silbtn.BackgroundColor = Color.MediumSlateBlue;
            silbtn.BorderColor = Color.PaleVioletRed;
            silbtn.BorderRadius = 20;
            silbtn.BorderSize = 0;
            silbtn.FlatAppearance.BorderSize = 0;
            silbtn.FlatStyle = FlatStyle.Flat;
            silbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            silbtn.ForeColor = Color.White;
            silbtn.Location = new Point(247, 226);
            silbtn.Name = "silbtn";
            silbtn.Size = new Size(113, 49);
            silbtn.TabIndex = 16;
            silbtn.Text = "Sil";
            silbtn.TextColor = Color.White;
            silbtn.UseVisualStyleBackColor = false;
            silbtn.Click += silbtn_Click;
            // 
            // düzenlebtn
            // 
            düzenlebtn.BackColor = Color.MediumSlateBlue;
            düzenlebtn.BackgroundColor = Color.MediumSlateBlue;
            düzenlebtn.BorderColor = Color.PaleVioletRed;
            düzenlebtn.BorderRadius = 20;
            düzenlebtn.BorderSize = 0;
            düzenlebtn.FlatAppearance.BorderSize = 0;
            düzenlebtn.FlatStyle = FlatStyle.Flat;
            düzenlebtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            düzenlebtn.ForeColor = Color.White;
            düzenlebtn.Location = new Point(135, 226);
            düzenlebtn.Name = "düzenlebtn";
            düzenlebtn.Size = new Size(106, 49);
            düzenlebtn.TabIndex = 17;
            düzenlebtn.Text = "Düzenle";
            düzenlebtn.TextColor = Color.White;
            düzenlebtn.UseVisualStyleBackColor = false;
            düzenlebtn.Click += düzenlebtn_Click;
            // 
            // TxtvarisYeri
            // 
            TxtvarisYeri.BackColor = SystemColors.Window;
            TxtvarisYeri.BorderColor = Color.MediumSlateBlue;
            TxtvarisYeri.BorderFocusColor = Color.HotPink;
            TxtvarisYeri.BorderRadius = 10;
            TxtvarisYeri.BorderSize = 2;
            TxtvarisYeri.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtvarisYeri.ForeColor = Color.DimGray;
            TxtvarisYeri.Location = new Point(159, 60);
            TxtvarisYeri.Multiline = false;
            TxtvarisYeri.Name = "TxtvarisYeri";
            TxtvarisYeri.Padding = new Padding(10, 7, 10, 7);
            TxtvarisYeri.PasswordChar = false;
            TxtvarisYeri.PlaceholderColor = Color.DarkGray;
            TxtvarisYeri.PlaceholderText = "";
            TxtvarisYeri.Size = new Size(131, 40);
            TxtvarisYeri.TabIndex = 18;
            TxtvarisYeri.Texts = "";
            TxtvarisYeri.UnderlinedStyle = false;
            // 
            // Txtsüre
            // 
            Txtsüre.BackColor = SystemColors.Window;
            Txtsüre.BorderColor = Color.MediumSlateBlue;
            Txtsüre.BorderFocusColor = Color.HotPink;
            Txtsüre.BorderRadius = 10;
            Txtsüre.BorderSize = 2;
            Txtsüre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Txtsüre.ForeColor = Color.DimGray;
            Txtsüre.Location = new Point(452, 60);
            Txtsüre.Multiline = false;
            Txtsüre.Name = "Txtsüre";
            Txtsüre.Padding = new Padding(10, 7, 10, 7);
            Txtsüre.PasswordChar = false;
            Txtsüre.PlaceholderColor = Color.DarkGray;
            Txtsüre.PlaceholderText = "";
            Txtsüre.Size = new Size(106, 40);
            Txtsüre.TabIndex = 20;
            Txtsüre.Texts = "";
            Txtsüre.UnderlinedStyle = false;
            // 
            // Txtfiyat
            // 
            Txtfiyat.BackColor = SystemColors.Window;
            Txtfiyat.BorderColor = Color.MediumSlateBlue;
            Txtfiyat.BorderFocusColor = Color.HotPink;
            Txtfiyat.BorderRadius = 10;
            Txtfiyat.BorderSize = 2;
            Txtfiyat.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Txtfiyat.ForeColor = Color.DimGray;
            Txtfiyat.Location = new Point(306, 60);
            Txtfiyat.Multiline = false;
            Txtfiyat.Name = "Txtfiyat";
            Txtfiyat.Padding = new Padding(10, 7, 10, 7);
            Txtfiyat.PasswordChar = false;
            Txtfiyat.PlaceholderColor = Color.DarkGray;
            Txtfiyat.PlaceholderText = "";
            Txtfiyat.Size = new Size(131, 40);
            Txtfiyat.TabIndex = 21;
            Txtfiyat.Texts = "";
            Txtfiyat.UnderlinedStyle = false;
            // 
            // CmdyolculukTürü
            // 
            CmdyolculukTürü.BackColor = Color.WhiteSmoke;
            CmdyolculukTürü.BorderColor = Color.MediumSlateBlue;
            CmdyolculukTürü.BorderSize = 2;
            CmdyolculukTürü.DropDownStyle = ComboBoxStyle.DropDown;
            CmdyolculukTürü.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CmdyolculukTürü.ForeColor = Color.DimGray;
            CmdyolculukTürü.IconColor = Color.MediumSlateBlue;
            CmdyolculukTürü.Items.AddRange(new object[] { "Deniz Yolu", "Otobüs", "Uçak", "Özel Araç" });
            CmdyolculukTürü.ListBackColor = Color.FromArgb(230, 228, 245);
            CmdyolculukTürü.ListTextColor = Color.DimGray;
            CmdyolculukTürü.Location = new Point(12, 160);
            CmdyolculukTürü.MinimumSize = new Size(150, 30);
            CmdyolculukTürü.Name = "CmdyolculukTürü";
            CmdyolculukTürü.Padding = new Padding(2);
            CmdyolculukTürü.Size = new Size(150, 40);
            CmdyolculukTürü.TabIndex = 22;
            CmdyolculukTürü.Texts = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(573, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(rjButton1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(CmdyolculukTürü);
            panel1.Controls.Add(Txtfiyat);
            panel1.Controls.Add(Txtsüre);
            panel1.Controls.Add(TxtvarisYeri);
            panel1.Controls.Add(düzenlebtn);
            panel1.Controls.Add(silbtn);
            panel1.Controls.Add(eklebtn);
            panel1.Controls.Add(TxtkalkisYeri);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(KALKIŞ);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 301);
            panel1.TabIndex = 0;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.BackgroundColor = Color.MediumSlateBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(367, 226);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(107, 49);
            rjButton1.TabIndex = 24;
            rjButton1.Text = "Temizle";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 150);
            dataGridView1.TabIndex = 1;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += frmAdminDashboard_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label KALKIŞ;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private RJControls.RJButton eklebtn;
        private RJControls.RJTextBox TxtkalkisYeri;
        private RJControls.RJButton düzenlebtn;
        private RJControls.RJButton silbtn;
        private RJControls.RJTextBox TxtvarisYeri;
        private RJControls.RJTextBox Txtfiyat;
        private RJControls.RJTextBox Txtsüre;
        private RJControls.RJComboBox CmdyolculukTürü;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private RJControls.RJButton rjButton1;
    }
}