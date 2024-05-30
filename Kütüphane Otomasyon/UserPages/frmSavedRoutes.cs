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

namespace Kütüphane_Otomasyon.UserPages
{
    public partial class frmSavedRoutes : Form
    {
        private DataTable _routes;
        private DataRow _userRow;
        cSqlConn sConn = new cSqlConn();

        public frmSavedRoutes(DataTable routes, DataRow userRow)
        {
            InitializeComponent();
            _routes = routes;
            _userRow = userRow;
        }

        private void frmSavedRoutes_Load(object sender, EventArgs e)
        {
            dgvSavedRoutes.DataSource = _routes;
            label1.Text = _userRow[4] + " kayıtlı rotaları";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(dgvSavedRoutes.CurrentRow.Cells[1].Value.ToString() + " - " + dgvSavedRoutes.CurrentRow.Cells[2].Value.ToString() + " rotasını silmek istiyor musunuz?", "ROTA SİLME İŞLEMİ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(sConn.conString))
                    {
                        con.Open();
                        string query = "DELETE FROM userRoutes Where id=@routeID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@routeID", Int32.Parse(dgvSavedRoutes.CurrentRow.Cells[0].Value.ToString()));
                            // Execute the command
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Rota Silindi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Rota silinirken bir hata oluştu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cRoutes r = new();
            _routes = r.savedRoutes(Int32.Parse(_userRow[0].ToString()), Int32.Parse(_userRow[7].ToString()));
            dgvSavedRoutes.DataSource= _routes;
        }
    }
}
