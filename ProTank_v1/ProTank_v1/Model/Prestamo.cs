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

        private SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["protankDB"].ConnectionString);


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

        public bool upPrestamo(DateTime fechaDevolucion, string codHerramienta, string empleadoID, DateTime fecha)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE prestamo SET fechaD = @fechaD WHERE codigoH = @codHerramienta AND idE = @empID AND fechaP = @fecha", DB);
                command.Parameters.AddWithValue("@fechaD", fechaDevolucion);
                command.Parameters.AddWithValue("@codHerramienta", codHerramienta);
                command.Parameters.AddWithValue("@empID", empleadoID);
                command.Parameters.AddWithValue("@fecha", fecha);
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

        public bool upPrestamo(string codHerramienta, string empID, DateTime fecha, Boolean returned)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE prestamo SET returned = @returned WHERE codigoH = @codHerramienta AND idE = @empID AND fechaP = @fecha", DB);
                command.Parameters.AddWithValue("@returned", returned);
                command.Parameters.AddWithValue("@codHerramienta", codHerramienta);
                command.Parameters.AddWithValue("@empID", empID);
                command.Parameters.AddWithValue("@fecha", fecha);
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

        public bool insPrestamo(string codigoH, string empleadoID, DateTime fecha, int cantidad, Boolean ret)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO prestamo VALUES (@codigoH, @empID, @fecha, @cantidad, @ret)", DB);
                command.Parameters.AddWithValue("@codigoH", codigoH);
                command.Parameters.AddWithValue("@empID", empleadoID);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                command.Parameters.AddWithValue("@ret", ret);
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
        -----------------------------------Buscar Prestamos----------------------------------
        -----------------------------------------------------------------------------------*/

        //Buscar específicamente un prestamo
        public DataTable tablePrestamo(string codH, string codE, DateTime fecha)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM prestamo WHERE codigoH = @codH AND idE = @codE AND fechaP = @fecha", DB);
            command.Parameters.AddWithValue("@codH", codH);
            command.Parameters.AddWithValue("@codE", codE);
            command.Parameters.AddWithValue("@fecha", fecha);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        //Buscar por fecha (inicio o fin)
        public DataTable tablePrestamo(string criterioDeBusqueda, DateTime value)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM prestamo WHERE " + criterioDeBusqueda + " = @value", DB);
            command.Parameters.AddWithValue("@value", value);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        //Buscar por rango de fechas (prestamos desde, hasta)
        public DataTable tablePrestamo(DateTime fechaMin, DateTime fechaMax)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM prestamo WHERE fechaP BETWEEN @fechaMin AND @fechaMax", DB);
            command.Parameters.AddWithValue("@fechaMin", fechaMin);
            command.Parameters.AddWithValue("@fechaMax", fechaMax);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        //Buscar por cantidad
        public DataTable tablePrestamo(string criterioDeBusqueda, int value)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM prestamo WHERE " + criterioDeBusqueda + " = @value", DB);
            command.Parameters.AddWithValue("@value", value);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        //Buscar por Codigo de herramiento o de empleado
        public DataTable tablePrestamo(string criterioDeBusqueda, string value)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM prestamo WHERE " + criterioDeBusqueda + " = @value", DB);
            command.Parameters.AddWithValue("@value", value);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }


        /*-----------------------------------------------------------------------------------
        -----------------------------------Listar Prestamos----------------------------------
        -----------------------------------------------------------------------------------*/

        public DataTable tablePrestamo()
        {
            SqlCommand command = new SqlCommand("SELECT codigoH [Herramienta], idE [Empleado], fechaP [Fecha de préstamo], cantidad [Cantidad], returned [Devuelto] FROM prestamo", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable tablePrestamo1()
        {
            SqlCommand command = new SqlCommand("SELECT codigoH [Herramienta], idE [Empleado], fechaP [Fecha de préstamo], cantidad [Cantidad], returned [Devuelto] FROM prestamo WHERE returned = 1", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable tablePrestamo2()
        {
            SqlCommand command = new SqlCommand("SELECT codigoH [Herramienta], idE [Empleado], fechaP [Fecha de préstamo], cantidad [Cantidad], returned [Devuelto] FROM prestamo WHERE returned = 0", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

    }
}
