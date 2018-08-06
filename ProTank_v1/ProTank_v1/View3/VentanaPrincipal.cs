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
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            NewPerson fh = new NewPerson(false, true);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
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
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            NewPerson fh = new NewPerson(true, true);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }
    }
}
