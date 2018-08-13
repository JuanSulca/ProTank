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
                MessageBox.Show("Faltan campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ac)
                {
                    Boolean b = new Herramienta().upHerramienta(nombre, Convert.ToInt32(cantidad), codigo, Convert.ToInt32(periodo));
                    if (b)
                        MessageBox.Show("Actualización Exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Actualización Fallida!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
