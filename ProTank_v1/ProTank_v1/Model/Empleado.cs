using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ProTank_v1.Model
{
    class Empleado
    {
        public String fname { set; get; }
        public String lname { set; get; }
        public String id { set; get; }
        public String tel { set; get; }
        public String cel { set; get; }

        private SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["protankDB"].ConnectionString);

        public Empleado(String fname, String lname, String id)
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
        }

        public Empleado(String fname, String lname, String id, String tel, String cel)
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
            this.tel = tel;
            this.cel = cel;
        }

        public Empleado()
        {

        }

        public Empleado getEmpleado(String id)
        {
            DB.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM empleado WHERE idE = @id", DB);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Empleado u = new Empleado(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString());
            DB.Close();
            return u;
        }

        public DataTable tableEmpleado()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM empleado", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable tableEmpleado2()
        {
            SqlCommand command = new SqlCommand("SELECT fname [Nombres], lname [Apellidos], idE [Cédula de Identidad], telef [Teléfono], cel [Celular] FROM empleado", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public bool upEmpleado(string nombre, string apellido, string ci, string telefono, string celular)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE empleado SET fname = @fname, lname = @lname, telef = @telef, cel = @cel WHERE idE = @idE", DB);
                command.Parameters.AddWithValue("@fname", nombre);
                command.Parameters.AddWithValue("@lname", apellido);
                command.Parameters.AddWithValue("@telef", telefono);
                command.Parameters.AddWithValue("@cel", celular);
                command.Parameters.AddWithValue("@idE", ci);
                DB.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
            }
            catch
            {

            }
            finally
            {
                DB.Close();
            }
            return isSuccess;
        }

        public bool delEmpleado(string ci)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM userEmpleado WHERE idE = @idE", DB);
                command.Parameters.AddWithValue("@idE", ci);
                DB.Open();
                int rows = command.ExecuteNonQuery();
                command = new SqlCommand("DELETE FROM empleado WHERE idE = @idE", DB);
                command.Parameters.AddWithValue("@idE", ci);
                rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
            }
            catch
            {

            }
            finally
            {
                DB.Close();
            }
            return isSuccess;
        }

        public bool insEmpleado(string nombre, string apellido, string ci, string telefono, string celular)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO empleado VALUES(@fname, @lname, @idE, @telef, @cel)", DB);
                command.Parameters.AddWithValue("@fname", nombre);
                command.Parameters.AddWithValue("@lname", apellido);
                command.Parameters.AddWithValue("@telef", telefono);
                command.Parameters.AddWithValue("@cel", celular);
                command.Parameters.AddWithValue("@idE", ci);
                DB.Open();
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
            }
            catch
            {

            }
            finally
            {
                DB.Close();
            }
            return isSuccess;
        }

        public Empleado getEmp(String uname)
        {
            DB.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM userEmpleado WHERE uname = @uname", DB);
            cmd.Parameters.AddWithValue("@uname", uname);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            String idE = reader.GetValue(0).ToString();
            DB.Close();
            return getEmpleado(idE);
        }

    }
}
