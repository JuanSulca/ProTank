using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTank_v1.Model
{
    class Material
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public string unidad { get; set; }

        private SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["protankDB"].ConnectionString);

        public Material()
        {

        }

        public bool insMaterial(String codigo, String nombre, decimal precio, String unidad)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO prodServ VALUES (@codigo, @nombre, @precio, @unidad, 'P')", DB);
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

        public bool upMaterial(String codigo, String nombre, decimal precio, String unidad)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE prodServ SET nombre = @nombre, precio = @precio, unidad = @unidad WHERE codigo = @codigo AND tipo = 'P'", DB);
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

        public bool delMaterial(String codigo)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM prodServ WHERE codigo = @codigo AND tipo = 'P'", DB);
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

        public DataTable tableMaterial2()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM prodServ WHERE tipo = 'P'", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable tableMaterial()
        {
            SqlCommand command = new SqlCommand("SELECT codigo [Código del servicio], nombre [Nombre], precio [Precio], unidad [Unidad de medida] FROM prodServ WHERE tipo = 'P'", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
