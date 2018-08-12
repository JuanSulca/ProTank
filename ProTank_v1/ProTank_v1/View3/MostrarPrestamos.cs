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

namespace ProTank_v1.View3
{
    public partial class MostrarPrestamos : Form
    {
        int index = 0;
        public MostrarPrestamos(int i)
        {
            index = i;
            InitializeComponent();
        }

        private void MostrarPrestamos_Load(object sender, EventArgs e)
        {
            listarPrestamos();
        }

        private void listarPrestamos()
        {
            if (index == 0)
            {
                DataTable dataTable = new Prestamo().tablePrestamo();
                tableModulos_Contratos_tabla.DataSource = dataTable;
            }
            else if(index == 1)
            {
                DataTable dataTable = new Prestamo().tablePrestamo1();
                tableModulos_Contratos_tabla.DataSource = dataTable;
            }
            else if(index == 2)
            {
                DataTable dataTable = new Prestamo().tablePrestamo2();
                tableModulos_Contratos_tabla.DataSource = dataTable;
            }
            tableModulos_Contratos_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
