using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProTank_v1.View
{
    public partial class Herramientas : Form
    {
        public Herramientas()
        {
            InitializeComponent();
        }

        private void btnModulos_Herramientas_ingresarPrestamo_Click(object sender, EventArgs e)
        {
            NewPrestamo p = new NewPrestamo();
            p.ShowDialog();
        }

        private void btnModulos_Herramientas_editarPrestamo_Click(object sender, EventArgs e)
        {
            NewPrestamo p = new NewPrestamo();
            p.ShowDialog();
        }

        private void btnModulos_Herramientas_tabInventario_nuevaHerramienta_Click(object sender, EventArgs e)
        {
            NewTool t = new NewTool();
            t.ShowDialog();
        }

        private void btnModulos_Herramientas_tabInventario_editarHerramientav_Click(object sender, EventArgs e)
        {
            NewTool t = new NewTool();
            t.ShowDialog();
        }
    }
}
