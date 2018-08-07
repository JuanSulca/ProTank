using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTank_v1
{
    class Contrato
    {
        public String idPer { set; get; }
        public decimal monto { set; get; }
        public int calificacion { set; get; }
        public String idCon { set; get; }
        public String descrip { set; get; }
        public DateTime fechaI { set; get; }
        public DateTime fechaE { set; get; }

        private SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["protankDB"].ConnectionString);

        public Contrato(String idPer, decimal monto, String idCon, DateTime fechaI)
        {
            this.idPer = idPer;
            this.monto = monto;
            this.idCon = idCon;
            this.fechaI = fechaI;
        }

        public Contrato(String idPer, decimal monto, int calificacion, String idCon, String descrip, DateTime fechaI, DateTime fechaE)
        {
            this.idPer = idPer;
            this.monto = monto;
            this.calificacion = calificacion;
            this.idCon = idCon;
            this.descrip = descrip;
            this.fechaI = fechaI;
            this.fechaE = fechaE;
        }

        public Contrato()
        {

        }

        public Contrato getContrato(String id)
        {
            DB.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM contrato WHERE idCon = @id", DB);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Contrato u = new Contrato(reader.GetValue(0).ToString(), Convert.ToDecimal(reader.GetValue(1).ToString()), Convert.ToInt32(reader.GetValue(2).ToString()), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), Convert.ToDateTime(reader.GetValue(5).ToString()), Convert.ToDateTime(reader.GetValue(6).ToString()));
            DB.Close();
            return u;
        }

        public DataTable tableContrato()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM contrato", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public bool upContrato(string nombre, string apellido, string ci, string telefono, string celular)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("UPDATE contrato SET fname = @fname, lname = @lname, telef = @telef, cel = @cel WHERE idE = @idE", DB);
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

        public bool delContrato(string ci)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM contrato WHERE idCon = @idE", DB);
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
    }
}
