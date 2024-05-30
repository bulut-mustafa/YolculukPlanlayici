using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Kütüphane_Otomasyon.Classes
{
    internal class cUsers
    {
        cSqlConn sConn = new cSqlConn();
        #region Fields
        private int _UserId;
        private int _Username;
        private int _Pass;
        private int _Email;
        private int _FullName;
        private int _PhoneNumber;
        private int _RegisterDate;
        private int _RoleId;
        #endregion

        #region Properties
        public int UserId { get => _UserId; set => _UserId = value; }
        public int Username { get => _Username; set => _Username = value; }
        public int Pass { get => _Pass; set => _Pass = value; }
        public int Email { get => _Email; set => _Email = value; }
        public int FullName { get => _FullName; set => _FullName = value; }
        public int PhoneNumber { get => _PhoneNumber; set => _PhoneNumber = value; }
        public int RegisterDate { get => _RegisterDate; set => _RegisterDate = value; }
        public int RoleId { get => _RoleId; set => _RoleId = value; }
        #endregion

        public DataRow userControl(string username, string password, List<int> roleIDs)
        {
            DataRow userRow = null;
            try
            {
                using (SqlConnection con = new SqlConnection(sConn.conString))
                {
                    con.Open();
                    string query = "SELECT * FROM users WHERE Username = @Username AND Pass = @Password AND RoleId IN (" + string.Join(",", roleIDs) + ")";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                userRow = dt.Rows[0];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return userRow;
        }
    }
}
