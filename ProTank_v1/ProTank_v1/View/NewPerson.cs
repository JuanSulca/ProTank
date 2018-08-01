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
    public partial class NewPerson : Form
    {
        Boolean empleado = false;
        public NewPerson(Boolean empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
        }

        private void NewPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombres = textBox4.Text;
            String apellido = textBox1.Text;
            String cedula = textBox2.Text;
            String telefono = textBox3.Text;
            String celular = textBox5.Text;
            if(nombres == "" || apellido == "" || cedula == "")
            {
                MessageBox.Show("Campos sin llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!empleado)
                {
                    protankDataSetTableAdapters.personTableAdapter tb = new protankDataSetTableAdapters.personTableAdapter();
                    tb.Insert(nombres, apellido, cedula, telefono, celular);
                }
                else
                {
                    protankDataSetTableAdapters.empleadoTableAdapter tb = new protankDataSetTableAdapters.empleadoTableAdapter();
                    tb.Insert(nombres, apellido, cedula, telefono, celular);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
