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
            protankDataSetTableAdapters.userLoginTableAdapter loginTable = new protankDataSetTableAdapters.userLoginTableAdapter();
            protankDataSet ds = new protankDataSet();
            loginTable.Fill(ds.userLogin);
            protankDataSet.userLoginRow loginRow = ds.userLogin.FindByuname(uname);
            if(loginRow.pwd == pwd)
            {
                System.Windows.Forms.MessageBox.Show("Succesfull log in!\n" + "rol: " + loginRow.rol);
            }
            /*Llamar a la pantalla modulo*/
        }
    }
}
