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
