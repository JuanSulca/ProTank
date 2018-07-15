using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTank_v1.Model
{
    class Prestamo
    {
        public String codigoH { set; get; }
	    public String idE { set; get; }
	    public DateTime fecha { set; get; }

        public Prestamo()
        {

        }

        public Prestamo(String codigoH, String idE, DateTime fecha)
        {
            this.codigoH = codigoH;
            this.idE = idE;
            this.fecha = fecha;
        }
    }
}
