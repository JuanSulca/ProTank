﻿using ProTank_v1.Model;
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
    public partial class NewPrestamo : Form
    {

        Boolean ac = false;
        public NewPrestamo()
        {
            InitializeComponent();
        }

        public NewPrestamo(String idE, String codigoH, DateTime fechaP, Boolean returned, int cantidad)
        {
            this.ac = true;
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add(new ComItem(codigoH, codigoH));
            comboBox2.Items.Clear();
            comboBox2.Items.Add(new ComItem(idE, idE));
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            numericUpDown1.Value = cantidad;
            numericUpDown1.Enabled = false;
            checkRet.Checked = returned;
            label2.Text = "Modificar Préstamo";
            button1.Text = "Modificar Préstamo";
        }

        public NewPrestamo(String idE, String codigoH, DateTime fechaP, Boolean returned, int cantidad, Boolean locked)
        {
            this.ac = true;
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add(new ComItem(codigoH, codigoH));
            comboBox2.Items.Clear();
            comboBox2.Items.Add(new ComItem(idE, idE));
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            numericUpDown1.Value = cantidad;
            numericUpDown1.Enabled = false;
            checkRet.Checked = returned;
            checkRet.Enabled = false;
            button1.Visible = false;
            label2.Text = "Préstamo";
        }

        private void NewPerstamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void NewPrestamo_Load(object sender, EventArgs e)
        {
            if (!ac)
            {
                DataTable dt = new Herramienta().tableHerramientasPrestar();
                foreach(DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(new ComItem(dr["codigoH"] + " " + dr["nombre"], dr["codigoH"].ToString().Trim()));
                }
                DataTable dt2 = new Empleado().tableEmpleado();
                foreach (DataRow dr in dt2.Rows)
                {
                    comboBox2.Items.Add(new ComItem(dr["idE"] + " " + dr["fname"] + " " + dr["lname"], dr["idE"].ToString().Trim()));
                }
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codigoH = (comboBox1.SelectedItem as ComItem).value;
            String idE = (comboBox2.SelectedItem as ComItem).value;
            int cantidad = (int)numericUpDown1.Value;
            Boolean returned = checkRet.Checked;
            DateTime date = DateTime.Now;
            if (ac)
            {
                if (new Prestamo().upPrestamo(codigoH, idE, returned))
                    MessageBox.Show("Modificación exitosa!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Modificación Fallida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (new Prestamo().insPrestamo(codigoH, idE, date, cantidad, returned))
                    MessageBox.Show("Registro exitoso!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Registro Fallido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ac) {
                DataTable dt = new Herramienta().tableHerramientasPrestar();
                DataRow[] r = dt.Select("[codigoH] = '" + (comboBox1.SelectedItem as ComItem).value + "'");
                try
                {
                    numericUpDown1.Maximum = Convert.ToInt32(r[0]["disponibles"]);
                } catch {

                }
            }
        }
    }
}
