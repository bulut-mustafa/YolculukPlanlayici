using Kütüphane_Otomasyon.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyon
{
    public partial class frmSignUp : Form
    {
        cSqlConn sConn = new cSqlConn();

        public frmSignUp()
        {
            InitializeComponent();
        }

        private void sgnUpBtn_Click(object sender, EventArgs e)
        {
            string name = txtName.Texts.Trim();
            string surname = txtLastName.Texts.Trim();
            string username = txtUsername.Texts.Trim();
            string email = txtMail.Texts.Trim();
            string phone = txtPhone.Texts.Trim();
            string password = txtPassword.Texts.Trim();
            string passCheck = txtPassCheck.Texts.Trim();
            string userType = cmbType.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(passCheck) || string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Boş alan bırakmayınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != passCheck)
            {
                MessageBox.Show("Şifre eşleşmedi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int roleID;
            if (cmbType.SelectedItem.ToString() == "Öğrenci")
            {
                roleID = 3;
            }
            else if (cmbType.SelectedItem.ToString() == "Normal")
            {
                roleID = 2;
            }
            else
            {
                MessageBox.Show("Geçerşiz kullanıcı türü.");
                return;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(sConn.conString))
                {
                    con.Open();
                    string query = "INSERT INTO users (username, pass, email, full_name, phone_number, roleID) VALUES (@Username, @Password, @Email, @FullName, @Phone, @Role)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@FullName", name + " " + surname);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Role", roleID);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Başarıyla kayıt alındı.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtName.Texts = string.Empty;
                            txtLastName.Texts = string.Empty;
                            txtUsername.Texts = string.Empty;
                            txtMail.Texts = string.Empty;
                            txtPhone.Texts = string.Empty;
                            txtPassword.Texts = string.Empty;
                            txtPassCheck.Texts = string.Empty;
                            cmbType.SelectedIndex = -1;

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kayıt olurken bir hata oluştu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
