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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Modulos_Load(object sender, EventArgs e)
        {
                        
        }

        private void Modulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            this.Dispose();
        }

        private void dateModulos_Herramientas_tabPrestamos_horaFecha_ValueChanged(object sender, EventArgs e)
        {
            /*this.prestamoTableAdapter.Fill(this.protankDataSet1.prestamo);
            this.prestamoBindingSource.Filter = "Fecha=" + dateModulos_Herramientas_tabPrestamos_horaFecha.Value;*/
        }

        private void txtModulos_Herramientas_tabInventario_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModulos_Herramientas_tabInventario_buscarHerramienta_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
