namespace Kütüphane_Otomasyon.RJControls
{
    partial class RJPhoneMaskedTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = SystemColors.Window;
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Location = new Point(7, 10);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(230, 16);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.Click += maskedTextBox1_Click;
            maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
            maskedTextBox1.Enter += maskedTextBox1_Enter;
            maskedTextBox1.Leave += maskedTextBox1_Leave;
            maskedTextBox1.MouseEnter += maskedTextBox1_MouseEnter;
            maskedTextBox1.MouseLeave += maskedTextBox1_MouseLeave;
            // 
            // RJPhoneMaskedTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(maskedTextBox1);
            Name = "RJPhoneMaskedTextBox";
            Padding = new Padding(10, 7, 10, 7);
            Size = new Size(250, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
    }
}
