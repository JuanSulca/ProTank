using ProTank_v1.Model;
using ProTank_v1.View3;
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
        private VentanaPrincipal principal;

        public GenerarAforo(VentanaPrincipal p)
        {
            InitializeComponent();
            this.principal = p;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double diametro = (double)numericUpDownDiametro.Value;
            string unidadL = comboBoxDiametro.SelectedItem.ToString();
            string unidadV = comboBoxVolumen.SelectedItem.ToString();
            double longitud = (double)numericUpDownLongitud.Value;
            double cabeza = (double)numericUpDownCabeza.Value;
            int paso = (int)numericUpDownPaso.Value;
            int iteraciones = (int)numericUpDownIteraciones.Value;
            this.tablaDeAforo = TablaDeAforo.tablaAforo(diametro, unidadL, longitud, unidadL, cabeza, unidadL, unidadV, paso, iteraciones);
            if (tablaDeAforo.Rows.Count > 0)
            {
                MessageBox.Show("Tabla generada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                principal.tablaDeAforo = this.tablaDeAforo;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un problema al generar la tabla de aforo.\nRevise los parámetros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
