﻿using ProTank_v1.Model;
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
                label8.Text = "Persona:";
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
                    comboBox2.Items.Add(new ComItem(dr["fname"] + " " + dr["lname"], dr["idE"] + ""));
                }
            }
            else if(tipo == 1)
            {
                dataTable = new Person().tablePerson();
                comboBox2.Items.Clear();
                foreach (DataRow dr in dataTable.Rows)
                {
                    comboBox2.Items.Add(new ComItem(dr["fname"] + " " + dr["lname"], dr["id"] + ""));
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