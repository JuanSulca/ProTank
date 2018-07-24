using System;
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
    public partial class Contratos : Form
    {
        public Contratos()
        {
            InitializeComponent();
        }

        private void btnModulos_NuevoUsuario_nuevaPersona_Click(object sender, EventArgs e)
        {
            NewPerson p = new NewPerson();
            p.ShowDialog();
        }

        private void btnModulos_Contratos_ingresarContrato_Click(object sender, EventArgs e)
        {
            NewContract c = new NewContract();
            c.ShowDialog();
        }

        private void btnModulos_Contratos_editarContrato_Click(object sender, EventArgs e)
        {
            NewContract c = new NewContract();
            c.ShowDialog();
        }
    }
}
