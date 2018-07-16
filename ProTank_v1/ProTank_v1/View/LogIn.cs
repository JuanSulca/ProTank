using ProTank_v1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = txtUname.Text;
            String pwd = new Hash().md5(txtPwd.Text);
            protankDataSetTableAdapters.userLoginTableAdapter loginTable = new protankDataSetTableAdapters.userLoginTableAdapter();
            protankDataSet ds = new protankDataSet();
            loginTable.Fill(ds.userLogin);
            protankDataSet.userLoginRow loginRow = ds.userLogin.FindByuname(uname);
            if(loginRow.pwd == pwd)
            {
                System.Windows.Forms.MessageBox.Show("Succesfull log in!\n" + "rol: " + loginRow.rol);
                Modulos modulos = new Modulos();
                modulos.Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Acceso denegado!");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
