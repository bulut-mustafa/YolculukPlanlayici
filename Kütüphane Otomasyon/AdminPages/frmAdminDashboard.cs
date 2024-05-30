using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using Kütüphane_Otomasyon.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Globalization;

namespace Kütüphane_Otomasyon.AdminPages
{
    public partial class frmAdminDashboard : Form
    {
        cSqlConn sConn = new cSqlConn();
        public frmAdminDashboard()
        {
            InitializeComponent();
        }



        private void frmAdminDashboard_Load_1(object sender, EventArgs e)
        {
            // Connection string (adjust the parameters as necessary)

            // SQL query to fetch data
            FetchDataFromDatabase();

        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ID'li rotayı silmek istiyor musunuz?", "ROTA SİLME İŞLEMİ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(sConn.conString))
                    {
                        con.Open();
                        string query = "Delete FROM routes WHERE id = @routeID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@routeID", Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                            // Execute the command
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Kayıt başarıyla silindi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Kayıt silinirken bir hata oluştu veya kayıt bulunamadı.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        con.Close();
                    }
                    FetchDataFromDatabase();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void FetchDataFromDatabase()
        {
            string query = "SELECT * FROM routes";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(sConn.conString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a new SqlDataAdapter object
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Create a new DataTable object
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the database
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    connection.Close();
                }
                catch (Exception ex)
                {
                    // Handle any errors that may have occurred
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            string kalkisYeri = TxtkalkisYeri.Texts.Trim();
            string varisYeri = TxtvarisYeri.Texts.Trim();
            int fiyat = Int32.Parse(Txtfiyat.Texts.Trim());
            string süre = Txtsüre.Texts.Trim();
            string yolculuk = CmdyolculukTürü.SelectedItem?.ToString().Trim();


            if (string.IsNullOrEmpty(kalkisYeri) || string.IsNullOrEmpty(varisYeri) || string.IsNullOrEmpty(Txtfiyat.Texts) ||
                string.IsNullOrEmpty(Txtsüre.Texts) || string.IsNullOrEmpty(yolculuk))
            {
                MessageBox.Show("Boş alan bırakmayınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            try
            {

                DataRow routeRow = null;
                using (SqlConnection con = new SqlConnection(sConn.conString))
                {
                    con.Open();

                    string checkQuery = "SELECT * FROM routes WHERE kalkisYeri = @kalkisYeri AND varisYeri = @varisYeri AND yolculuk= @yolculuk";
                    using (SqlCommand cmd = new SqlCommand(checkQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@kalkisYeri", kalkisYeri);
                        cmd.Parameters.AddWithValue("@varisYeri", varisYeri);
                        cmd.Parameters.AddWithValue("@yolculuk", yolculuk);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                routeRow = dt.Rows[0];
                                TxtkalkisYeri.Texts = routeRow["kalkisYeri"].ToString();
                                TxtvarisYeri.Texts = routeRow["varisYeri"].ToString();
                                Txtfiyat.Texts = routeRow["fiyat"].ToString();
                                Txtsüre.Texts = routeRow["süre"].ToString();
                                CmdyolculukTürü.SelectedItem = routeRow["yolculuk"].ToString();
                                SelectRowInDataGridView(routeRow["id"].ToString());
                                MessageBox.Show("Bu kayıt zaten bulunmakta. Güncellemek için devam edin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    string query = "INSERT INTO routes (kalkisYeri, varisYeri, fiyat, süre, yolculuk) VALUES (@kalkisYeri, @varisYeri, @fiyat, @süre, @yolculuk)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@kalkisYeri", kalkisYeri);
                        command.Parameters.AddWithValue("@varisYeri", varisYeri);
                        command.Parameters.AddWithValue("@fiyat", fiyat);
                        command.Parameters.AddWithValue("@süre", süre);
                        command.Parameters.AddWithValue("@yolculuk", yolculuk);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Başarıyla kayıt alındı.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtkalkisYeri.Texts = string.Empty;
                            TxtvarisYeri.Texts = string.Empty;
                            Txtfiyat.Texts = string.Empty;
                            Txtsüre.Texts = string.Empty;
                            CmdyolculukTürü.SelectedIndex = -1;
                            con.Close();


                        }
                        else
                        {
                            MessageBox.Show("Kayıt olurken bir hata oluştu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FetchDataFromDatabase();
        }
        private void SelectRowInDataGridView(string routeId)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["id"].Value != null && row.Cells["id"].Value.ToString() == routeId)
                {
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[0]; // Optionally, set the current cell to the first cell of the selected row
                    break;
                }
            }
        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtkalkisYeri.Texts = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtvarisYeri.Texts = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Txtfiyat.Texts = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Txtsüre.Texts = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            CmdyolculukTürü.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void düzenlebtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(sConn.conString);

                
                if (MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ID'li rotayı güncellemek istiyor musunuz?", "ROTA GÜNCELLEME İŞLEMİ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (con.State == ConnectionState.Closed) con.Open();

                    if (TxtkalkisYeri.Texts.Trim() == "" || TxtvarisYeri.Texts.Trim() == "" || Txtfiyat.Texts.Trim() == "" || Txtsüre.Texts.Trim() == "")
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurunuz..", "KAYIT GÜNCELLEME İŞLEMİ BAŞARISIZ!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("update routes set kalkisYeri=@kalkisYeri, varisYeri=@varisYeri, fiyat=@fiyat, süre=@süre, yolculuk=@yolculuk WHERE id=@routeID", con);
                        command.Parameters.AddWithValue("@kalkisYeri", TxtkalkisYeri.Texts.Trim());
                        command.Parameters.AddWithValue("@varisYeri", TxtvarisYeri.Texts.Trim());
                        command.Parameters.AddWithValue("@fiyat", Int32.Parse(Txtfiyat.Texts.Trim()));
                        command.Parameters.AddWithValue("@süre", Txtsüre.Texts.Trim());
                        command.Parameters.AddWithValue("@yolculuk", CmdyolculukTürü.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@routeID", Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                        command.ExecuteNonQuery();

                        MessageBox.Show("Kayıt güncelleme işlemi başarılı...", "KAYIT GÜNCELLEME İŞLEMİ TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                }


                FetchDataFromDatabase();
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Bir hata oluştu: {Ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            TxtkalkisYeri.Texts = String.Empty;
            TxtvarisYeri.Texts = String.Empty;
            Txtfiyat.Texts = String.Empty;
            Txtsüre.Texts = String.Empty;
            CmdyolculukTürü.SelectedIndex = -1;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
    

