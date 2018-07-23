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
        public EntradaModulos()
        {
            InitializeComponent();
        }

        private void EntradaModulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Desing d = new Desing();
            d.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //llamar a contratos
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //llamar a herramientass
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamar a administracion
        }
    }
}
