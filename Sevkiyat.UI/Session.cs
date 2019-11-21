using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sevkiyat.UI
{
    public class Session
    {
        public static User CurrentUser { get; set; }
        public static List<Role> CurrentRoles { get; set; }

        public static int FindRoleOrRoles()
        {
            var dummy = 0;
            for (int i = 0; i < Session.CurrentRoles.Count; i++)
            {
                if (Session.CurrentRoles[i].RoleName == "Sirket Sahibi")
                {
                    dummy = 2;
                }
                else if (Session.CurrentRoles[i].RoleName == "Isletmeci" && dummy < 2)
                {
                    dummy = 1;
                }
                else if (Session.CurrentRoles[i].RoleName == "Soför" && dummy < 1)
                {
                    dummy = 0;

                }
            }
            return dummy;
        }

    }
}
