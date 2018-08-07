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
    public partial class NewContract : Form
    {

        public Boolean ac;

        public NewContract()
        {
            ac = false;
            InitializeComponent();
        }

        public NewContract(String id)
        {
            ac = true;
            InitializeComponent();
            button1.Text = "Modificar";
            //comboBox1.Items.Add();
            comboBox1.Enabled = false;
            textBox1.Text = id;
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ac)
            {

            }
            else
            {

            }
        }
    }
}
