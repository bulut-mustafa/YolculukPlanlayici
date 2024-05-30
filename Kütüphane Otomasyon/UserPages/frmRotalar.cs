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
    public partial class frmRotalar : Form
    {
        cSqlConn sConn = new cSqlConn();
        private DataTable _routes;
        private DataRow _userRow;
        public frmRotalar(DataTable routes , DataRow userRow)
        {
            InitializeComponent();
            _routes = routes;
            _userRow = userRow;
        }

        private void frmRotalar_Load(object sender, EventArgs e)
        {
            
            dgvRoutes.DataSource = _routes;
            
        }
        
        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(dgvRoutes.CurrentRow.Cells[1].Value.ToString() + " - " + dgvRoutes.CurrentRow.Cells[2].Value.ToString() + " rotasını kaydetmek istiyor musunuz?", "ROTA KAYIT İŞLEMİ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(sConn.conString))
                    {
                        con.Open();
                        string query = "INSERT INTO userRoutes (userID, routeID) VALUES (@userID, @routeID)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@userID", Int32.Parse(_userRow[0].ToString()));
                            cmd.Parameters.AddWithValue("@routeID", Int32.Parse(dgvRoutes.CurrentRow.Cells[0].Value.ToString()));
                            // Execute the command
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Rota başarıyla kaydedildi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Rota kaydedilirken bir hata oluştu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
