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

        public Person getPerson(String id)
        {
            DB.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM person WHERE id = @id", DB);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Person u = new Person(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString());
            DB.Close();
            return u;
        }

        public DataTable tablePerson()
        {
            SqlCommand command = new SqlCommand("SELECT fname [Nombres], lname [Apellidos], id [Cédula de Identidad], telef [Teléfono], cel [Celular] FROM person", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public bool upPerson(string nombre, string apellido, string ci, string telefono, string celular)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE person SET fname = @fname, lname = @lname, telef = @telef, cel = @cel WHERE id = @id", DB);
                command.Parameters.AddWithValue("@fname", nombre);
                command.Parameters.AddWithValue("@lname", apellido);
                command.Parameters.AddWithValue("@telef", telefono);
                command.Parameters.AddWithValue("@cel", celular);
                command.Parameters.AddWithValue("@id", ci);
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

        public bool delPerson(string ci)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM person WHERE id = @id", DB);
                command.Parameters.AddWithValue("@id", ci);
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

        public bool insPerson(string nombre, string apellido, string ci, string telefono, string celular)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO person VALUES(@fname, @lname, @id, @telef, @cel)", DB);
                command.Parameters.AddWithValue("@fname", nombre);
                command.Parameters.AddWithValue("@lname", apellido);
                command.Parameters.AddWithValue("@telef", telefono);
                command.Parameters.AddWithValue("@cel", celular);
                command.Parameters.AddWithValue("@id", ci);
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


    }
}
