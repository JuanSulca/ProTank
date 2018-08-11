using ProTank_v1.Model;
using ProTank_v1.View;
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

namespace ProTank_v1.View3
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        public VentanaPrincipal(String rol)
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //Registrar Usuario
        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            NewUser fh = new NewUser();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void buscarHerramientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            ControlDeHerramientas fh = new ControlDeHerramientas();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void calcularPesoDeTanqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            PesoTanques fh = new PesoTanques();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void calcularPosiciónDeTapasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            PosicionTapas fh = new PosicionTapas();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void registrarHerramientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            NewTool fh = new NewTool();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void ragistrarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            NewPrestamo fh = new NewPrestamo();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            NewPerson fh = new NewPerson(false,false);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select s = new Select(1, true);
            s.ShowDialog();
            String data = s.getData();
            if (data == "")
            {
                MessageBox.Show("Modificacion de usuario cancelada!");
            }
            else
            {
                if (this.panel3.Controls.Count > 0)
                    this.panel3.Controls.RemoveAt(0);
                NewPerson fh = new NewPerson(false, data);
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.Dock = DockStyle.Fill;
                this.panel3.Controls.Add(fh);
                this.panel3.Tag = fh;
                fh.Show();
            }
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            NewPerson fh = new NewPerson(true, false);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select s = new Select(0, true);
            s.ShowDialog();
            String data = s.getData();
            if (data == "")
            {

            }
            else
            {
                if (this.panel3.Controls.Count > 0)
                    this.panel3.Controls.RemoveAt(0);
                NewPerson fh = new NewPerson(true, data);
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.Dock = DockStyle.Fill;
                this.panel3.Controls.Add(fh);
                this.panel3.Tag = fh;
                fh.Show();
            }
        }

        //Remover Usuario
        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select s = new Select(2, false);
            s.ShowDialog();
            String data = s.getData();
            if (data == "")
            {
                MessageBox.Show("Eliminación de usuario cancelada!");
            }
            else
            {
                if (new User().delUser(data))
                {
                    MessageBox.Show("Eliminación de usuario exitosa!");
                }
                else
                {
                    MessageBox.Show("Eliminación de usuario fallida!");
                }
            }
        }

        //Modificar Datos de Usuario
        private void modificarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select s = new Select(2, true);
            s.ShowDialog();
            String data = s.getData();
            if (data == "")
            {
                MessageBox.Show("Modificación de cliente cancelada!");
            }
            else
            {
                User us = new User().getUser(data);
                if (this.panel3.Controls.Count > 0)
                    this.panel3.Controls.RemoveAt(0);
                NewUser fh = new NewUser(us.uname, us.rol);
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.Dock = DockStyle.Fill;
                this.panel3.Controls.Add(fh);
                this.panel3.Tag = fh;
                fh.Show();
            }
        }

        private void removerClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select s = new Select(1, false);
            s.ShowDialog();
            String data = s.getData();
            if (data == "")
            {
                //MessageBox.Show("Eliminación de cliente cancelada!");
            }
            else
            {
                DialogResult r = MessageBox.Show("Desea eliminar el Cliente: " + data + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r.Equals(DialogResult.Yes))
                {
                    if (new Person().delPerson(data))
                    {
                        MessageBox.Show("Eliminación de cliente exitosa!");
                    }
                    else
                    {
                        MessageBox.Show("Eliminación de cliente fallida!");
                    }
                }
            }
        }

        private void darDeBajaAEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select s = new Select(0, false);
            s.ShowDialog();
            String data = s.getData();
            if (data == "")
            {
                //MessageBox.Show("Eliminación de empleado cancelada!");
            }
            else
            {
                DialogResult r = MessageBox.Show("Desea eliminar el Empleado: " + data + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r.Equals(DialogResult.Yes))
                {
                    if (new Empleado().delEmpleado(data))
                    {
                        MessageBox.Show("Eliminación de empleado exitosa!");
                    }
                    else
                    {
                        MessageBox.Show("Eliminación de empleado fallida!");
                    }
                }
            }
        }

        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
        }

        //Mostrar Usuarios
        private void mostrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            MostrarUsuarios fh = new MostrarUsuarios();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select s = new Select(1);
            s.ShowDialog();
            String data = s.getData();
            if (data == "")
            {
                //MessageBox.Show("Modificacion de cliente cancelada!");
            }
            else
            {
                Person us = new Person().getPerson(data);
                if (this.panel3.Controls.Count > 0)
                    this.panel3.Controls.RemoveAt(0);
                NewPerson fh = new NewPerson(1, us.id);
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.Dock = DockStyle.Fill;
                this.panel3.Controls.Add(fh);
                this.panel3.Tag = fh;
                fh.Show();
            }
        }

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            MostrarEmpleados fh = new MostrarEmpleados();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void registrarNuevoContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            NewContract fh = new NewContract();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void editarContratoExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select s = new Select(3, true);
            s.ShowDialog();
            String data = s.getData();
            if (data == "")
            {
                //MessageBox.Show("Modificacion de cliente cancelada!");
            }
            else
            {
                if (this.panel3.Controls.Count > 0)
                    this.panel3.Controls.RemoveAt(0);
                NewContract fh = new NewContract(data);
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.Dock = DockStyle.Fill;
                this.panel3.Controls.Add(fh);
                this.panel3.Tag = fh;
                fh.Show();
            }
        }

        private void removerContratoDelRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select s = new Select(3, false);
            s.ShowDialog();
            String data = s.getData();
            if (data == "")
            {
                //MessageBox.Show("Modificacion de cliente cancelada!");
            }
            else
            {
                DialogResult r = MessageBox.Show("Desea eliminar el Contrato: " + data + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r.Equals(DialogResult.Yes))
                {
                    if (new Contrato().delContrato(data))
                    {
                        MessageBox.Show("Eliminación de contrato exitosa!");
                    }
                    else
                    {
                        MessageBox.Show("Eliminación de contrato fallida!");
                    }
                }
            }
        }

        private void mostrarContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Contratos fh = new Contratos();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void buscarContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select s = new Select(3, true);
            s.ShowDialog();
            String data = s.getData();
            if (data == "")
            {
                //MessageBox.Show("Modificacion de cliente cancelada!");
            }
            else
            {

            }
        }

        private void buscarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select s = new Select(0);
            s.ShowDialog();
            String data = s.getData();
            if (data == "")
            {
                //MessageBox.Show("Modificacion de cliente cancelada!");
            }
            else
            {
                Empleado us = new Empleado().getEmpleado(data);
                if (this.panel3.Controls.Count > 0)
                    this.panel3.Controls.RemoveAt(0);
                NewPerson fh = new NewPerson(0, us.id);
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.Dock = DockStyle.Fill;
                this.panel3.Controls.Add(fh);
                this.panel3.Tag = fh;
                fh.Show();
            }
        }

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            MostrarClientes fh = new MostrarClientes();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void mostrarHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            MostrarHerramientas fh = new MostrarHerramientas();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void mostrarMantenimientosUrgentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            MostrarPrestamos fh = new MostrarPrestamos();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void vistaPreliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            MostrarServicios fh = new MostrarServicios();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void mostrarMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            MostrarMateriales fh = new MostrarMateriales();
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

        private void parámetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarHerramientaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darDeBajaAHerrmientaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void próximosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void urgentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
