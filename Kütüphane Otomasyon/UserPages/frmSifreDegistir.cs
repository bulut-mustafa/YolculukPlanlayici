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
    public partial class frmSifreDegistir : Form
    {
        cSqlConn sConn = new cSqlConn();

        DataRow _userRow;
        public frmSifreDegistir(DataRow userRow)
        {
            InitializeComponent();
            _userRow = userRow;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(txtNew.Texts != txtCheck.Texts)
            {
                MessageBox.Show("Şifreler eşleşmedi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtOld.Texts != _userRow[2].ToString())
            {
                MessageBox.Show("Eski şifre eşleşmedi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (MessageBox.Show("Şifre değiştirmek istediğinizden emin misiniz ?", "ŞİFRE DEĞİŞTİRME İŞLEMİ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(sConn.conString))
                    {
                        con.Open();
                        string query = "Update users SET pass=@newPass where id=@userID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@userID", Int32.Parse(_userRow[0].ToString()));
                            cmd.Parameters.AddWithValue("@newPass", txtNew.Texts);

                            // Execute the command
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Şifre değiştirildi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Şifre değiştirirken bir hata oluştu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
