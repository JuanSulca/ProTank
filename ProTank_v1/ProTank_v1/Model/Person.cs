using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ProTank_v1
{
    class Person
    {
        public String fname { set; get; }
        public String lname { set; get; }
        public String id { set; get; }
        public String tel { set; get; }
        public String cel { set; get; }

        private SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["protankDB"].ConnectionString);

        public Person(String fname, String lname, String id)
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
        }

        public Person(String fname, String lname, String id, String tel, String cel)
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
            this.tel = tel;
            this.cel = cel;
        }

        public Person()
        {

        }



    }
}
