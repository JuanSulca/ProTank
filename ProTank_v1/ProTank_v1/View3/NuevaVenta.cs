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
            foreach (DataRow dr in dataTable.Rows)
            {
                Item.Items.Add(dr["codigo"] + "");
            }
            dataTable = new Servicio().tableServicio2();
            foreach (DataRow dr in dataTable.Rows)
            {
                Item.Items.Add(dr["codigo"] + "");
            }
        }

        private void tablaVentas_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //MessageBox.Show("Se agrego una fila");
        }

        private void tablaVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if(col == 0)
            {
                try
                {
                    String codigo = tablaVentas.Rows[row].Cells[1].Value.ToString();
                    if (codigo != "")
                    {
                        String cant = tablaVentas.Rows[row].Cells[0].Value.ToString();
                        int cantidad;
                        if (cant != "")
                        {
                            if (int.TryParse(cant, out cantidad))
                            {
                                DataTable dt = new Material().tableAll();
                                DataRow[] r = dt.Select("[codigo] = '" + codigo + "'");
                                decimal precioU = Convert.ToDecimal(r[0]["precio"].ToString());
                                decimal precio = precioU * cantidad;
                                tablaVentas.Rows[row].Cells[2].Value = precioU;
                                tablaVentas.Rows[row].Cells[3].Value = precio;
                                decimal total = 0;
                                foreach (DataGridViewRow ro in tablaVentas.Rows)
                                {
                                    if (ro.Cells[3].Value != null)
                                    {
                                        total += Convert.ToDecimal(ro.Cells[3].Value.ToString());
                                    }
                                }
                                textBox1.Text = total + "";
                            }
                            else
                            {
                                MessageBox.Show("Cantidad solo puede ser numerica!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }catch
                {

                }
            }
            else if(col == 1)
            {
                try
                {
                    String cant = tablaVentas.Rows[row].Cells[0].Value.ToString();
                    int cantidad;
                    if (cant != "")
                    {
                        if (int.TryParse(cant, out cantidad))
                        {
                            String codigo = tablaVentas.Rows[row].Cells[1].Value.ToString();
                            DataTable dt = new Material().tableAll();
                            DataRow[] r = dt.Select("[codigo] = '" + codigo + "'");
                            decimal precioU = Convert.ToDecimal(r[0]["precio"].ToString());
                            decimal precio = precioU * cantidad;
                            tablaVentas.Rows[row].Cells[2].Value = precioU;
                            tablaVentas.Rows[row].Cells[3].Value = precio;
                            decimal total = 0;
                            foreach(DataGridViewRow ro in tablaVentas.Rows)
                            {
                                if (ro.Cells[3].Value != null)
                                {
                                    total += Convert.ToDecimal(ro.Cells[3].Value.ToString());
                                }
                            }
                            textBox1.Text = total + "";
                        }
                        else
                        {
                            MessageBox.Show("Cantidad solo puede ser numerica!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }catch
                {
                    
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
