using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ProTank_v1
{
    class Mantenimiento
    {
        public String codigoH { set; get; }
        public DateTime fecha { set; get; }
        public String notas { set; get; }

        private SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["protankDB"].ConnectionString);

        public Mantenimiento()
        {

        }

        public Mantenimiento(String codigoH, DateTime fecha)
        {
            this.codigoH = codigoH;
            this.fecha = fecha;
        }

        public Mantenimiento(String codigoH, DateTime fecha, String notas)
        {
            this.codigoH = codigoH;
            this.fecha = fecha;
            this.notas = notas;
        }

        /*-----------------------------------------------------------------------------------
        --------------------------------Insertar Mantenimiento-------------------------------
        -----------------------------------------------------------------------------------*/

        //Pasar null en notas si no hay :"v
        public bool insMantenimiento(string herramientaID, DateTime fechaM, string notas)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO mantenimiento VALUES (@codH, @fechaM, @notas)", DB);
                command.Parameters.AddWithValue("@codH", herramientaID);
                command.Parameters.AddWithValue("@fechaM", fechaM);
                command.Parameters.AddWithValue("@notas", notas);
                DB.Open();
                int rows = command.ExecuteNonQuery();
                if(rows > 0)
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
        ---------------------------------Editar Mantenimiento--------------------------------
        -----------------------------------------------------------------------------------*/

        //Solo para agregar notas 
        public bool upMantenimiento(string herramientaID, DateTime fechaM, string notas)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE mantenimiento SET notas = @notas WHERE codigoH = @codH AND fecha = @fecha", DB);
                command.Parameters.AddWithValue("@codH", herramientaID);
                command.Parameters.AddWithValue("@fechaM", fechaM);
                command.Parameters.AddWithValue("@notas", notas);
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
        --------------------------------Buscar en Mantenimiento------------------------------
        -----------------------------------------------------------------------------------*/

        //Buscar un mantenimiento específico
        public DataTable tableMantenimiento(string codH, DateTime fechaM)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mantenimiento WHERE codigoH = @codH AND fecha = @fechaM ", DB);
            command.Parameters.AddWithValue("@codH", codH);
            command.Parameters.AddWithValue("fechaM", fechaM);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        //Buscar por codigo
        public DataTable tableMantenimiento(string codH)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mantenimiento WHERE codigoH = @codH", DB);
            command.Parameters.AddWithValue("@codH", codH);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        //Buscar por fecha
        public DataTable tableMantenimiento(DateTime fecha)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mantenimiento WHERE fecha = @fecha", DB);
            command.Parameters.AddWithValue("@fecha", fecha);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        //Buscar por rango de fechas
        public DataTable tableMantenimiento(DateTime fechaMin, DateTime fechaMax)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mantenimiento WHERE fecha BETWEEN @fechaMin AND @fechaMax", DB);
            command.Parameters.AddWithValue("@fechaMin", fechaMin);
            command.Parameters.AddWithValue("@fechaMax", fechaMax);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        /*-----------------------------------------------------------------------------------
        ---------------------------------Listar Mantenimiento--------------------------------
        -----------------------------------------------------------------------------------*/

        public DataTable tableMantenimiento()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mantenimiento", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable tableMantenimientoSW()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mantenimientoSW", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable tableMantenimientoSW(string codH, DateTime fechaI)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mantenimientoSW WHERE codigoH = @codH AND CAST(fechaIngreso AS DATE) = CAST(@fechaI AS DATE)", DB);
            command.Parameters.AddWithValue("@codH", codH);
            command.Parameters.AddWithValue("@fechaI", fechaI);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable buscarRango(DateTime min, DateTime max)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mantenimientoSW WHERE CAST(fechaIngreso AS DATE) > CAST(@fechaI AS DATE) AND CAST(fechaSalida AS DATE) < CAST(@fechaF AS DATE)", DB);
            command.Parameters.AddWithValue("@FechaF", max);
            command.Parameters.AddWithValue("@fechaI", min);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }


        public bool insMantenimiento(string herramientaID, DateTime fechaI, int cantidad)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO mantenimientoSW (codigoH,cantidad,fechaIngreso) VALUES (@codH, @cantidad,@fechaI)", DB);
                command.Parameters.AddWithValue("@codH", herramientaID);
                command.Parameters.AddWithValue("@fechaI", fechaI);
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

        public bool upMantenimiento(string herramientaID, DateTime fechaI, DateTime fechaF, string notas)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE mantenimientoSW SET fechaSalida = @fechaF, notas = @notas WHERE codigoH = @codH AND CAST(fechaIngreso AS DATE) = CAST(@fechaI AS DATE)", DB);
                command.Parameters.AddWithValue("@codH", herramientaID);
                command.Parameters.AddWithValue("@fechaF", fechaF);
                command.Parameters.AddWithValue("@fechaI", fechaI);
                command.Parameters.AddWithValue("@notas", notas);
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
