﻿using System;
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
        public NewPrestamo()
        {
            InitializeComponent();
        }

        private void NewPerstamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void NewPrestamo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protankDataSet1.empleado' table. You can move, or remove it, as needed.
            //this.empleadoTableAdapter.Fill(this.protankDataSet1.empleado);
            // TODO: This line of code loads data into the 'protankDataSet1.herramienta' table. You can move, or remove it, as needed.
            //this.herramientaTableAdapter.Fill(this.protankDataSet1.herramienta);

        }
    }
}
