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
    public partial class Servicios : Form
    {
        Boolean prod = false;
        Boolean ac = false;
        public Servicios(Boolean prod)
        {
            InitializeComponent();
            this.prod = prod;
            if (prod)
            {
                label2.Text = "Registrar Producto";
            }
            else
            {
                label2.Text = "Registrar Servicio";
            }
        }

        public Servicios(Boolean prod, String codigo)
        {
            this.ac = true;
            this.prod = prod;
            InitializeComponent();
            DataTable dt;
            if (prod)
            {
                dt = new Material().tableMaterial2();
                label2.Text = "Modificar Producto";
            }
            else {
                dt = new Servicio().tableServicio2();
                label2.Text = "Modificar Servicio";
            }
            DataRow[] r = dt.Select("[codigo] = '" + codigo + "'");
            textBox1.Text = r[0]["nombre"].ToString();
            textBox1.Enabled = false;
            textBox2.Text = r[0]["codigo"].ToString();
            textBox2.Enabled = false;
            numericUpDown1.Value = Convert.ToDecimal(r[0]["precio"]);
            textBox4.Text = r[0]["unidad"].ToString().Trim();
            button1.Text = "Modificar";
        }

        public Servicios(Boolean prod, String codigo, Boolean locked)
        {
            this.ac = true;
            this.prod = prod;
            InitializeComponent();
            DataTable dt;
            if (prod)
            {
                dt = new Material().tableMaterial2();
                label2.Text = "Producto";
            }
            else
            {
                dt = new Servicio().tableServicio2();
                label2.Text = "Servicio";
            }
            DataRow[] r = dt.Select("[codigo] = '" + codigo + "'");
            textBox1.Text = r[0]["nombre"].ToString();
            textBox1.Enabled = false;
            textBox2.Text = r[0]["codigo"].ToString();
            textBox2.Enabled = false;
            numericUpDown1.Value = Convert.ToDecimal(r[0]["precio"]);
            numericUpDown1.Enabled = false;
            textBox4.Text = r[0]["unidad"].ToString().Trim();
            textBox4.Enabled = false;
            button1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String codigo = textBox2.Text;
            decimal precio = numericUpDown1.Value;
            String unidad = textBox4.Text;
            if (nombre == "" || codigo == "" || unidad == "")
            {
                MessageBox.Show("Faltan campos por llenar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (prod)
                {
                    if (ac)
                    {
                        if (new Material().upMaterial(codigo, nombre, precio, unidad))
                        {
                            MessageBox.Show("Modificacion Exitosa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Modificacion Fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (new Material().insMaterial(codigo, nombre, precio, unidad))
                        {
                            MessageBox.Show("Registro Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registro Fallido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (ac)
                    {
                        if (new Servicio().upServicio(codigo, nombre, precio, unidad))
                        {
                            MessageBox.Show("Modificacion Exitosa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Modificacion Fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (new Servicio().insServicio(codigo, nombre, precio, unidad))
                        {
                            MessageBox.Show("Registro Exitoso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registro Fallido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
