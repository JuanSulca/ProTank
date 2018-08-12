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

namespace ProTank_v1.View2
{
    public partial class Select : Form
    {
        //public Select()
        //{
        //    InitializeComponent();
        //}

        public int tipo;
        public Boolean ac;
        public String data = "";
        public int mod;

        public Select(int mod)
        {
            tipo = mod;
            InitializeComponent();
            this.mod = mod;
            if (mod == 0)
            {
                label8.Text = "Empleado:";
                button10.Text = "Mostrar";
            }
            else if (mod == 1)
            {
                label8.Text = "Cliente:";
                button10.Text = "Mostrar";
            }
            else if (mod == 2)
            {
                label8.Text = "Usuario:";
                button10.Text = "Mostrar";
            }
            else if (mod == 3)
            {
                label8.Text = "Contrato:";
                button10.Text = "Mostrar";
            }
            else if (tipo == 4)
            {
                label8.Text = "Herramienta:";
                button10.Text = "Mostrar";
            }
            else if (tipo == 5)
            {
                label8.Text = "Prestamo:";
                button10.Text = "Mostrar";
            }
            tipo = mod;
        }

        public Select(int tipo, Boolean ac)
        {
            this.tipo = tipo;
            this.ac = ac;
            InitializeComponent();
            if (tipo == 0)
            {
                label8.Text = "Empleado:";
                if (ac)
                {
                    button10.Text = "Modificar";
                }
                else
                {
                    button10.Text = "Eliminar";
                }
            }
            else if(tipo == 1)
            {
                label8.Text = "Cliente:";
                if (ac)
                {
                    button10.Text = "Modificar";
                }
                else
                {
                    button10.Text = "Eliminar";
                }
            }
            else if(tipo == 2)
            {
                label8.Text = "Usuario:";
                if (ac)
                {
                    button10.Text = "Modificar";
                }
                else
                {
                    button10.Text = "Eliminar";
                }
            }
            else if (tipo == 3)
            {
                label8.Text = "Contrato:";
                if (ac)
                {
                    button10.Text = "Modificar";
                }
                else
                {
                    button10.Text = "Eliminar";
                }
            }
            else if (tipo == 4)
            {
                label8.Text = "Herramienta:";
                if (ac)
                {
                    button10.Text = "Modificar";
                }
                else
                {
                    button10.Text = "Eliminar";
                }
            }
            else if (tipo == 5)
            {
                label8.Text = "Prestamo:";
                if (ac)
                {
                    button10.Text = "Modificar";
                }
                else
                {
                    button10.Text = "Eliminar";
                }
            }
        }

        public String getData()
        {
            return data;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            data = (comboBox2.SelectedItem as ComItem).value;
            this.Close();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            DataTable dataTable;
            if (tipo == 0)
            {
                dataTable = new Empleado().tableEmpleado();
                comboBox2.Items.Clear();
                foreach (DataRow dr in dataTable.Rows)
                {
                    comboBox2.Items.Add(new ComItem(dr["idE"] + " " + dr["fname"] + " " + dr["lname"], dr["idE"] + ""));
                }
            }
            else if (tipo == 1)
            {
                dataTable = new Person().tablePerson();
                comboBox2.Items.Clear();
                foreach (DataRow dr in dataTable.Rows)
                {
                    comboBox2.Items.Add(new ComItem(dr["id"] + " " + dr["fname"] + " " + dr["lname"], dr["id"] + ""));
                }
            }
            else if (tipo == 2)
            {
                dataTable = new User().tableUser();
                comboBox2.Items.Clear();
                foreach (DataRow dr in dataTable.Rows)
                {
                    comboBox2.Items.Add(new ComItem(dr["uname"] + " " + dr["rol"], dr["uname"] + ""));
                }
            }
            else if (tipo == 3)
            {
                dataTable = new Contrato().tableContrato();
                comboBox2.Items.Clear();
                foreach (DataRow dr in dataTable.Rows)
                {
                    comboBox2.Items.Add(new ComItem(dr["idCon"] + " " + dr["idPer"] + " $" + dr["monto"], dr["idCon"] + ""));
                }
            }
            else if (tipo == 4)
            {
                dataTable = new Herramienta().tableHerramienta();
                comboBox2.Items.Clear();
                foreach (DataRow dr in dataTable.Rows)
                {
                    comboBox2.Items.Add(new ComItem(dr["codigoH"] + " " + dr["nombre"] + " " + dr["cantidad"], dr["codigoH"].ToString().Trim()));
                }
            }
            else if (tipo == 5)
            {
                dataTable = new Prestamo().tablePrestamo();
                comboBox2.Items.Clear();
                foreach (DataRow dr in dataTable.Select("[Devuelto] = false"))
                {
                    comboBox2.Items.Add(new ComItem(dr["Herramienta"] + " " + dr["Empleado"] + " " + dr["Fecha de préstamo"] + " " + dr["Cantidad"].ToString().Trim(), dr["Herramienta"] + ";" + dr["Empleado"] + ";" + dr["Fecha de préstamo"] + ";" + dr["Devuelto"] + ";" + dr["Cantidad"]));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = "";
            this.Close();
        }
    }

    public class ComItem
    {
        public String text { set; get; }
        public String value { set; get; }

        public ComItem(String text, String value)
        {
            this.text = text;
            this.value = value;
        }

        public override string ToString()
        {
            return text;
        }
    }
}
