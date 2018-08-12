namespace ProTank_v1.View3
{
    partial class NuevaVenta
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
            this.tablaVentas = new System.Windows.Forms.DataGridView();
            this.panContratos_header = new System.Windows.Forms.Panel();
            this.lblContratos_contratos = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).BeginInit();
            this.panContratos_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaVentas
            // 
            this.tablaVentas.AllowUserToResizeRows = false;
            this.tablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad,
            this.Item,
            this.PrecioUnitario,
            this.Precio});
            this.tablaVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaVentas.Location = new System.Drawing.Point(0, 85);
            this.tablaVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaVentas.Name = "tablaVentas";
            this.tablaVentas.RowHeadersVisible = false;
            this.tablaVentas.RowTemplate.Height = 31;
            this.tablaVentas.Size = new System.Drawing.Size(1067, 469);
            this.tablaVentas.TabIndex = 9;
            // 
            // panContratos_header
            // 
            this.panContratos_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.lblContratos_contratos.Location = new System.Drawing.Point(12, 27);
            this.lblContratos_contratos.Name = "lblContratos_contratos";
            this.lblContratos_contratos.Size = new System.Drawing.Size(92, 28);
            this.lblContratos_contratos.TabIndex = 1;
            this.lblContratos_contratos.Text = "Ventas";
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrecioUnitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tablaVentas);
            this.Controls.Add(this.panContratos_header);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NuevaVenta";
            this.Text = "NuevaVenta";
            this.Load += new System.EventHandler(this.NuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).EndInit();
            this.panContratos_header.ResumeLayout(false);
            this.panContratos_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaVentas;
        private System.Windows.Forms.Panel panContratos_header;
        private System.Windows.Forms.Label lblContratos_contratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}