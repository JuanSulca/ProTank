using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTank_v1
{
    class Herramienta
    {
        public String nombre { set; get; }
        public String marca { set; get; }
        public String codigo { set; get; }
        public int periodo { set; get; }

        public Herramienta()
        {

        }

        public Herramienta(String nombre, String marca, String codigo, int periodo)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.codigo = codigo;
            this.periodo = periodo;
        }
    }
}
