using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProTank_v1.View4
{
    public partial class BusquedaAux : Form
    {

        private int op =0;
        public string Opcion { get; set; }
        public string Criterio { get; set; }
        private int aux = 0;
        private bool mant = false;
        public DateTime min = new DateTime();
        public DateTime max = new DateTime();

        public BusquedaAux(int op)
        {
            this.op = op;
            this.Opcion = "";
            this.Criterio = "";
            InitializeComponent();
            if (op == 1)
            {
                label8.Visible = false;
                aux = 1;
                comboBox2.Enabled = false;
                button10.Text = "Eliminar";
            }else if (op == 2)
            {
                label8.Visible = false;
                button10.Text = "Modificar";
            }
        }

        public BusquedaAux(bool mant)
        {
            this.mant = mant;
            InitializeComponent();
        }

        private void BusquedaAux_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = aux;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (mant)
            {
                DateTime dateMin = dateTimePicker1.Value;
                DateTime dateMax = dateTimePicker2.Value;
                if (dateMin > dateMax)
                {
                    MessageBox.Show("La fecha de inicio es menor a la fecha de fin. Por favor ingrese fechas válidas.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    this.min = dateMin;
                    this.max = dateMax;
                    this.Close();
                }
            }
            else
            {
                string criterio = textBox1.Text;
                string opcion = comboBox2.SelectedItem.ToString();
                if (criterio == "")
                {
                    MessageBox.Show("Por favor, ingrese un criterio de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (opcion == "Código")
                    {
                        opcion = "codigoH";
                    }
                    this.Opcion = opcion;
                    this.Criterio = criterio;
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            panelFechas.Visible = mant;
            panel1.Visible = !mant;
        }
    }
}
