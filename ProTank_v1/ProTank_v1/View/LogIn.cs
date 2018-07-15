using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProTank_v1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = txtUname.Text;
            String pwd = new Hash().md5(txtPwd.Text);
            System.Windows.Forms.MessageBox.Show("uname: " + uname + ";" + "pwd: " + pwd);
        }
    }
}
