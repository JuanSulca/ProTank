﻿namespace ProTank_v1.View3
{
    partial class MostrarHerramientas
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
            this.tableModulos_Contratos_tabla.Location = new System.Drawing.Point(0, 69);
            this.tableModulos_Contratos_tabla.Margin = new System.Windows.Forms.Padding(2);
            this.tableModulos_Contratos_tabla.Name = "tableModulos_Contratos_tabla";
            this.tableModulos_Contratos_tabla.ReadOnly = true;
            this.tableModulos_Contratos_tabla.RowHeadersVisible = false;
            this.tableModulos_Contratos_tabla.RowTemplate.Height = 31;
            this.tableModulos_Contratos_tabla.Size = new System.Drawing.Size(847, 381);
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
            this.panContratos_header.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panContratos_header.Name = "panContratos_header";
            this.panContratos_header.Size = new System.Drawing.Size(847, 69);
            this.panContratos_header.TabIndex = 10;
            // 
            // lblContratos_contratos
            // 
            this.lblContratos_contratos.AutoSize = true;
            this.lblContratos_contratos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblContratos_contratos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratos_contratos.ForeColor = System.Drawing.Color.Lavender;
            this.lblContratos_contratos.Location = new System.Drawing.Point(702, 24);
            this.lblContratos_contratos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContratos_contratos.Name = "lblContratos_contratos";
            this.lblContratos_contratos.Size = new System.Drawing.Size(134, 22);
            this.lblContratos_contratos.TabIndex = 1;
            this.lblContratos_contratos.Text = "Herramientas";
            // 
            // lblContratos_protank
            // 
            this.lblContratos_protank.AutoSize = true;
            this.lblContratos_protank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContratos_protank.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblContratos_protank.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContratos_protank.ForeColor = System.Drawing.Color.White;
            this.lblContratos_protank.Location = new System.Drawing.Point(81, 9);
            this.lblContratos_protank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContratos_protank.Name = "lblContratos_protank";
            this.lblContratos_protank.Size = new System.Drawing.Size(143, 44);
            this.lblContratos_protank.TabIndex = 0;
            this.lblContratos_protank.Text = "ProTank";
            // 
            // MostrarHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.tableModulos_Contratos_tabla);
            this.Controls.Add(this.panContratos_header);
            this.Name = "MostrarHerramientas";
            this.Text = "MostrarHerramientas";
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