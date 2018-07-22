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
            // TODO: This line of code loads data into the 'protankDataSet1.person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.protankDataSet1.person);
            // TODO: This line of code loads data into the 'protankDataSet1.mantenimientoH_todo' table. You can move, or remove it, as needed.
            this.mantenimientoH_todoTableAdapter.Fill(this.protankDataSet1.mantenimientoH_todo);
            // TODO: This line of code loads data into the 'protankDataSet1.prestamosH_todo' table. You can move, or remove it, as needed.
            this.prestamosH_todoTableAdapter.Fill(this.protankDataSet1.prestamosH_todo);
            // TODO: This line of code loads data into the 'protankDataSet1.empleados_apellidos_nombres' table. You can move, or remove it, as needed.
            this.empleados_apellidos_nombresTableAdapter.Fill(this.protankDataSet1.empleados_apellidos_nombres);
            // TODO: This line of code loads data into the 'protankDataSet1.empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.protankDataSet1.empleado);
            // TODO: This line of code loads data into the 'protankDataSet1.contrato' table. You can move, or remove it, as needed.
            this.contratoTableAdapter.Fill(this.protankDataSet1.contrato);
            // TODO: This line of code loads data into the 'protankDataSet1.empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.protankDataSet1.empleado);
            
        }

        private void Modulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
