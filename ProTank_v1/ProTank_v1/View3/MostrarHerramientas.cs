using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProTank_v1.View3
{
    public partial class MostrarHerramientas : Form
    {
        public MostrarHerramientas()
        {
            InitializeComponent();
        }

        private void MostrarHerramientas_Load(object sender, EventArgs e)
        {
            listarHerramientas();
        }

        private void listarHerramientas()
        {
            DataTable dataTable = new Herramienta().tableHerramienta2();
            tableModulos_Contratos_tabla.DataSource = dataTable;
        }
    }
}
