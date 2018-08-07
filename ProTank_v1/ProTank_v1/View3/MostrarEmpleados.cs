using ProTank_v1.Model;
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
    public partial class MostrarEmpleados : Form
    {
        public MostrarEmpleados()
        {
            InitializeComponent();
        }

        private void MostrarEmpleados_Load(object sender, EventArgs e)
        {
            listarEmpleados();
        }

        private void listarEmpleados()
        {
            DataTable dataTable = new Empleado().tableEmpleado();
            tableModulos_Contratos_tabla.DataSource = dataTable;
        }
    }
}
