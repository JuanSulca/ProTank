using ProTank_v1.Model;
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
    public partial class PesoTanques : Form
    {
        public PesoTanques()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = TablaDeAforo.superficieTanque((double)numericUpDownLon.Value, (double)numericUpDownDia.Value, (int)numericUpDownNum.Value) + string.Empty;
        }
    }
}
