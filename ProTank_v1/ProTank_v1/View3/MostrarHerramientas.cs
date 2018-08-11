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
        int p = 0;
        public MostrarHerramientas()
        {
            InitializeComponent();
            tableModulos_Contratos_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public MostrarHerramientas(int p)
        {
            this.p = p;
            InitializeComponent();
            tableModulos_Contratos_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if(p == 1)
                lblContratos_contratos.Text = "Mantenimientos Proximos";
            else if(p == 2)
                lblContratos_contratos.Text = "Mantenimientos Urgentes";
        }

        private void MostrarHerramientas_Load(object sender, EventArgs e)
        {
            if (p == 0)
                listarHerramientas();
            else if (p == 1)
                tableModulos_Contratos_tabla.DataSource = new Herramienta().tableProximos();
            else if(p == 2)
                tableModulos_Contratos_tabla.DataSource = new Herramienta().tableUrgentes();
        }

        private void listarHerramientas()
        {
            DataTable dataTable = new Herramienta().tableHerramienta2();
            tableModulos_Contratos_tabla.DataSource = dataTable;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
