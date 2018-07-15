using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTank_v1
{
    class User
    {
        public String uname { set; get; }
        private String pwd { get; }
        public String rol { get; }

        public User(String uname, String pwd, String rol)
        {
            this.uname = uname;
            this.pwd = pwd;
            this.rol = rol;
        }

        /*Coneccion con la base de datos*/

    }
}
