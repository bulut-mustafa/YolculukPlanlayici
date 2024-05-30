using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyon.Classes
{
    internal class cUserSession
    {
        private static cUserSession instance;

        private cUserSession() { }

        public static cUserSession Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new cUserSession();
                }
                return instance;
            }
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
    }
}
