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
    public partial class NewTool : Form
    {
        Boolean ac = false;
        private int op = 0;
        public NewTool()
        {
            InitializeComponent();
            button1.Text = "Registrar";
        }

        public NewTool(String codigo, bool block)
        {
            InitializeComponent();
            ac = true;
            label2.Text = "Modificar Herramienta";
            DataTable dt = new Herramienta().tableHerramienta("codigoH", codigo);
            textBox2.Text = codigo;
            textBox2.Enabled = false;
            textBox4.Text = dt.Rows[0]["nombre"].ToString();
            numericUpDown1.Value = Convert.ToInt32(dt.Rows[0]["cantidad"].ToString());
            numericUpDown2.Value = Convert.ToInt32(dt.Rows[0]["periodo"].ToString());
            button1.Text = "Modificar";
            if (block)
            {
                textBox4.Enabled = false;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                button1.Visible = false;
                label2.Text = "Herramienta";
            }
            else
            {
                buttonModCant.Visible = true;
                numericUpDown1.Enabled = false;
            }
        }

        public NewTool(string opcion, string criterio, bool block)
        {
            InitializeComponent();
            ac = true;
            label2.Text = "Modificar Herramienta";
            DataTable dt = new Herramienta().tableHerramienta(opcion, criterio);
            if (dt.Rows.Count == 0)
            {
                if (opcion == "codigoH")
                {
                    opcion = "código";
                }
                else
                {
                    opcion = "nombre";
                }
                MessageBox.Show("No existe una herramienta registrada con ese " + opcion+".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                textBox2.Text = dt.Rows[0]["codigoH"].ToString();
                textBox2.Enabled = false;
                textBox4.Text = dt.Rows[0]["nombre"].ToString();
                numericUpDown1.Value = Convert.ToInt32(dt.Rows[0]["cantidad"].ToString());
                numericUpDown2.Value = Convert.ToInt32(dt.Rows[0]["periodo"].ToString());
                button1.Text = "Modificar";
                if (block)
                {
                    textBox4.Enabled = false;
                    numericUpDown1.Enabled = false;
                    numericUpDown2.Enabled = false;
                    button1.Visible = false;
                    label2.Text = "Herramienta";
                }
                else
                {
                    buttonModCant.Visible = true;
                    numericUpDown1.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = textBox4.Text;
            decimal cantidad = numericUpDown1.Value;
            String codigo = textBox2.Text;
            decimal periodo = numericUpDown2.Value;
            if (nombre == "" || cantidad == 0 || codigo == "")
            {
                MessageBox.Show("Faltan campos por llenar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(nombre.Length > 60)
            {
                MessageBox.Show("El nombre de la herramienta es muy largo. \nPor favor, ingrese un nombre de hasta 60 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if((numericUpDown1.Value % 1) != 0)
            {
                MessageBox.Show("La cantidad ingresada no es válida. \nPor favor, ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if((numericUpDown2.Value % 1) != 0)
            {
                MessageBox.Show("El periodo ingresado no es válido. \nPor favor, ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ac)
                {

                    if (op == 0)
                    {
                        Boolean b = new Herramienta().upHerramienta(nombre, Convert.ToInt32(cantidad), codigo, Convert.ToInt32(periodo));
                        if (b)
                            MessageBox.Show("Actualizacion Exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Actualizacion Fallida!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        if (comboBox1.SelectedIndex == 0)
                        {
                            cantidad += numericUpDown3.Value;
                        }
                        else
                        {
                            cantidad -= numericUpDown3.Value;
                        }
                        if ((numericUpDown3.Value % 1) != 0)
                        {
                            MessageBox.Show("La cantidad ingresada no es válida. \nPor favor, ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if ((numericUpDown2.Value % 1) != 0)
                        {
                            MessageBox.Show("El periodo ingresado no es válido. \nPor favor, ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }else if (cantidad <= 0)
                        {
                            MessageBox.Show("No se puede disminuir el número de existencias porque el número ingresado es mayor al número de herramientas disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Boolean b = new Herramienta().upHerramienta(nombre, Convert.ToInt32(cantidad), codigo, Convert.ToInt32(periodo));
                            if (b)
                                MessageBox.Show("Actualizacion Exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Actualizacion Fallida!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    Boolean b = new Herramienta().insHerramienta(nombre, Convert.ToInt32(cantidad), codigo, Convert.ToInt32(periodo));
                    if (b)
                        MessageBox.Show("Registro Exitoso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Registro Fallido!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void buttonModCant_Click(object sender, EventArgs e)
        {
            op = 1;
            buttonModCant.Visible = false;
            panel3.Visible = true;
            comboBox1.SelectedIndex = 0;
        }

        private void NewTool_Load(object sender, EventArgs e)
        {

        }
    }
}
