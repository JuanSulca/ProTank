using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProTank_v1.View
{
    public partial class Modulos : Form
    {
        SqlCommand cmd;
        SqlDataReader reader;
        public Modulos()
        {
            SqlClientPermission permission = new SqlClientPermission(PermissionState.Unrestricted);
            permission.Demand();
            SqlDependency.Start("Data Source=JUANSULCA;Initial Catalog=protank;User ID=sa;Password=P@ssw0rd");
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=JUANSULCA;Initial Catalog=protank;User ID=sa;Password=P@ssw0rd");
            con.Open();
            cmd = new SqlCommand("SELECT nombre, marca, codigoH, periodo FROM dbo.herramienta",con);
            SqlDependency dependency = new SqlDependency(cmd);
            dependency.OnChange += new OnChangeEventHandler(OnDependencyChange);
            reader = cmd.ExecuteReader();
        }

        private void Modulos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protankDataSet.herramienta' table. You can move, or remove it, as needed.
            this.herramientaTableAdapter.Fill(this.protankDataSet.herramienta);
            // TODO: This line of code loads data into the 'protankDataSet.herramienta' table. You can move, or remove it, as needed.

        }

        private void Modulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void OnDependencyChange(object sender, SqlNotificationEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Triggered!");
            this.herramientaTableAdapter.Fill(this.protankDataSet.herramienta);
            reader = cmd.ExecuteReader();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.herramientaTableAdapter.Fill(this.protankDataSet.herramienta);
        }
    }
}
