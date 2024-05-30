using Kütüphane_Otomasyon.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Kütüphane_Otomasyon.UserPages
{
    public partial class frmUserDashboard : Form
    {
        DataRow _userRow;
        public frmUserDashboard(DataRow userRow)
        {
            InitializeComponent();
            _userRow = userRow;
        }

        private void btnShowRoute_Click(object sender, EventArgs e)
        {
            string kalkisYeri = cmbOrigin.SelectedItem?.ToString().Trim();
            string varisYeri = cmbDestination.SelectedItem?.ToString().Trim();
            string yolculuk = cmbMode.SelectedItem?.ToString().Trim();

            cRoutes r = new();
            DataTable routeTable = r.routeControl(kalkisYeri, varisYeri, yolculuk);
            frmRotalar routes = new frmRotalar(routeTable, _userRow);
            routes.Show();

        }

        private void frmUserDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Hosgeldin " + _userRow[4] + "!";
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            cRoutes r = new();
            DataTable routeTable = r.savedRoutes(Int32.Parse(_userRow[0].ToString()), Int32.Parse(_userRow[7].ToString()));
            frmSavedRoutes routes = new frmSavedRoutes(routeTable, _userRow);
            routes.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmUserProfile profile = new frmUserProfile(_userRow);
            profile.Show();
        }
    }
}
