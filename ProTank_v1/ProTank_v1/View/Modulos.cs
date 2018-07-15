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
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
        }

        private void Modulos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protankDataSet.herramienta' table. You can move, or remove it, as needed.
            this.herramientaTableAdapter.Fill(this.protankDataSet.herramienta);

        }
    }
}
