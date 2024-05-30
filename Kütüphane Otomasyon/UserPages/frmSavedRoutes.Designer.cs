namespace Kütüphane_Otomasyon.UserPages
{
    partial class frmSavedRoutes
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
            label1 = new Label();
            dgvSavedRoutes = new DataGridView();
            btnDelete = new RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)dgvSavedRoutes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 4;
            label1.Text = "Kayıtlı Rotalarım";
            // 
            // dgvSavedRoutes
            // 
            dgvSavedRoutes.AllowUserToAddRows = false;
            dgvSavedRoutes.AllowUserToDeleteRows = false;
            dgvSavedRoutes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSavedRoutes.Location = new Point(0, 70);
            dgvSavedRoutes.Name = "dgvSavedRoutes";
            dgvSavedRoutes.RowTemplate.Height = 25;
            dgvSavedRoutes.Size = new Size(797, 150);
            dgvSavedRoutes.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MediumSlateBlue;
            btnDelete.BackgroundColor = Color.MediumSlateBlue;
            btnDelete.BorderColor = Color.PaleVioletRed;
            btnDelete.BorderRadius = 20;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(12, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 37);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Rotayı Sil";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmSavedRoutes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(dgvSavedRoutes);
            Name = "frmSavedRoutes";
            Text = "frmSavedRoutes";
            Load += frmSavedRoutes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSavedRoutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dgvSavedRoutes;
        private RJControls.RJButton btnDelete;
    }
}