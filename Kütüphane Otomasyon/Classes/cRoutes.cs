using System;
using System.Data;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyon.Classes
{
    internal class cRoutes
    {
        cSqlConn sConn = new cSqlConn();
        #region Fields
        private int _RouteID;
        private int _KalkisYeri;
        private int _VarisYeri;
        private int _Fiyat;
        private int _Sure;
        private int _YolculukTipi;
        #endregion

        #region Properties
        public int RouteID { get => _RouteID; set => _RouteID = value; }
        public int KalkisYeri { get => _KalkisYeri; set => _KalkisYeri = value; }
        public int VarisYeri { get => _VarisYeri; set => _VarisYeri = value; }
        public int Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public int Sure { get => _Sure; set => _Sure = value; }
        public int YolculukTipi { get => _YolculukTipi; set => _YolculukTipi = value; }
        #endregion

        public DataTable routeControl(string kalkisYeri, string varisYeri, string yolculuk)
        {
            DataTable dt = new DataTable(); // Initialize the DataTable
            try
            {
                using (SqlConnection con = new SqlConnection(sConn.conString))
                {
                    string query = "";
                    con.Open();
                    if (yolculuk == "Hepsi")
                    {
                        query = "SELECT * FROM routes WHERE kalkisYeri = @kalkisYeri AND varisYeri = @varisYeri";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@kalkisYeri", kalkisYeri);
                            cmd.Parameters.AddWithValue("@varisYeri", varisYeri);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(dt);
                            }
                        }
                    }
                    else
                    {
                        query = "SELECT * FROM routes WHERE kalkisYeri = @kalkisYeri AND varisYeri = @varisYeri AND yolculuk = @yolculuk";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@kalkisYeri", kalkisYeri);
                            cmd.Parameters.AddWithValue("@varisYeri", varisYeri);
                            cmd.Parameters.AddWithValue("@yolculuk", yolculuk);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(dt);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }

        public DataTable savedRoutes(int userID, int TypeID)
        {
            DataTable dt = new DataTable(); // Initialize the DataTable
            try
            {
                using (SqlConnection con = new SqlConnection(sConn.conString))
                {
                    string query = "";
                    if(TypeID == 3)
                    {
                        query = @"
                        SELECT ur.id, r.kalkisYeri, r.varisYeri,r.fiyat, 
                        r.fiyat * 0.8 AS 'İndirimli Fiyat(20½)', r.süre, r.yolculuk
                        FROM userRoutes ur
                        INNER JOIN routes r ON ur.routeID = r.id
                        WHERE ur.userID = @userID";
                    }
                    else
                    {
                        query = @"
                        SELECT ur.id, r.kalkisYeri, r.varisYeri,r.fiyat, 
                        r.süre, r.yolculuk
                        FROM userRoutes ur
                        INNER JOIN routes r ON ur.routeID = r.id
                        WHERE ur.userID = @userID";
                    }
                    
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@userID", userID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
    }
}
