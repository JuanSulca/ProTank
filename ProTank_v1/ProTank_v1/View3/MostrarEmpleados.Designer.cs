﻿namespace ProTank_v1.View3
{
    partial class MostrarEmpleados
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
            this.lblContratos_protank = new System.Windows.Forms.Label();
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
            this.tableModulos_Contratos_tabla.Size = new System.Drawing.Size(1156, 469);
            this.tableModulos_Contratos_tabla.TabIndex = 9;
            // 
            // panContratos_header
            // 
            this.panContratos_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panContratos_header.Controls.Add(this.lblContratos_contratos);
            this.panContratos_header.Controls.Add(this.lblContratos_protank);
            this.panContratos_header.Cursor = System.Windows.Forms.Cursors.Default;
            this.panContratos_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panContratos_header.Location = new System.Drawing.Point(0, 0);
            this.panContratos_header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panContratos_header.Name = "panContratos_header";
            this.panContratos_header.Size = new System.Drawing.Size(1156, 85);
            this.panContratos_header.TabIndex = 10;
            // 
            // lblContratos_contratos
            // 
            this.lblContratos_contratos.AutoSize = true;
            this.lblContratos_contratos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblContratos_contratos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratos_contratos.ForeColor = System.Drawing.Color.Lavender;
            this.lblContratos_contratos.Location = new System.Drawing.Point(992, 30);
            this.lblContratos_contratos.Name = "lblContratos_contratos";
            this.lblContratos_contratos.Size = new System.Drawing.Size(141, 28);
            this.lblContratos_contratos.TabIndex = 1;
            this.lblContratos_contratos.Text = "Empleados";
            // 
            // lblContratos_protank
            // 
            this.lblContratos_protank.AutoSize = true;
            this.lblContratos_protank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContratos_protank.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblContratos_protank.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratos_protank.ForeColor = System.Drawing.Color.White;
            this.lblContratos_protank.Location = new System.Drawing.Point(108, 11);
            this.lblContratos_protank.Name = "lblContratos_protank";
            this.lblContratos_protank.Size = new System.Drawing.Size(180, 56);
            this.lblContratos_protank.TabIndex = 0;
            this.lblContratos_protank.Text = "ProTank";
            // 
            // MostrarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 554);
            this.Controls.Add(this.tableModulos_Contratos_tabla);
            this.Controls.Add(this.panContratos_header);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MostrarEmpleados";
            this.Text = "MostrarEmpleados";
            this.Load += new System.EventHandler(this.MostrarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableModulos_Contratos_tabla)).EndInit();
            this.panContratos_header.ResumeLayout(false);
            this.panContratos_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableModulos_Contratos_tabla;
        private System.Windows.Forms.Panel panContratos_header;
        private System.Windows.Forms.Label lblContratos_contratos;
        private System.Windows.Forms.Label lblContratos_protank;
    }
}