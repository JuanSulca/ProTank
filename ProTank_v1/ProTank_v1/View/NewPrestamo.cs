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
    public partial class NewPrestamo : Form
    {
        public NewPrestamo()
        {
            InitializeComponent();
        }

        private void NewPerstamo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
