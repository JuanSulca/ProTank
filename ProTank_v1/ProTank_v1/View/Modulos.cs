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
            dateModulos_Herramientas_tabPrestamos_horaFecha.Value = DateTime.Today;
        }

        private void Modulos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protankDataSet11.prestamosH' table. You can move, or remove it, as needed.
            this.prestamosHTableAdapter.Fill(this.protankDataSet11.prestamosH);
            // TODO: This line of code loads data into the 'protankDataSet1.herramienta' table. You can move, or remove it, as needed.
            this.herramientaTableAdapter.Fill(this.protankDataSet1.herramienta);
            // TODO: This line of code loads data into the 'protankDataSet1.prestamo' table. You can move, or remove it, as needed.
            this.prestamoTableAdapter.Fill(this.protankDataSet1.prestamo);
            // TODO: This line of code loads data into the 'protankDataSet.herramienta' table. You can move, or remove it, as needed.

        }

        private void Modulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dateModulos_Herramientas_tabPrestamos_horaFecha_ValueChanged(object sender, EventArgs e)
        {
            /*this.prestamoTableAdapter.Fill(this.protankDataSet1.prestamo);
            this.prestamoBindingSource.Filter = "Fecha=" + dateModulos_Herramientas_tabPrestamos_horaFecha.Value;*/
        }
    }
}
