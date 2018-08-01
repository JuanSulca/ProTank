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
            DialogResult res = MessageBox.Show("Desea eliminar el resgistro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.Equals(DialogResult.Yes))
            {
                MessageBox.Show("Registro eliminado exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("No se puede conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = txtUname.Text;
            String pwd = new Hash().md5(txtPwd.Text);
            if (txtUname.Text == "" || txtPwd.Text == "")
            {
                MessageBox.Show("Existen campos sin llenar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                protankDataSetTableAdapters.userLoginTableAdapter loginTable = new protankDataSetTableAdapters.userLoginTableAdapter();
                protankDataSet ds = new protankDataSet();
                loginTable.Fill(ds.userLogin);
                protankDataSet.userLoginRow loginRow = ds.userLogin.FindByuname(uname);
                if (loginRow.pwd == pwd)
                {
                    EntradaModulos modulos = new EntradaModulos(loginRow.rol);
                    modulos.Show();
                    this.Hide();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Acceso denegado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
