using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTank_v1
{
    class Mantenimiento
    {
        String codigoH { set; get; }
        DateTime fecha { set; get; }
        String notas { set; get; }

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

    }
}
