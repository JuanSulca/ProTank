using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ProTank_v1.Model
{
    class Servicio
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public string unidad { get; set; }

        private SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["protankDB"].ConnectionString);

        public Servicio()
        {

        }

        public bool insServicio(String codigo, String nombre, decimal precio, String unidad)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO prodServ VALUES (@codigo, @nombre, @precio, @unidad, 'S')", DB);
                command.Parameters.AddWithValue("@codigo", codigo);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@unidad", unidad);
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

        public bool upServicio(String codigo, String nombre, decimal precio, String unidad)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE prodServ SET nombre = @nombre, precio = @precio, unidad = @unidad WHERE codigo = @codigo AND tipo = 'S'", DB);
                command.Parameters.AddWithValue("@codigo", codigo);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@unidad", unidad);
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

        public bool delServicio(String codigo)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM prodServ WHERE codigo = @codigo AND tipo = 'S'", DB);
                command.Parameters.AddWithValue("@codigo", codigo);
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

        public DataTable tableServicio2()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM prodServ WHERE tipo = 'S'", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable tableServicio()
        {
            SqlCommand command = new SqlCommand("SELECT codigo [Código del servicio], nombre [Nombre], precio [Precio], unidad [Unidad de medida] FROM prodServ WHERE tipo = 'S'", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

    }
}
