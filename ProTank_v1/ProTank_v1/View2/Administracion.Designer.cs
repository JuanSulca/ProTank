namespace ProTank_v1.View
{
    partial class Administracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabModulos_Empleados = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblModulos_Empleados_empleados = new System.Windows.Forms.Label();
            this.lblModulos_Empleados_protank = new System.Windows.Forms.Label();
            this.tabModulos_ListaPersonas = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaAEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.protankDataSet = new ProTank_v1.protankDataSet();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new ProTank_v1.protankDataSetTableAdapters.empleadoTableAdapter();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter = new ProTank_v1.protankDataSetTableAdapters.personTableAdapter();
            this.fnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabModulos_Empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel14.SuspendLayout();
            this.tabModulos_ListaPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel11.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.protankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabModulos_Empleados);
            this.tabControl1.Controls.Add(this.tabModulos_ListaPersonas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1205, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // tabModulos_Empleados
            // 
            this.tabModulos_Empleados.Controls.Add(this.dataGridView2);
            this.tabModulos_Empleados.Controls.Add(this.panel14);
            this.tabModulos_Empleados.Location = new System.Drawing.Point(4, 25);
            this.tabModulos_Empleados.Margin = new System.Windows.Forms.Padding(4);
            this.tabModulos_Empleados.Name = "tabModulos_Empleados";
            this.tabModulos_Empleados.Padding = new System.Windows.Forms.Padding(4);
            this.tabModulos_Empleados.Size = new System.Drawing.Size(1197, 521);
            this.tabModulos_Empleados.TabIndex = 6;
            this.tabModulos_Empleados.Text = "Empleados";
            this.tabModulos_Empleados.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.idEDataGridViewTextBoxColumn,
            this.telefDataGridViewTextBoxColumn,
            this.celDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.empleadoBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 89);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 31;
            this.dataGridView2.Size = new System.Drawing.Size(1189, 428);
            this.dataGridView2.TabIndex = 10;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel14.Controls.Add(this.lblModulos_Empleados_empleados);
            this.panel14.Controls.Add(this.lblModulos_Empleados_protank);
            this.panel14.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(4, 4);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1189, 85);
            this.panel14.TabIndex = 11;
            // 
            // lblModulos_Empleados_empleados
            // 
            this.lblModulos_Empleados_empleados.AutoSize = true;
            this.lblModulos_Empleados_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblModulos_Empleados_empleados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulos_Empleados_empleados.ForeColor = System.Drawing.Color.Lavender;
            this.lblModulos_Empleados_empleados.Location = new System.Drawing.Point(1032, 29);
            this.lblModulos_Empleados_empleados.Name = "lblModulos_Empleados_empleados";
            this.lblModulos_Empleados_empleados.Size = new System.Drawing.Size(141, 28);
            this.lblModulos_Empleados_empleados.TabIndex = 1;
            this.lblModulos_Empleados_empleados.Text = "Empleados";
            // 
            // lblModulos_Empleados_protank
            // 
            this.lblModulos_Empleados_protank.AutoSize = true;
            this.lblModulos_Empleados_protank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModulos_Empleados_protank.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblModulos_Empleados_protank.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulos_Empleados_protank.ForeColor = System.Drawing.Color.White;
            this.lblModulos_Empleados_protank.Location = new System.Drawing.Point(101, 11);
            this.lblModulos_Empleados_protank.Name = "lblModulos_Empleados_protank";
            this.lblModulos_Empleados_protank.Size = new System.Drawing.Size(180, 56);
            this.lblModulos_Empleados_protank.TabIndex = 0;
            this.lblModulos_Empleados_protank.Text = "ProTank";
            // 
            // tabModulos_ListaPersonas
            // 
            this.tabModulos_ListaPersonas.Controls.Add(this.dataGridView1);
            this.tabModulos_ListaPersonas.Controls.Add(this.panel11);
            this.tabModulos_ListaPersonas.Location = new System.Drawing.Point(4, 25);
            this.tabModulos_ListaPersonas.Margin = new System.Windows.Forms.Padding(4);
            this.tabModulos_ListaPersonas.Name = "tabModulos_ListaPersonas";
            this.tabModulos_ListaPersonas.Padding = new System.Windows.Forms.Padding(4);
            this.tabModulos_ListaPersonas.Size = new System.Drawing.Size(1197, 521);
            this.tabModulos_ListaPersonas.TabIndex = 7;
            this.tabModulos_ListaPersonas.Text = "Clientes";
            this.tabModulos_ListaPersonas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fnameDataGridViewTextBoxColumn1,
            this.lnameDataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn,
            this.telefDataGridViewTextBoxColumn1,
            this.celDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1189, 428);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(4, 4);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1189, 85);
            this.panel11.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(1005, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "ProTank";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1205, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEmpleadoToolStripMenuItem,
            this.modificarEmpleadoToolStripMenuItem,
            this.darDeBajaAEmpleadoToolStripMenuItem,
            this.toolStripSeparator1,
            this.buscarEmpleadoToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // registrarEmpleadoToolStripMenuItem
            // 
            this.registrarEmpleadoToolStripMenuItem.Name = "registrarEmpleadoToolStripMenuItem";
            this.registrarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.registrarEmpleadoToolStripMenuItem.Text = "Registrar empleado";
            this.registrarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registrarEmpleadoToolStripMenuItem_Click);
            // 
            // modificarEmpleadoToolStripMenuItem
            // 
            this.modificarEmpleadoToolStripMenuItem.Name = "modificarEmpleadoToolStripMenuItem";
            this.modificarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.modificarEmpleadoToolStripMenuItem.Text = "Modificar empleado";
            // 
            // darDeBajaAEmpleadoToolStripMenuItem
            // 
            this.darDeBajaAEmpleadoToolStripMenuItem.Name = "darDeBajaAEmpleadoToolStripMenuItem";
            this.darDeBajaAEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.darDeBajaAEmpleadoToolStripMenuItem.Text = "Dar de baja a empleado";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(243, 6);
            // 
            // buscarEmpleadoToolStripMenuItem
            // 
            this.buscarEmpleadoToolStripMenuItem.Name = "buscarEmpleadoToolStripMenuItem";
            this.buscarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.buscarEmpleadoToolStripMenuItem.Text = "Buscar empleado";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.removerClienteToolStripMenuItem,
            this.toolStripSeparator2,
            this.buscarClienteToolStripMenuItem,
            this.toolStripSeparator3});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.registrarClienteToolStripMenuItem.Text = "Registrar cliente";
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.modificarClienteToolStripMenuItem.Text = "Modificar cliente";
            // 
            // removerClienteToolStripMenuItem
            // 
            this.removerClienteToolStripMenuItem.Name = "removerClienteToolStripMenuItem";
            this.removerClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.removerClienteToolStripMenuItem.Text = "Remover cliente";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.modificarContraseñaToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.eliminarUsuarioToolStripMenuItem.Text = "Remover Usuario";
            // 
            // modificarContraseñaToolStripMenuItem
            // 
            this.modificarContraseñaToolStripMenuItem.Name = "modificarContraseñaToolStripMenuItem";
            this.modificarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.modificarContraseñaToolStripMenuItem.Text = "Modificar Datos de Usuario";
            // 
            // protankDataSet
            // 
            this.protankDataSet.DataSetName = "protankDataSet";
            this.protankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "empleado";
            this.empleadoBindingSource.DataSource = this.protankDataSet;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEDataGridViewTextBoxColumn
            // 
            this.idEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEDataGridViewTextBoxColumn.DataPropertyName = "idE";
            this.idEDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.idEDataGridViewTextBoxColumn.Name = "idEDataGridViewTextBoxColumn";
            this.idEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefDataGridViewTextBoxColumn
            // 
            this.telefDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefDataGridViewTextBoxColumn.DataPropertyName = "telef";
            this.telefDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefDataGridViewTextBoxColumn.Name = "telefDataGridViewTextBoxColumn";
            this.telefDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celDataGridViewTextBoxColumn
            // 
            this.celDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.celDataGridViewTextBoxColumn.DataPropertyName = "cel";
            this.celDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celDataGridViewTextBoxColumn.Name = "celDataGridViewTextBoxColumn";
            this.celDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "person";
            this.personBindingSource.DataSource = this.protankDataSet;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // fnameDataGridViewTextBoxColumn1
            // 
            this.fnameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameDataGridViewTextBoxColumn1.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn1.HeaderText = "Nombres";
            this.fnameDataGridViewTextBoxColumn1.Name = "fnameDataGridViewTextBoxColumn1";
            this.fnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lnameDataGridViewTextBoxColumn1
            // 
            this.lnameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lnameDataGridViewTextBoxColumn1.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn1.HeaderText = "Apellidos";
            this.lnameDataGridViewTextBoxColumn1.Name = "lnameDataGridViewTextBoxColumn1";
            this.lnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefDataGridViewTextBoxColumn1
            // 
            this.telefDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefDataGridViewTextBoxColumn1.DataPropertyName = "telef";
            this.telefDataGridViewTextBoxColumn1.HeaderText = "Telefono";
            this.telefDataGridViewTextBoxColumn1.Name = "telefDataGridViewTextBoxColumn1";
            this.telefDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // celDataGridViewTextBoxColumn1
            // 
            this.celDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.celDataGridViewTextBoxColumn1.DataPropertyName = "cel";
            this.celDataGridViewTextBoxColumn1.HeaderText = "Celular";
            this.celDataGridViewTextBoxColumn1.Name = "celDataGridViewTextBoxColumn1";
            this.celDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Administracion";
            this.Text = "Administracion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administracion_FormClosed);
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabModulos_Empleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.tabModulos_ListaPersonas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.protankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabModulos_Empleados;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblModulos_Empleados_empleados;
        private System.Windows.Forms.Label lblModulos_Empleados_protank;
        private System.Windows.Forms.TabPage tabModulos_ListaPersonas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaAEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem buscarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarContraseñaToolStripMenuItem;
        private protankDataSet protankDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private protankDataSetTableAdapters.empleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
        private protankDataSetTableAdapters.personTableAdapter personTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn celDataGridViewTextBoxColumn1;
    }
}