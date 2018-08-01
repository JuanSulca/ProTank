using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProTank_v1.View2
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protankDataSet1.empleados_apellidos_nombres' table. You can move, or remove it, as needed.
            this.empleados_apellidos_nombresTableAdapter.Fill(this.protankDataSet1.empleados_apellidos_nombres);
            // TODO: This line of code loads data into the 'protankDataSet.empleados_apellidos_nombres' table. You can move, or remove it, as needed.
            this.empleados_apellidos_nombresTableAdapter.Fill(this.protankDataSet.empleados_apellidos_nombres);
            // TODO: This line of code loads data into the 'protankDataSet.empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.protankDataSet.empleado);

        }

        private void btnModulos_NuevoUsuario_crearUsuario_Click(object sender, EventArgs e)
        {
            if (txtModulos_NuevoUsuario_passsword1.Text == "" || txtModulos_NuevoUsuario_passsword2.Text == "" ||
                comboModulos_NuevoUsuario_nombre.Text == "" || txtModulos_NuevoUsuario_username.Text == "")
            {
                MessageBox.Show("Existen campos sin llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String pass = new Hash().md5(txtModulos_NuevoUsuario_passsword1.Text);
                String uname = txtModulos_NuevoUsuario_username.Text;
                String rol = "";
                if (checkModulos_NuevoUsuario_bodega.Checked)
                    rol += "H";
                if (checkModulos_NuevoUsuario_contratos.Checked)
                    rol += "C";
                if (checkModulos_NuevoUsuario_design.Checked)
                    rol += "D";
                if (checkModulos_NuevoUsuario_servicios.Checked)
                    rol += "V";
                if (checkBox1.Checked)
                    rol += "A";
                if (pass != new Hash().md5(txtModulos_NuevoUsuario_passsword2.Text))
                {
                    MessageBox.Show("Contraseñas no coinsiden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String id = comboModulos_NuevoUsuario_nombre.SelectedValue.ToString();
                    protankDataSetTableAdapters.userLoginTableAdapter ta = new protankDataSetTableAdapters.userLoginTableAdapter();
                    ta.Insert(uname, pass, rol);
                    protankDataSetTableAdapters.userEmpleadoTableAdapter tba = new protankDataSetTableAdapters.userEmpleadoTableAdapter();
                    tba.Insert(id, uname);
                }
            }
        }

        private void btnModulos_NuevoUsuario_limpiar_Click(object sender, EventArgs e)
        {
            txtModulos_NuevoUsuario_passsword1.Text = "";
            txtModulos_NuevoUsuario_passsword2.Text = "";
            txtModulos_NuevoUsuario_username.Text = "";
            checkModulos_NuevoUsuario_bodega.Checked = false;
            checkModulos_NuevoUsuario_contratos.Checked = false;
            checkModulos_NuevoUsuario_design.Checked = false;
            checkModulos_NuevoUsuario_servicios.Checked = false;
            checkBox1.Checked = false;
        }
    }
}
