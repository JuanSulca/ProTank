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
    public partial class MostrarClientes : Form
    {
        public MostrarClientes()
        {
            InitializeComponent();
        }

        private void MostrarClientes_Load(object sender, EventArgs e)
        {
            listarClientes();
            tableModulos_Contratos_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void listarClientes()
        {
            DataTable dataTable = new Person().tablePerson2();
            tableModulos_Contratos_tabla.DataSource = dataTable;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
