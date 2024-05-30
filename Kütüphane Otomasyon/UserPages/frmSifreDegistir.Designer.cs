namespace Kütüphane_Otomasyon.UserPages
{
    partial class frmSifreDegistir
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
            txtOld = new RJControls.RJTextBox();
            txtNew = new RJControls.RJTextBox();
            txtCheck = new RJControls.RJTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnChange = new RJControls.RJButton();
            SuspendLayout();
            // 
            // txtOld
            // 
            txtOld.BackColor = SystemColors.Window;
            txtOld.BorderColor = Color.MediumSlateBlue;
            txtOld.BorderFocusColor = Color.HotPink;
            txtOld.BorderRadius = 0;
            txtOld.BorderSize = 2;
            txtOld.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtOld.ForeColor = Color.DimGray;
            txtOld.Location = new Point(64, 36);
            txtOld.Multiline = false;
            txtOld.Name = "txtOld";
            txtOld.Padding = new Padding(10, 7, 10, 7);
            txtOld.PasswordChar = false;
            txtOld.PlaceholderColor = Color.DarkGray;
            txtOld.PlaceholderText = "";
            txtOld.Size = new Size(175, 32);
            txtOld.TabIndex = 0;
            txtOld.Texts = "";
            txtOld.UnderlinedStyle = false;
            // 
            // txtNew
            // 
            txtNew.BackColor = SystemColors.Window;
            txtNew.BorderColor = Color.MediumSlateBlue;
            txtNew.BorderFocusColor = Color.HotPink;
            txtNew.BorderRadius = 0;
            txtNew.BorderSize = 2;
            txtNew.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNew.ForeColor = Color.DimGray;
            txtNew.Location = new Point(64, 74);
            txtNew.Multiline = false;
            txtNew.Name = "txtNew";
            txtNew.Padding = new Padding(10, 7, 10, 7);
            txtNew.PasswordChar = false;
            txtNew.PlaceholderColor = Color.DarkGray;
            txtNew.PlaceholderText = "";
            txtNew.Size = new Size(175, 32);
            txtNew.TabIndex = 1;
            txtNew.Texts = "";
            txtNew.UnderlinedStyle = false;
            // 
            // txtCheck
            // 
            txtCheck.BackColor = SystemColors.Window;
            txtCheck.BorderColor = Color.MediumSlateBlue;
            txtCheck.BorderFocusColor = Color.HotPink;
            txtCheck.BorderRadius = 0;
            txtCheck.BorderSize = 2;
            txtCheck.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtCheck.ForeColor = Color.DimGray;
            txtCheck.Location = new Point(64, 112);
            txtCheck.Multiline = false;
            txtCheck.Name = "txtCheck";
            txtCheck.Padding = new Padding(10, 7, 10, 7);
            txtCheck.PasswordChar = false;
            txtCheck.PlaceholderColor = Color.DarkGray;
            txtCheck.PlaceholderText = "";
            txtCheck.Size = new Size(175, 32);
            txtCheck.TabIndex = 2;
            txtCheck.Texts = "";
            txtCheck.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 48);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 3;
            label1.Text = "Eski";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 86);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 4;
            label2.Text = "Yeni";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 124);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Tekrar";
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.RoyalBlue;
            btnChange.BackgroundColor = Color.RoyalBlue;
            btnChange.BorderColor = Color.PaleVioletRed;
            btnChange.BorderRadius = 10;
            btnChange.BorderSize = 0;
            btnChange.FlatAppearance.BorderSize = 0;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnChange.ForeColor = Color.White;
            btnChange.Location = new Point(64, 160);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(175, 40);
            btnChange.TabIndex = 6;
            btnChange.Text = "DEĞİŞTİR";
            btnChange.TextColor = Color.White;
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // frmSifreDegistir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 226);
            Controls.Add(btnChange);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCheck);
            Controls.Add(txtNew);
            Controls.Add(txtOld);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmSifreDegistir";
            Text = "Şifre Değiştir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RJControls.RJTextBox txtOld;
        private RJControls.RJTextBox txtNew;
        private RJControls.RJTextBox txtCheck;
        private Label label1;
        private Label label2;
        private Label label3;
        private RJControls.RJButton btnChange;
    }
}