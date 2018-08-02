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

        public NewPerson(Boolean empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
            if (empleado)
            {
                label2.Text = "Nuevo Empleado";
            }
            else
            {
                label2.Text = "Nueva Cliente";
            }
        }

        public NewPerson(Boolean empleado, String nombre, String apellido, String cedula, String tel, String cel)
        {
            InitializeComponent();
            this.empleado = empleado;
            if (empleado)
            {
                label2.Text = "Actualizar Empleado";
            }
            else
            {
                label2.Text = "Actualizar Cliente";
            }
            textBox4.Text = nombre;
            textBox1.Text = apellido;
            textBox2.Text = cedula;
            textBox3.Text = tel;
            textBox5.Text = cel;
            this.ac = true;
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
                    if (ac)
                    {
                        protankDataSetTableAdapters.personTableAdapter tb = new protankDataSetTableAdapters.personTableAdapter();
                        SqlConnection cnx = tb.Connection;
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE person SET fname = @fname ,lname = @lname, id = @id, telef = @telef, cel = @cel WHERE id = @id", cnx);
                        cmd.Parameters.AddWithValue("@fname", nombres);
                        cmd.Parameters.AddWithValue("@lname", apellido);
                        cmd.Parameters.AddWithValue("@id", cedula);
                        cmd.Parameters.AddWithValue("@telef", telefono);
                        cmd.Parameters.AddWithValue("@cel", celular);
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Actualizacion exitosa!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Actualizacion fallida!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        cnx.Close();
                    }
                    else
                    {
                        protankDataSetTableAdapters.personTableAdapter tb = new protankDataSetTableAdapters.personTableAdapter();
                        tb.Insert(nombres, apellido, cedula, telefono, celular);
                    }
                }
                else
                {
                    if (ac)
                    {
                        protankDataSetTableAdapters.empleadoTableAdapter tb = new protankDataSetTableAdapters.empleadoTableAdapter();
                        SqlConnection cnx = tb.Connection;
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE empleado SET fname = @fname ,lname = @lname, idE = @id, telef = @telef, cel = @cel WHERE idE = @id", cnx);
                        cmd.Parameters.AddWithValue("@fname", nombres);
                        cmd.Parameters.AddWithValue("@lname", apellido);
                        cmd.Parameters.AddWithValue("@id", cedula);
                        cmd.Parameters.AddWithValue("@telef", telefono);
                        cmd.Parameters.AddWithValue("@cel", celular);
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Actualizacion exitosa!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Actualizacion fallida!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        cnx.Close();
                        MessageBox.Show("Registro exitoso!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        protankDataSetTableAdapters.empleadoTableAdapter tb = new protankDataSetTableAdapters.empleadoTableAdapter();
                        tb.Insert(nombres, apellido, cedula, telefono, celular);
                    }
                }
            }
            if (!ac)
            {
                MessageBox.Show("Registro exitoso!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
