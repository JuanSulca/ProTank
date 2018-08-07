using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProTank_v1.View2
{
    public partial class Contratos : Form
    {
        public Contratos()
        {
            InitializeComponent();
        }

        private void Contratos_Load(object sender, EventArgs e)
        {
            listarContratos();
        }

        private void listarContratos()
        {
            DataTable dataTable = new Contrato().tableContrato2();
            tableModulos_Contratos_tabla.DataSource = dataTable;
        }
    }
}
