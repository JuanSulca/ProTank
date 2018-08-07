using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace ProTank_v1
{
    class User
    {
        public String uname { set; get; }
        private String pwd { get; }
        public String rol { get; }

        private SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["protankDB"].ConnectionString);

        public User()
        {

        }

        public User(String uname, String pwd, String rol)
        {
            this.uname = uname;
            this.pwd = pwd;
            this.rol = rol;
        }

        public Boolean pass(String pwd2)
        {
            return (pwd == pwd2);
        }

        public User getUser(String uname)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM userLogin WHERE uname = @uname", cnx);
            cmd.Parameters.AddWithValue("@uname", uname);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            User u = new User(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
            cnx.Close();
            return u;
        }

        public Boolean insUser(User u)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO userLogin VALUES (@uname, @pwd, @rol)", cnx);
            cmd.Parameters.AddWithValue("@uname", u.uname);
            cmd.Parameters.AddWithValue("@pwd", u.pwd);
            cmd.Parameters.AddWithValue("@rol", u.rol);
            int i = cmd.ExecuteNonQuery();
            cnx.Close();
            return (i == 1);
        }

        public Boolean upUser(User u)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("UPDATE userLogin SET uname = @uname, pwd = @pwd, rol = @rol WHERE uname = @uname", cnx);
            cmd.Parameters.AddWithValue("@uname", u.uname);
            cmd.Parameters.AddWithValue("@pwd", u.pwd);
            cmd.Parameters.AddWithValue("@rol", u.rol);
            int i = cmd.ExecuteNonQuery();
            cnx.Close();
            return (i == 1);
        }

        public Boolean delUser(String uname)
        {
            int i = 0;
            cnx.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM userLogin WHERE uname = @uname", cnx);
            cmd.Parameters.AddWithValue("@uname", uname);
            try
            {
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eliminacion de usuario fallida!");
            }
            finally
            {
                cnx.Close();
            }
            return (i == 1);
        }

        public DataTable tableUser()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM userLogin", cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public DataTable tableUser2()
        {
            SqlCommand cmd = new SqlCommand("SELECT uname [Nombre de Usuario], pwd [Contraseña], rol [Rol de Usuario] FROM userLogin", cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public DataTable tableUserBy(String query)
        {
            SqlCommand cmd = new SqlCommand(query, cnx);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        /*Coneccion con la base de datos*/

    }
}
