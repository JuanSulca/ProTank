using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProTank_v1.View4
{
    public partial class comMantenimiento : Form
    {

        private DataTable source;

        public comMantenimiento(DataTable dt)
        {
            this.source = dt;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isSuccess = new Mantenimiento().upMantenimiento(source.Rows[0]["codigoH"].ToString(), Convert.ToDateTime(source.Rows[0]["fechaIngreso"].ToString()), dateTimePicker1.Value, textBox2.Text);
            if (isSuccess)
            {
                MessageBox.Show("Mantenimiento finalizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.MinDate = Convert.ToDateTime(source.Rows[0]["fechaIngreso"].ToString());
            }
            catch
            {

            }
        }
    }
}
