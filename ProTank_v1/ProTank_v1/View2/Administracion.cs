using ProTank_v1.View2;
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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void dateModulos_Herramientas_tabPrestamos_horaFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnModulos_Herramientas_tabInventario_buscarHerramienta_Click(object sender, EventArgs e)
        {

        }

        private void txtModulos_Herramientas_tabInventario_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModulos_NuevoUsuario_nuevaPersona_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson();
            p.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson();
            p.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson();
            p.ShowDialog();
        }

        private void btn_Modulos_Empleados_editarEmpleado_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson();
            p.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson();
            p.ShowDialog();
        }

        private void Administracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser n = new NewUser();
            n.ShowDialog();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protankDataSet.person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.protankDataSet.person);
            // TODO: This line of code loads data into the 'protankDataSet.empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.protankDataSet.empleado);

        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
