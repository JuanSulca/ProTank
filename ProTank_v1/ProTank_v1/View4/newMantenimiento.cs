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
    public partial class newMantenimiento : Form
    {

        private int op = 0;
        public DataTable Table = new DataTable();

        public newMantenimiento()
        {
            InitializeComponent();
        }

        public newMantenimiento(int op)
        {
            this.op = op;
            InitializeComponent();
            if (op == 1)
            {
                button1.Text = "Siguiente";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codH = textBox2.Text;
            DateTime fechaI = dateTimePicker1.Value;
            int cantidad = (int)numericUpDown1.Value;
            if (codH == "")
            {
                MessageBox.Show("Por favor, ingrese un código de herramienta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dt = new Herramienta().tableHerramienta("codigoH", codH);
                if (dt.Rows.Count > 0)
                {
                    if (op == 0)
                    {
                        if (Convert.ToInt16(dt.Rows[0]["cantidad"].ToString()) >= cantidad)
                        {
                            bool isSucces = new Mantenimiento().insMantenimiento(codH, fechaI, cantidad);
                            if (isSucces)
                            {
                                MessageBox.Show("Mantenimiento registrado con éxito.", "Información");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El número de herramientas que ha ingresado es mayor al número de herramientas existentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        DataTable aux = new Mantenimiento().tableMantenimientoSW(dt.Rows[0]["codigoH"].ToString(),dateTimePicker1.Value);
                        if (aux.Rows.Count > 0)
                        {
                            this.Table = aux;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("La herramienta " + dt.Rows[0]["codigoH"].ToString() + " no se encuetra actualmente en mantenimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (op == 0)
                    {
                        MessageBox.Show("La herramienta no existe y por lo tanto no se puede ingresar a mantenimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("La herramienta no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newMantenimiento_Load(object sender, EventArgs e)
        {

        }

  
    }
}
