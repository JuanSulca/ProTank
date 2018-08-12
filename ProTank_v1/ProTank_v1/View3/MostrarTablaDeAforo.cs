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
    public partial class MostrarTablaDeAforo : Form
    {

        private DataTable data;

        public MostrarTablaDeAforo(DataTable tabla)
        {
            data = tabla;
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarTablaDeAforo_Load(object sender, EventArgs e)
        {
            tableModulos_Contratos_tabla.DataSource = data;
            tableModulos_Contratos_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
