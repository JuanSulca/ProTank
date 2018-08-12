using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProTank_v1.View2
{
    public partial class GenerarAforo : Form
    {

        public DataTable tablaDeAforo = new DataTable();

        public GenerarAforo()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void GenerarAforo_Load(object sender, EventArgs e)
        {
            numericUpDownPaso.Maximum = 1;
            numericUpDownIteraciones.Maximum = 1;
            comboBoxDiametro.SelectedIndex = 0;
            comboBoxVolumen.SelectedIndex = 0;
        }
        

        private void numericUpDownPaso_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                numericUpDownIteraciones.Maximum = numericUpDownDiametro.Value / numericUpDownPaso.Value;
            }
            catch
            {

            }
        }

        private void numericUpDownDiametro_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                numericUpDownPaso.Maximum = numericUpDownDiametro.Value;
                numericUpDownCabeza.Maximum = numericUpDownDiametro.Value / 2;
            }
            catch
            {

            }
        }
    }
}
