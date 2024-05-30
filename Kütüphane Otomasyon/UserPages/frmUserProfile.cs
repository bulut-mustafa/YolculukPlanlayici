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
using static System.Formats.Asn1.AsnWriter;

namespace Kütüphane_Otomasyon.UserPages
{
    public partial class frmUserProfile : Form
    {
        cSqlConn sConn = new cSqlConn();

        DataRow _userRow;
        public frmUserProfile(DataRow userRow)
        {
            InitializeComponent();
            _userRow = userRow;
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            lblName.Text = _userRow[4].ToString();
            lblEmail.Text = _userRow[3].ToString();
            lblPhone.Text = _userRow[5].ToString();
            if (Int32.Parse(_userRow[7].ToString()) == 2)
            {
                lblType.Text = "Normal";
            }
            else if(Int32.Parse(_userRow[7].ToString()) == 3)
            {
                lblType.Text = "Öğrenci";
            }
            lblUsername.Text = _userRow[1].ToString();

        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Hesabı silmek istediğinizden emin misiniz ?", "HESAP SİLME İŞLEMİ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(sConn.conString))
                    {
                        con.Open();
                        string query = "DELETE FROM users Where id=@userID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@userID", Int32.Parse(_userRow[0].ToString()));
                            // Execute the command
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Hesap Silindi. Uygulama Kapanacak.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Exit();
                            }
                            else
                            {
                                MessageBox.Show("Hesap silinirken bir hata oluştu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmSifreDegistir frmSifreDegistir = new frmSifreDegistir(_userRow);
            frmSifreDegistir.Show();
        }
    }
}
