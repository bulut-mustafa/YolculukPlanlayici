using Kütüphane_Otomasyon.AdminPages;
using Kütüphane_Otomasyon.Classes;
using Kütüphane_Otomasyon.UserPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyon
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lgnBtn_Click(object sender, EventArgs e)
        {
            
            List<int> roles = new List<int>();

            if (ogrLgnBtn.Checked == true)
            {
                roles.Add(2);
                roles.Add(3);
            }
            else if (prsnLgnBtn.Checked == true)
            {
                roles.Add(1);
            }
            else
            {
                MessageBox.Show("Lütfen giriş türü seçiniz.");
                return;
            }

            cUsers u = new();
            DataRow userRow = u.userControl(txtUsername.Texts, txtPassword.Texts, roles);

            if (userRow != null)
            {
                // Store user details in UserSession
              

                this.Hide();
                if (roles.Contains(1))
                {
                    frmAdminDashboard admnDsh = new frmAdminDashboard();
                    admnDsh.Show();
                    admnDsh.FormClosed += (s, args) => this.Close();
                }
                else if (roles.Contains(2) || roles.Contains(3))
                {
                    frmUserDashboard userDsh = new frmUserDashboard(userRow);
                    userDsh.Show();
                    userDsh.FormClosed += (s, args) => this.Close();
                }
            }
            else
            {
                MessageBox.Show("Bir yanlışlık var.");
            }
        }

        private void sgnUpBtn_Clck(object sender, EventArgs e)
        {
            frmSignUp sgnFrm = new frmSignUp();
            sgnFrm.Show();
        }

        private void ogrLgnBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (prsnLgnBtn.Checked == true)
            {
                prsnLgnBtn.Checked = false;
            }
        }

        private void prsnLgnBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ogrLgnBtn.Checked == true)
            {
                ogrLgnBtn.Checked = false;
            }
        }
    }
}
