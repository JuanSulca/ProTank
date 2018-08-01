namespace ProTank_v1.View2
{
    partial class NewUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblModulos_NuevoUsuario_ayuda = new System.Windows.Forms.Label();
            this.checkModulos_NuevoUsuario_servicios = new System.Windows.Forms.CheckBox();
            this.checkModulos_NuevoUsuario_bodega = new System.Windows.Forms.CheckBox();
            this.checkModulos_NuevoUsuario_contratos = new System.Windows.Forms.CheckBox();
            this.checkModulos_NuevoUsuario_design = new System.Windows.Forms.CheckBox();
            this.txtModulos_NuevoUsuario_passsword1 = new System.Windows.Forms.TextBox();
            this.lblModulos_NuevoUsuario_password1 = new System.Windows.Forms.Label();
            this.comboModulos_NuevoUsuario_nombre = new System.Windows.Forms.ComboBox();
            this.lblModulos_NuevoUsuario_nombre = new System.Windows.Forms.Label();
            this.txtModulos_NuevoUsuario_passsword2 = new System.Windows.Forms.TextBox();
            this.txtModulos_NuevoUsuario_username = new System.Windows.Forms.TextBox();
            this.btnModulos_NuevoUsuario_limpiar = new System.Windows.Forms.Button();
            this.btnModulos_NuevoUsuario_crearUsuario = new System.Windows.Forms.Button();
            this.lblModulos_NuevoUsuario_password2 = new System.Windows.Forms.Label();
            this.lblModulos_NuevoUsuario_username = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblModulos_NuevoUsuario_nuevoUsuario = new System.Windows.Forms.Label();
            this.lblModulos_NuevoUsuario_protank = new System.Windows.Forms.Label();
            this.protankDataSet = new ProTank_v1.protankDataSet();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new ProTank_v1.protankDataSetTableAdapters.empleadoTableAdapter();
            this.empleadosapellidosnombresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleados_apellidos_nombresTableAdapter = new ProTank_v1.protankDataSetTableAdapters.empleados_apellidos_nombresTableAdapter();
            this.protankDataSet1 = new ProTank_v1.protankDataSet();
            this.empleadosapellidosnombresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.protankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosapellidosnombresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protankDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosapellidosnombresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 461);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblModulos_NuevoUsuario_ayuda);
            this.panel2.Controls.Add(this.checkModulos_NuevoUsuario_servicios);
            this.panel2.Controls.Add(this.checkModulos_NuevoUsuario_bodega);
            this.panel2.Controls.Add(this.checkModulos_NuevoUsuario_contratos);
            this.panel2.Controls.Add(this.checkModulos_NuevoUsuario_design);
            this.panel2.Controls.Add(this.txtModulos_NuevoUsuario_passsword1);
            this.panel2.Controls.Add(this.lblModulos_NuevoUsuario_password1);
            this.panel2.Controls.Add(this.comboModulos_NuevoUsuario_nombre);
            this.panel2.Controls.Add(this.lblModulos_NuevoUsuario_nombre);
            this.panel2.Controls.Add(this.txtModulos_NuevoUsuario_passsword2);
            this.panel2.Controls.Add(this.txtModulos_NuevoUsuario_username);
            this.panel2.Controls.Add(this.btnModulos_NuevoUsuario_limpiar);
            this.panel2.Controls.Add(this.btnModulos_NuevoUsuario_crearUsuario);
            this.panel2.Controls.Add(this.lblModulos_NuevoUsuario_password2);
            this.panel2.Controls.Add(this.lblModulos_NuevoUsuario_username);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 376);
            this.panel2.TabIndex = 7;
            // 
            // lblModulos_NuevoUsuario_ayuda
            // 
            this.lblModulos_NuevoUsuario_ayuda.AutoSize = true;
            this.lblModulos_NuevoUsuario_ayuda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.142858F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulos_NuevoUsuario_ayuda.Location = new System.Drawing.Point(623, 234);
            this.lblModulos_NuevoUsuario_ayuda.Name = "lblModulos_NuevoUsuario_ayuda";
            this.lblModulos_NuevoUsuario_ayuda.Size = new System.Drawing.Size(16, 16);
            this.lblModulos_NuevoUsuario_ayuda.TabIndex = 16;
            this.lblModulos_NuevoUsuario_ayuda.Text = "?";
            // 
            // checkModulos_NuevoUsuario_servicios
            // 
            this.checkModulos_NuevoUsuario_servicios.AutoSize = true;
            this.checkModulos_NuevoUsuario_servicios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModulos_NuevoUsuario_servicios.Location = new System.Drawing.Point(491, 225);
            this.checkModulos_NuevoUsuario_servicios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkModulos_NuevoUsuario_servicios.Name = "checkModulos_NuevoUsuario_servicios";
            this.checkModulos_NuevoUsuario_servicios.Size = new System.Drawing.Size(114, 27);
            this.checkModulos_NuevoUsuario_servicios.TabIndex = 13;
            this.checkModulos_NuevoUsuario_servicios.Text = "Servicios";
            this.checkModulos_NuevoUsuario_servicios.UseVisualStyleBackColor = true;
            // 
            // checkModulos_NuevoUsuario_bodega
            // 
            this.checkModulos_NuevoUsuario_bodega.AutoSize = true;
            this.checkModulos_NuevoUsuario_bodega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModulos_NuevoUsuario_bodega.Location = new System.Drawing.Point(363, 225);
            this.checkModulos_NuevoUsuario_bodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkModulos_NuevoUsuario_bodega.Name = "checkModulos_NuevoUsuario_bodega";
            this.checkModulos_NuevoUsuario_bodega.Size = new System.Drawing.Size(110, 27);
            this.checkModulos_NuevoUsuario_bodega.TabIndex = 12;
            this.checkModulos_NuevoUsuario_bodega.Text = "Bodega";
            this.checkModulos_NuevoUsuario_bodega.UseVisualStyleBackColor = true;
            // 
            // checkModulos_NuevoUsuario_contratos
            // 
            this.checkModulos_NuevoUsuario_contratos.AutoSize = true;
            this.checkModulos_NuevoUsuario_contratos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModulos_NuevoUsuario_contratos.Location = new System.Drawing.Point(211, 225);
            this.checkModulos_NuevoUsuario_contratos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkModulos_NuevoUsuario_contratos.Name = "checkModulos_NuevoUsuario_contratos";
            this.checkModulos_NuevoUsuario_contratos.Size = new System.Drawing.Size(128, 27);
            this.checkModulos_NuevoUsuario_contratos.TabIndex = 11;
            this.checkModulos_NuevoUsuario_contratos.Text = "Contratos";
            this.checkModulos_NuevoUsuario_contratos.UseVisualStyleBackColor = true;
            // 
            // checkModulos_NuevoUsuario_design
            // 
            this.checkModulos_NuevoUsuario_design.AutoSize = true;
            this.checkModulos_NuevoUsuario_design.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModulos_NuevoUsuario_design.Location = new System.Drawing.Point(96, 225);
            this.checkModulos_NuevoUsuario_design.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkModulos_NuevoUsuario_design.Name = "checkModulos_NuevoUsuario_design";
            this.checkModulos_NuevoUsuario_design.Size = new System.Drawing.Size(96, 27);
            this.checkModulos_NuevoUsuario_design.TabIndex = 10;
            this.checkModulos_NuevoUsuario_design.Text = "Diseño";
            this.checkModulos_NuevoUsuario_design.UseVisualStyleBackColor = true;
            // 
            // txtModulos_NuevoUsuario_passsword1
            // 
            this.txtModulos_NuevoUsuario_passsword1.Location = new System.Drawing.Point(272, 135);
            this.txtModulos_NuevoUsuario_passsword1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModulos_NuevoUsuario_passsword1.Name = "txtModulos_NuevoUsuario_passsword1";
            this.txtModulos_NuevoUsuario_passsword1.PasswordChar = '•';
            this.txtModulos_NuevoUsuario_passsword1.Size = new System.Drawing.Size(244, 22);
            this.txtModulos_NuevoUsuario_passsword1.TabIndex = 9;
            // 
            // lblModulos_NuevoUsuario_password1
            // 
            this.lblModulos_NuevoUsuario_password1.AutoSize = true;
            this.lblModulos_NuevoUsuario_password1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulos_NuevoUsuario_password1.Location = new System.Drawing.Point(91, 132);
            this.lblModulos_NuevoUsuario_password1.Name = "lblModulos_NuevoUsuario_password1";
            this.lblModulos_NuevoUsuario_password1.Size = new System.Drawing.Size(130, 23);
            this.lblModulos_NuevoUsuario_password1.TabIndex = 8;
            this.lblModulos_NuevoUsuario_password1.Text = "Contraseña:";
            // 
            // comboModulos_NuevoUsuario_nombre
            // 
            this.comboModulos_NuevoUsuario_nombre.DataSource = this.empleadosapellidosnombresBindingSource1;
            this.comboModulos_NuevoUsuario_nombre.DisplayMember = "Empleados";
            this.comboModulos_NuevoUsuario_nombre.FormattingEnabled = true;
            this.comboModulos_NuevoUsuario_nombre.Location = new System.Drawing.Point(272, 35);
            this.comboModulos_NuevoUsuario_nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboModulos_NuevoUsuario_nombre.Name = "comboModulos_NuevoUsuario_nombre";
            this.comboModulos_NuevoUsuario_nombre.Size = new System.Drawing.Size(244, 24);
            this.comboModulos_NuevoUsuario_nombre.TabIndex = 7;
            this.comboModulos_NuevoUsuario_nombre.ValueMember = "idE";
            // 
            // lblModulos_NuevoUsuario_nombre
            // 
            this.lblModulos_NuevoUsuario_nombre.AutoSize = true;
            this.lblModulos_NuevoUsuario_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulos_NuevoUsuario_nombre.Location = new System.Drawing.Point(91, 36);
            this.lblModulos_NuevoUsuario_nombre.Name = "lblModulos_NuevoUsuario_nombre";
            this.lblModulos_NuevoUsuario_nombre.Size = new System.Drawing.Size(95, 23);
            this.lblModulos_NuevoUsuario_nombre.TabIndex = 6;
            this.lblModulos_NuevoUsuario_nombre.Text = "Nombre:";
            // 
            // txtModulos_NuevoUsuario_passsword2
            // 
            this.txtModulos_NuevoUsuario_passsword2.Location = new System.Drawing.Point(272, 180);
            this.txtModulos_NuevoUsuario_passsword2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModulos_NuevoUsuario_passsword2.Name = "txtModulos_NuevoUsuario_passsword2";
            this.txtModulos_NuevoUsuario_passsword2.PasswordChar = '•';
            this.txtModulos_NuevoUsuario_passsword2.Size = new System.Drawing.Size(244, 22);
            this.txtModulos_NuevoUsuario_passsword2.TabIndex = 5;
            // 
            // txtModulos_NuevoUsuario_username
            // 
            this.txtModulos_NuevoUsuario_username.Location = new System.Drawing.Point(272, 87);
            this.txtModulos_NuevoUsuario_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModulos_NuevoUsuario_username.Name = "txtModulos_NuevoUsuario_username";
            this.txtModulos_NuevoUsuario_username.Size = new System.Drawing.Size(244, 22);
            this.txtModulos_NuevoUsuario_username.TabIndex = 4;
            // 
            // btnModulos_NuevoUsuario_limpiar
            // 
            this.btnModulos_NuevoUsuario_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModulos_NuevoUsuario_limpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulos_NuevoUsuario_limpiar.ForeColor = System.Drawing.Color.White;
            this.btnModulos_NuevoUsuario_limpiar.Location = new System.Drawing.Point(125, 283);
            this.btnModulos_NuevoUsuario_limpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModulos_NuevoUsuario_limpiar.Name = "btnModulos_NuevoUsuario_limpiar";
            this.btnModulos_NuevoUsuario_limpiar.Size = new System.Drawing.Size(128, 47);
            this.btnModulos_NuevoUsuario_limpiar.TabIndex = 3;
            this.btnModulos_NuevoUsuario_limpiar.Text = "Limpiar";
            this.btnModulos_NuevoUsuario_limpiar.UseVisualStyleBackColor = false;
            // 
            // btnModulos_NuevoUsuario_crearUsuario
            // 
            this.btnModulos_NuevoUsuario_crearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModulos_NuevoUsuario_crearUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulos_NuevoUsuario_crearUsuario.ForeColor = System.Drawing.Color.White;
            this.btnModulos_NuevoUsuario_crearUsuario.Location = new System.Drawing.Point(435, 283);
            this.btnModulos_NuevoUsuario_crearUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModulos_NuevoUsuario_crearUsuario.Name = "btnModulos_NuevoUsuario_crearUsuario";
            this.btnModulos_NuevoUsuario_crearUsuario.Size = new System.Drawing.Size(151, 47);
            this.btnModulos_NuevoUsuario_crearUsuario.TabIndex = 2;
            this.btnModulos_NuevoUsuario_crearUsuario.Text = "Crear usuario";
            this.btnModulos_NuevoUsuario_crearUsuario.UseVisualStyleBackColor = false;
            this.btnModulos_NuevoUsuario_crearUsuario.Click += new System.EventHandler(this.btnModulos_NuevoUsuario_crearUsuario_Click);
            // 
            // lblModulos_NuevoUsuario_password2
            // 
            this.lblModulos_NuevoUsuario_password2.AutoSize = true;
            this.lblModulos_NuevoUsuario_password2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulos_NuevoUsuario_password2.Location = new System.Drawing.Point(91, 176);
            this.lblModulos_NuevoUsuario_password2.Name = "lblModulos_NuevoUsuario_password2";
            this.lblModulos_NuevoUsuario_password2.Size = new System.Drawing.Size(139, 23);
            this.lblModulos_NuevoUsuario_password2.TabIndex = 1;
            this.lblModulos_NuevoUsuario_password2.Text = "*Contraseña:";
            // 
            // lblModulos_NuevoUsuario_username
            // 
            this.lblModulos_NuevoUsuario_username.AutoSize = true;
            this.lblModulos_NuevoUsuario_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulos_NuevoUsuario_username.Location = new System.Drawing.Point(91, 84);
            this.lblModulos_NuevoUsuario_username.Name = "lblModulos_NuevoUsuario_username";
            this.lblModulos_NuevoUsuario_username.Size = new System.Drawing.Size(113, 23);
            this.lblModulos_NuevoUsuario_username.TabIndex = 0;
            this.lblModulos_NuevoUsuario_username.Text = "Username:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblModulos_NuevoUsuario_nuevoUsuario);
            this.panel3.Controls.Add(this.lblModulos_NuevoUsuario_protank);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 85);
            this.panel3.TabIndex = 6;
            // 
            // lblModulos_NuevoUsuario_nuevoUsuario
            // 
            this.lblModulos_NuevoUsuario_nuevoUsuario.AutoSize = true;
            this.lblModulos_NuevoUsuario_nuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblModulos_NuevoUsuario_nuevoUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulos_NuevoUsuario_nuevoUsuario.ForeColor = System.Drawing.Color.Lavender;
            this.lblModulos_NuevoUsuario_nuevoUsuario.Location = new System.Drawing.Point(535, 29);
            this.lblModulos_NuevoUsuario_nuevoUsuario.Name = "lblModulos_NuevoUsuario_nuevoUsuario";
            this.lblModulos_NuevoUsuario_nuevoUsuario.Size = new System.Drawing.Size(182, 28);
            this.lblModulos_NuevoUsuario_nuevoUsuario.TabIndex = 1;
            this.lblModulos_NuevoUsuario_nuevoUsuario.Text = "Nuevo Usuario";
            // 
            // lblModulos_NuevoUsuario_protank
            // 
            this.lblModulos_NuevoUsuario_protank.AutoSize = true;
            this.lblModulos_NuevoUsuario_protank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModulos_NuevoUsuario_protank.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblModulos_NuevoUsuario_protank.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulos_NuevoUsuario_protank.ForeColor = System.Drawing.Color.White;
            this.lblModulos_NuevoUsuario_protank.Location = new System.Drawing.Point(101, 11);
            this.lblModulos_NuevoUsuario_protank.Name = "lblModulos_NuevoUsuario_protank";
            this.lblModulos_NuevoUsuario_protank.Size = new System.Drawing.Size(180, 56);
            this.lblModulos_NuevoUsuario_protank.TabIndex = 0;
            this.lblModulos_NuevoUsuario_protank.Text = "ProTank";
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
            // empleadosapellidosnombresBindingSource
            // 
            this.empleadosapellidosnombresBindingSource.DataMember = "empleados_apellidos_nombres";
            this.empleadosapellidosnombresBindingSource.DataSource = this.protankDataSet;
            // 
            // empleados_apellidos_nombresTableAdapter
            // 
            this.empleados_apellidos_nombresTableAdapter.ClearBeforeFill = true;
            // 
            // protankDataSet1
            // 
            this.protankDataSet1.DataSetName = "protankDataSet";
            this.protankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosapellidosnombresBindingSource1
            // 
            this.empleadosapellidosnombresBindingSource1.DataMember = "empleados_apellidos_nombres";
            this.empleadosapellidosnombresBindingSource1.DataSource = this.protankDataSet1;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 461);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.protankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosapellidosnombresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protankDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosapellidosnombresBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblModulos_NuevoUsuario_ayuda;
        private System.Windows.Forms.CheckBox checkModulos_NuevoUsuario_servicios;
        private System.Windows.Forms.CheckBox checkModulos_NuevoUsuario_bodega;
        private System.Windows.Forms.CheckBox checkModulos_NuevoUsuario_contratos;
        private System.Windows.Forms.CheckBox checkModulos_NuevoUsuario_design;
        private System.Windows.Forms.TextBox txtModulos_NuevoUsuario_passsword1;
        private System.Windows.Forms.Label lblModulos_NuevoUsuario_password1;
        private System.Windows.Forms.ComboBox comboModulos_NuevoUsuario_nombre;
        private System.Windows.Forms.Label lblModulos_NuevoUsuario_nombre;
        private System.Windows.Forms.TextBox txtModulos_NuevoUsuario_passsword2;
        private System.Windows.Forms.TextBox txtModulos_NuevoUsuario_username;
        private System.Windows.Forms.Button btnModulos_NuevoUsuario_limpiar;
        private System.Windows.Forms.Button btnModulos_NuevoUsuario_crearUsuario;
        private System.Windows.Forms.Label lblModulos_NuevoUsuario_password2;
        private System.Windows.Forms.Label lblModulos_NuevoUsuario_username;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblModulos_NuevoUsuario_nuevoUsuario;
        private System.Windows.Forms.Label lblModulos_NuevoUsuario_protank;
        private protankDataSet protankDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private protankDataSetTableAdapters.empleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.BindingSource empleadosapellidosnombresBindingSource;
        private protankDataSetTableAdapters.empleados_apellidos_nombresTableAdapter empleados_apellidos_nombresTableAdapter;
        private protankDataSet protankDataSet1;
        private System.Windows.Forms.BindingSource empleadosapellidosnombresBindingSource1;
    }
}