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
    class Prestamo
    {
        public String codigoH { set; get; }
	    public String idE { set; get; }
	    public DateTime fechaPrestamo { set; get; }
        public DateTime fechaDevolucion { set; get; }
        public int cantidad { set; get; }

        private SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);


        public Prestamo()
        {

        }

        public Prestamo(String codigoH, String idE, DateTime fechaP, DateTime fechaD, int cantidad)
        {
            this.codigoH = codigoH;
            this.idE = idE;
            this.fechaPrestamo = fechaP;
            this.fechaDevolucion = fechaD;
            this.cantidad = cantidad;
        }

        /*-----------------------------------------------------------------------------------
        -----------------------------------Modificar Prestamo--------------------------------
        -----------------------------------------------------------------------------------*/

        public bool upContrato(DateTime fechaDevolucion, string codHerramienta, string empleadoID)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE prestamo SET fechaD = @fechaD WHERE codigoH = @codHerramienta AND idE = @empID", DB);
                command.Parameters.AddWithValue("@fechaD", fechaDevolucion);
                command.Parameters.AddWithValue("@codHerramienta", codHerramienta);
                command.Parameters.AddWithValue("@empID", empleadoID);
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

        public bool upContrato(int cantidad, string codHerramienta, string empID)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE prestamo SET cantidad = @cantidadWHERE codigoH = @codHerramienta AND idE = @empID", DB);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                command.Parameters.AddWithValue("@codHerramienta", codHerramienta);
                command.Parameters.AddWithValue("@empID", empID);
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
        ------------------------------------Agregar Prestamo---------------------------------
        -----------------------------------------------------------------------------------*/

        public bool insContrato(string codigoH, string empleadoID, int cantidad)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO prestamo (codigoH, idE, cantidad) VALUES (@codigoH, @empID, @cantidad)", DB);
                command.Parameters.AddWithValue("@codigoH", codigoH);
                command.Parameters.AddWithValue("@empID", empleadoID);
                command.Parameters.AddWithValue("@cantidad", cantidad);
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
        ------------------------------------Listar Prestamos---------------------------------
        -----------------------------------------------------------------------------------*/

        public DataTable tablePrestamo(string codH, string codE)
        {
            SqlCommand command = new SqlCommand("DELETE FROM prestamo WHERE codigoH = @codH AND idE = @codE", DB);
            command.Parameters.AddWithValue("@codH", codH);
            command.Parameters.AddWithValue("@codE", codE);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

    }
}
