using ProTank_v1.Model;
using ProTank_v1.View2;
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
    public partial class NuevaVenta : Form
    {
        public NuevaVenta()
        {
            InitializeComponent();
        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new Material().tableMaterial2();
            Item.Items.Clear();
            Item.ValueType = typeof(ComItem);
            foreach (DataRow dr in dataTable.Rows)
            {
                Item.Items.Add(new ComItem(dr["nombre"] + " " + dr["unidad"], dr["codigo"] + ""));
            }
            dataTable = new Servicio().tableServicio2();
            foreach (DataRow dr in dataTable.Rows)
            {
                Item.Items.Add(new ComItem(dr["nombre"] + " " + dr["unidad"], dr["codigo"] + ""));
            }
        }
    }
}
