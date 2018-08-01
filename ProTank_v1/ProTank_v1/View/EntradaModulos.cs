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
    public partial class EntradaModulos : Form
    {
        public EntradaModulos(String rol)
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            if (rol.Contains('D'))
            {
                button5.Enabled = true;
            }
            if (rol.Contains('C'))
            {
                button4.Enabled = true;
            }
            if (rol.Contains('V'))
            {
                button3.Enabled = true;
            }
            if (rol.Contains('H'))
            {
                button2.Enabled = true;
            }
            if (rol.Contains('A'))
            {
                button1.Enabled = true;
            }
        }

        private void EntradaModulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamar a administracion
            Administracion a = new Administracion();
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Design d = new Design();
            d.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Contratos c = new Contratos();
            c.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentasYContratos v = new VentasYContratos();
            v.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlDeHerramientas c = new ControlDeHerramientas();
            c.ShowDialog();
        }
    }
}
