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
    public partial class MostrarServicios : Form
    {
        public MostrarServicios()
        {
            InitializeComponent();
        }

        private void MostrarServicios_Load(object sender, EventArgs e)
        {
            listarServicios();
        }

        private void listarServicios()
        {
            DataTable dataTable = new Servicio().tableServicio();
            tableModulos_Contratos_tabla.DataSource = dataTable;
            tableModulos_Contratos_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
