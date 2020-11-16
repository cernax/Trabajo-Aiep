using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Users
    {
        public string user { get; set; }
        public string password { get; set; }
        public Users()
        {
            user = string.Empty;
            password = string.Empty;

        }
    }
}
