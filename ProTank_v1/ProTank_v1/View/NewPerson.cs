using ProTank_v1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        Boolean ac = false;
        Validacion v = new Validacion();

        public NewPerson(int mod, String id)
        {
            InitializeComponent();
            if (mod == 0)
            {
                Empleado e = new Empleado().getEmpleado(id);
                textBox4.Text = e.fname;
                textBox1.Text = e.lname;
                textBox2.Text = e.id;
                textBox3.Text = e.tel;
                textBox5.Text = e.cel;
                empleado = true;
            }
            else if(mod == 1)
            {
                Person e = new Person().getPerson(id);
                textBox4.Text = e.fname;
                textBox1.Text = e.lname;
                textBox2.Text = e.id;
                textBox3.Text = e.tel;
                textBox5.Text = e.cel;
                empleado = false;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button1.Visible = false;
        }

        public NewPerson(bool empleado, String id)
        {
            InitializeComponent();
            ac = true;
            this.empleado = empleado;
            if (empleado)
            {
                label2.Text = "Actualizar Empleado";
                Empleado e = new Empleado().getEmpleado(id);
                textBox4.Text = e.fname;
                textBox1.Text = e.lname;
                textBox2.Text = e.id;
                textBox3.Text = e.tel;
                textBox5.Text = e.cel;
            }
            else
            {
                label2.Text = "Actualizar Cliente";
                Person e = new Person().getPerson(id);
                textBox4.Text = e.fname;
                textBox1.Text = e.lname;
                textBox2.Text = e.id;
                textBox3.Text = e.tel;
                textBox5.Text = e.cel;
            }
        }

        public NewPerson(bool empleado, bool ac)
        {
            InitializeComponent();
            this.empleado = empleado;
            this.ac = ac;
            if (empleado)
            {
                if (ac)
                {
                    label2.Text = "Actualizar Empleado";
                }
                else
                {
                    label2.Text = "Nuevo Empleado";
                }
            }
            else
            {
                if (ac)
                {
                    label2.Text = "Actualizar Cliente";
                }
                else
                {
                    label2.Text = "Nuevo Cliente";
                }
            }
        }
        

        private void NewPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombres = textBox4.Text;
            String apellido = textBox1.Text;
            String cedula = textBox2.Text;
            String telefono = textBox3.Text;
            String celular = textBox5.Text;
            string mensajeDeError = v.validarCedula(cedula);
            if(telefono != "")
            {
                mensajeDeError += v.validarTelefono(telefono);
            }
            if(celular != "")
            {
                mensajeDeError += v.validarCelular(celular);
            }
            if (nombres == "" || apellido == "" || cedula == "")
            {
                MessageBox.Show("Campos sin llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(mensajeDeError != "")
            {
                MessageBox.Show(mensajeDeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (empleado)
                {
                    if (ac)
                    {
                        bool succesAc = new Empleado().upEmpleado(nombres, apellido, cedula, telefono, celular);
                        if (succesAc)
                        {
                            MessageBox.Show("Actualización exitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Actualización fallida!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        bool succesIns = new Empleado().insEmpleado(nombres, apellido, cedula, telefono, celular);
                        if (succesIns)
                        {
                            MessageBox.Show("Registro exitoso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registro fallido!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if (ac)
                    {
                        bool successAc = new Person().upPerson(nombres, apellido, cedula, telefono, celular);
                        if (successAc)
                        {
                            MessageBox.Show("Actualizacion exitosa!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Actualizacion fallida!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        bool succesIns = new Person().insPerson(nombres, apellido, cedula, telefono, celular);
                        if (succesIns)
                        {
                            MessageBox.Show("Registro exitoso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registro fallido!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 164 && e.KeyChar != 165 && e.KeyChar !=32)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
