using System;
using System.Collections.Generic;
using System.Configuration;
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




    }
}
