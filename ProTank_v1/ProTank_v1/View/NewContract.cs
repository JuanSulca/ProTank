using ProTank_v1.View2;
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
    public partial class NewContract : Form
    {

        public Boolean ac = false;
        public Boolean mos = false;

        public NewContract()
        {
            ac = false;
            InitializeComponent();
        }

        public NewContract(String id, Boolean mos)
        {
            ac = true;
            this.mos = mos;
            InitializeComponent();

            button1.Text = "Modificar";
            textBox1.Text = id;
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idPersona = (comboBox1.SelectedItem as ComItem).value;
            decimal monto = numericUpDownMonto.Value;
            string idCon = textBox1.Text;
            int calificacion = (int) numericUpDown1.Value;
            string descripcion = textBox2.Text;
            DateTime fechaI = dateTimePicker1.Value;
            DateTime fechaF = dateTimePicker2.Value;
            if (idPersona == "" || monto == 0 || idCon == "")
            {
                MessageBox.Show("Existen campos sin llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isSuccess = false;
                if (ac)
                {
                    isSuccess = new Contrato().upContrato(idCon, monto, calificacion, fechaF, descripcion);
                    if (isSuccess)
                    {
                        MessageBox.Show("Actualización exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    isSuccess = new Contrato().insContrato(idPersona, monto, calificacion, idCon, descripcion, fechaI, fechaF);
                    if (isSuccess)
                    {
                        MessageBox.Show("Registro exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro fallido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void NewContract_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            auxCliente();
            comboBox1.SelectedIndex = 0;
        }

        private void auxCliente()
        {
            DataTable dataTable;
            comboBox1.Items.Clear();
            if (ac)
            {
                Contrato c = new Contrato().getContrato(textBox1.Text);
                dataTable = new Person().tablePerson(c.idPer);
                comboBox1.Items.Add(new ComItem(dataTable.Rows[0]["id"] + " " + dataTable.Rows[0]["fname"] + " " + dataTable.Rows[0]["lname"], dataTable.Rows[0]["id"] + ""));
                comboBox1.Enabled = false;
                dateTimePicker1.Value = c.fechaI;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Value = c.fechaE;
                numericUpDown1.Value = c.calificacion;
                numericUpDownMonto.Value = c.monto;
                textBox2.Text = c.descrip;
                if (mos)
                {
                    dateTimePicker2.Enabled = false;
                    numericUpDown1.Enabled = false;
                    numericUpDownMonto.Enabled = false;
                    textBox2.Enabled = false;
                    button1.Visible = false;
                    label2.Text = "Contrato";
                }
            }
            else
            {
                dataTable = new Person().tablePerson();
                foreach (DataRow dr in dataTable.Rows)
                {
                    comboBox1.Items.Add(new ComItem(dr["id"] + " " + dr["fname"] + " " + dr["lname"], dr["id"] + ""));
                }
            }
        }


    }
}
