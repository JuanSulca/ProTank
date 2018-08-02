using ProTank_v1.View2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            NewPerson p = new NewPerson(true);
            p.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson(true);
            p.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson(true);
            p.ShowDialog();
        }

        private void btn_Modulos_Empleados_editarEmpleado_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson(true);
            p.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson(false);
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
            this.userLoginTableAdapter.Fill(this.protankDataSet.userLogin);
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protankDataSet.userLogin' table. You can move, or remove it, as needed.
            this.userLoginTableAdapter.Fill(this.protankDataSet.userLogin);
            // TODO: This line of code loads data into the 'protankDataSet.userEmpleado' table. You can move, or remove it, as needed.
            this.userEmpleadoTableAdapter.Fill(this.protankDataSet.userEmpleado);
            // TODO: This line of code loads data into the 'protankDataSet.crearUsuario' table. You can move, or remove it, as needed.
            this.crearUsuarioTableAdapter.Fill(this.protankDataSet.crearUsuario);
            // TODO: This line of code loads data into the 'protankDataSet.person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.protankDataSet.person);
            // TODO: This line of code loads data into the 'protankDataSet.empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.protankDataSet.empleado);

        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson(true);
            p.ShowDialog();
            this.empleadoTableAdapter.Fill(this.protankDataSet.empleado);
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson(false);
            p.ShowDialog();
            this.personTableAdapter.Fill(this.protankDataSet.person);
        }

        private void darDeBajaAEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String fname = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            String lname = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            String id = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            String tel = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            String cel = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            protankDataSetTableAdapters.empleadoTableAdapter tba = new protankDataSetTableAdapters.empleadoTableAdapter();
            try
            {
                tba.Delete(fname, lname, id, tel, cel);
                MessageBox.Show("Empleado eliminado exitosamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.empleadoTableAdapter.Fill(this.protankDataSet.empleado);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Empleado posee conecciones con otra tablas", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removerClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String fname = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            String lname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            String id = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            String tel = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            String cel = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            protankDataSetTableAdapters.personTableAdapter tba = new protankDataSetTableAdapters.personTableAdapter();
            try
            {
                tba.Delete(fname, lname, id, tel, cel);
                MessageBox.Show("Cliente eliminado exitosamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.personTableAdapter.Fill(this.protankDataSet.person);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente posee conecciones con otra tablas", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String fname = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            String lname = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            String id = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            String tel = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            String cel = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            MessageBox.Show(fname + lname + id + tel + cel);
            NewPerson p = new NewPerson(true, fname, lname, id, tel, cel);
            p.ShowDialog();
            this.empleadoTableAdapter.Fill(this.protankDataSet.empleado);
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String fname = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            String lname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            String id = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            String tel = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            String cel = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            NewPerson p = new NewPerson(false, fname, lname, id, tel, cel);
            p.ShowDialog();
            this.personTableAdapter.Fill(this.protankDataSet.person);
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String uname = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult res = MessageBox.Show("Desea eliminar el resgistro?" + uname, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.Equals(DialogResult.Yes))
            {
                protankDataSetTableAdapters.userLoginTableAdapter tb = new protankDataSetTableAdapters.userLoginTableAdapter();
                SqlConnection cnx = tb.Connection;
                cnx.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM userLogin WHERE uname = @uname", cnx);
                cmd.Parameters.AddWithValue("@fname", uname);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Usuario eliminado exitosamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario eliminado exitosamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.userLoginTableAdapter.Fill(this.protankDataSet.userLogin);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userLoginTableAdapter.FillBy(this.protankDataSet.userLogin);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void modificarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String uname = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            String rol = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            NewUser n = new NewUser(uname, rol);
            n.ShowDialog();
            this.userLoginTableAdapter.Fill(this.protankDataSet.userLogin);
        }
    }
}
