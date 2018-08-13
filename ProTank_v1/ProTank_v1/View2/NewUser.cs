using ProTank_v1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProTank_v1.View2
{
    public partial class NewUser : Form
    {

        Boolean edit = false;

        public NewUser()
        {
            InitializeComponent();
        }

        public NewUser(String uname, String rol, Boolean mos)
        {
            InitializeComponent();
            txtModulos_NuevoUsuario_username.Text = uname;
            if (rol.Contains("H"))
                checkModulos_NuevoUsuario_bodega.Checked = true;
            if (rol.Contains("C"))
                checkModulos_NuevoUsuario_contratos.Checked = true;
            if (rol.Contains("D"))
                checkModulos_NuevoUsuario_design.Checked = true;
            if (rol.Contains("V"))
                checkModulos_NuevoUsuario_servicios.Checked = true;
            if (rol.Contains("A"))
                checkBox1.Checked = true;
            //edit = true;
            txtModulos_NuevoUsuario_username.Enabled = false;
            auxNombres();
            btnModulos_NuevoUsuario_crearUsuario.Visible = false;
            checkModulos_NuevoUsuario_bodega.Enabled = false;
            checkModulos_NuevoUsuario_contratos.Enabled = false;
            checkModulos_NuevoUsuario_design.Enabled = false;
            checkModulos_NuevoUsuario_servicios.Enabled = false;
            checkBox1.Enabled = false;
            txtModulos_NuevoUsuario_passsword1.Visible = false;
            txtModulos_NuevoUsuario_passsword2.Visible = false;
            lblModulos_NuevoUsuario_password1.Visible = false;
            lblModulos_NuevoUsuario_password2.Visible = false;
            //protankDataSetTableAdapters.userEmpleadoTableAdapter loginTable = new protankDataSetTableAdapters.userEmpleadoTableAdapter();
            //protankDataSet ds = new protankDataSet();
            //loginTable.Fill(ds.userEmpleado);
            //protankDataSet.userLoginRow loginRow = ds.FindByuname(uname);
            //comboModulos_NuevoUsuario_nombre.SelectedValue = loginRow.idE;
        }

        public NewUser(String uname, String rol)
        {
            InitializeComponent();
            txtModulos_NuevoUsuario_username.Text = uname;
            if (rol.Contains("H"))
                checkModulos_NuevoUsuario_bodega.Checked = true;
            if (rol.Contains("C"))
                checkModulos_NuevoUsuario_contratos.Checked = true;
            if (rol.Contains("D"))
                checkModulos_NuevoUsuario_design.Checked = true;
            if (rol.Contains("V"))
                checkModulos_NuevoUsuario_servicios.Checked = true;
            if (rol.Contains("A"))
                checkBox1.Checked = true;
            edit = true;
            txtModulos_NuevoUsuario_username.Enabled = false;
            //auxNombres();
            comboModulos_NuevoUsuario_nombre.Items.Clear();
            Empleado e = new Empleado().getEmp(uname);
            comboModulos_NuevoUsuario_nombre.Items.Add(new ComItem(e.fname + " " + e.lname, e.id));
            comboModulos_NuevoUsuario_nombre.SelectedIndex = 0;
            comboModulos_NuevoUsuario_nombre.Enabled = false;
            btnModulos_NuevoUsuario_crearUsuario.Text = "Modificar";
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            auxNombres();
            comboModulos_NuevoUsuario_nombre.SelectedItem = 0;

        }

        private void auxNombres()
        {
            DataTable dataTable = new Empleado().tableEmpleado();
            comboModulos_NuevoUsuario_nombre.Items.Clear();
            foreach (DataRow dr in dataTable.Rows)
            {
                comboModulos_NuevoUsuario_nombre.Items.Add(new ComItem(dr["fname"]+" "+dr["lname"], dr["idE"] + ""));
            }
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
                    MessageBox.Show("Contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (edit)
                    {
                        //cambiar por la función de actualizacion de USer :"v
                        SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["protankDB"].ConnectionString);
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE userLogin SET pwd = @pwd, rol = @rol WHERE uname = @uname", cnx);
                        cmd.Parameters.AddWithValue("@pwd", pass);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        cmd.Parameters.AddWithValue("@uname", uname);
                        int i = cmd.ExecuteNonQuery();
                        cnx.Close();
                        if (i > 0)
                        {
                            MessageBox.Show("Actualización exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                    else
                    {
                        String id = (comboModulos_NuevoUsuario_nombre.SelectedItem as ComItem).value;
                        User u = new User(uname, pass, rol);
                        u.insUser(u, id);
                    }
                    MessageBox.Show("Registro exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnModulos_NuevoUsuario_limpiar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //txtModulos_NuevoUsuario_passsword1.Text = "";
            //txtModulos_NuevoUsuario_passsword2.Text = "";
            //txtModulos_NuevoUsuario_username.Text = "";
            //checkModulos_NuevoUsuario_bodega.Checked = false;
            //checkModulos_NuevoUsuario_contratos.Checked = false;
            //checkModulos_NuevoUsuario_design.Checked = false;
            //checkModulos_NuevoUsuario_servicios.Checked = false;
            //checkBox1.Checked = false;
        }

        private void comboModulos_NuevoUsuario_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
