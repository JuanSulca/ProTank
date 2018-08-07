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

        public NewPerson(bool empleado, String id)
        {
            InitializeComponent();
            ac = true;
            if (empleado)
            {
                Empleado e = new Empleado().getEmpleado(id);
                textBox4.Text = e.fname;
                textBox1.Text = e.lname;
                textBox2.Text = e.id;
                textBox3.Text = e.tel;
                textBox5.Text = e.cel;
            }
            else
            {
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
            if(nombres == "" || apellido == "" || cedula == "")
            {
                MessageBox.Show("Campos sin llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
