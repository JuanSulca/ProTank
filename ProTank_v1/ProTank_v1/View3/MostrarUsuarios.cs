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
    public partial class MostrarUsuarios : Form
    {
        public MostrarUsuarios()
        {
            InitializeComponent();
        }

        private void MostrarUsuarios_Load(object sender, EventArgs e)
        {
            listarUsuarios();
        }

        private void listarUsuarios()
        {
            DataTable dataTable = new User().tableUser();
            tableModulos_Contratos_tabla.DataSource = dataTable;
            tableModulos_Contratos_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
