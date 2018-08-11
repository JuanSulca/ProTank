namespace ProTank_v1.View3
{
    partial class MostrarServicios
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
            this.tableModulos_Contratos_tabla = new System.Windows.Forms.DataGridView();
            this.panContratos_header = new System.Windows.Forms.Panel();
            this.lblContratos_contratos = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableModulos_Contratos_tabla)).BeginInit();
            this.panContratos_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableModulos_Contratos_tabla
            // 
            this.tableModulos_Contratos_tabla.AllowUserToAddRows = false;
            this.tableModulos_Contratos_tabla.AllowUserToDeleteRows = false;
            this.tableModulos_Contratos_tabla.AllowUserToResizeRows = false;
            this.tableModulos_Contratos_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableModulos_Contratos_tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableModulos_Contratos_tabla.Location = new System.Drawing.Point(0, 85);
            this.tableModulos_Contratos_tabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableModulos_Contratos_tabla.Name = "tableModulos_Contratos_tabla";
            this.tableModulos_Contratos_tabla.ReadOnly = true;
            this.tableModulos_Contratos_tabla.RowHeadersVisible = false;
            this.tableModulos_Contratos_tabla.RowTemplate.Height = 31;
            this.tableModulos_Contratos_tabla.Size = new System.Drawing.Size(1067, 469);
            this.tableModulos_Contratos_tabla.TabIndex = 9;
            // 
            // panContratos_header
            // 
            this.panContratos_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panContratos_header.Controls.Add(this.button10);
            this.panContratos_header.Controls.Add(this.lblContratos_contratos);
            this.panContratos_header.Cursor = System.Windows.Forms.Cursors.Default;
            this.panContratos_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panContratos_header.Location = new System.Drawing.Point(0, 0);
            this.panContratos_header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panContratos_header.Name = "panContratos_header";
            this.panContratos_header.Size = new System.Drawing.Size(1067, 85);
            this.panContratos_header.TabIndex = 10;
            // 
            // lblContratos_contratos
            // 
            this.lblContratos_contratos.AutoSize = true;
            this.lblContratos_contratos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblContratos_contratos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratos_contratos.ForeColor = System.Drawing.Color.Lavender;
            this.lblContratos_contratos.Location = new System.Drawing.Point(117, 30);
            this.lblContratos_contratos.Name = "lblContratos_contratos";
            this.lblContratos_contratos.Size = new System.Drawing.Size(121, 28);
            this.lblContratos_contratos.TabIndex = 1;
            this.lblContratos_contratos.Text = "Servicios";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(917, 28);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(137, 37);
            this.button10.TabIndex = 14;
            this.button10.Text = "Regresar";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // MostrarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableModulos_Contratos_tabla);
            this.Controls.Add(this.panContratos_header);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MostrarServicios";
            this.Text = "MostrarServicios";
            this.Load += new System.EventHandler(this.MostrarServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableModulos_Contratos_tabla)).EndInit();
            this.panContratos_header.ResumeLayout(false);
            this.panContratos_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableModulos_Contratos_tabla;
        private System.Windows.Forms.Panel panContratos_header;
        private System.Windows.Forms.Label lblContratos_contratos;
        private System.Windows.Forms.Button button10;
    }
}