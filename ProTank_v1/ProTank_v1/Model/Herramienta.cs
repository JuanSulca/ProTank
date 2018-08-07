using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace ProTank_v1
{
    class Herramienta
    {
        public String nombre { set; get; }
        public int cantidad { set; get; }
        public String codigo { set; get; }
        public int periodo { set; get; }

        private SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["protankDB"].ConnectionString);

        public Herramienta()
        {

        }

        public Herramienta(String nombre, int cantidad, String codigo, int periodo)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.codigo = codigo;
            this.periodo = periodo;
        }

        /*-----------------------------------------------------------------------------------
        ---------------------------------Modificar Herramienta-------------------------------
        -----------------------------------------------------------------------------------*/
         
        
        //Se pasa el nombre de la columna que se quiere modificar :v e.e. nombre,cantidad,periodo
        public bool upHerramienta(string columna, string nombre, string codHerramienta)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE herramienta SET " + columna + " = @nombre WHERE codigoH = @codHerramienta");
                command.Parameters.AddWithValue("@nombre",nombre);
                command.Parameters.AddWithValue("@codHerramienta", codHerramienta);
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

        //Se puede usar para "eliminar" con columna = cantidad y value = -1
        public bool upHerramienta(string columna, int value, string codHerramienta)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE herramienta SET " + columna + " = @value WHERE codigoH = @codHerramienta");
                command.Parameters.AddWithValue("@value", value);
                command.Parameters.AddWithValue("@codHerramienta", codHerramienta);
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

        /*-----------------------------------------------------------------------------------
        ----------------------------------Insertar Herramienta-------------------------------
        -----------------------------------------------------------------------------------*/

        public bool insHerramienta(string nombre, int cantidad, string codigoH, int periodo)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO herramienta VALUES (@nombre, @cantidad, @codigoH, @periodo)");
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                command.Parameters.AddWithValue("@codigoH", codigoH);
                command.Parameters.AddWithValue("@periodo", periodo);

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


        /*-----------------------------------------------------------------------------------
        -----------------------------------Buscar Herramienta--------------------------------
        -----------------------------------------------------------------------------------*/

        //columna pasaría a ser el criterio de busqueda
        public DataTable tableHerramienta(string columna, int value)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM herramienta WHERE " + columna + " = @value");
            command.Parameters.AddWithValue("@value", value);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable tableHerramienta(string columna, string value)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM herramienta WHERE " + columna + " = @value");
            command.Parameters.AddWithValue("@value", value);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        /*-----------------------------------------------------------------------------------
        -----------------------------------Listar Herramienta--------------------------------
        -----------------------------------------------------------------------------------*/

        public DataTable tableHerramienta()
        {
            SqlCommand command = new SqlCommand("SELECT nombre [Nombre], cantidad [Cantidad], codigoH [Código de la herramienta], periodo [Periodo] FROM herramienta");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

    }
}
