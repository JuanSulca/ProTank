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

        public DataTable tableServicio()
        {
            SqlCommand command = new SqlCommand("SELECT codigo [Código del servicio], nombre [Nombre], precio [Precio], unidad [Unidad de medida] FROM prodServ", DB);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

    }
}
