namespace ProTank_v1.View2
{
    partial class GenerarAforo
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
            this.panel17 = new System.Windows.Forms.Panel();
            this.numericUpDownDiametro = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLongitud = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCabeza = new System.Windows.Forms.NumericUpDown();
            this.comboBoxVolumen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.numericUpDownIteraciones = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPaso = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDiametro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCabeza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaso)).BeginInit();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Silver;
            this.panel17.Controls.Add(this.numericUpDownDiametro);
            this.panel17.Controls.Add(this.numericUpDownLongitud);
            this.panel17.Controls.Add(this.numericUpDownCabeza);
            this.panel17.Controls.Add(this.comboBoxVolumen);
            this.panel17.Controls.Add(this.label1);
            this.panel17.Controls.Add(this.button10);
            this.panel17.Controls.Add(this.numericUpDownIteraciones);
            this.panel17.Controls.Add(this.numericUpDownPaso);
            this.panel17.Controls.Add(this.label12);
            this.panel17.Controls.Add(this.label11);
            this.panel17.Controls.Add(this.label10);
            this.panel17.Controls.Add(this.label9);
            this.panel17.Controls.Add(this.label8);
            this.panel17.Controls.Add(this.comboBoxDiametro);
            this.panel17.Controls.Add(this.label6);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(417, 393);
            this.panel17.TabIndex = 16;
            // 
            // numericUpDownDiametro
            // 
            this.numericUpDownDiametro.DecimalPlaces = 2;
            this.numericUpDownDiametro.Location = new System.Drawing.Point(139, 63);
            this.numericUpDownDiametro.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownDiametro.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDiametro.Name = "numericUpDownDiametro";
            this.numericUpDownDiametro.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDiametro.TabIndex = 20;
            this.numericUpDownDiametro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDiametro.ValueChanged += new System.EventHandler(this.numericUpDownDiametro_ValueChanged);
            // 
            // numericUpDownLongitud
            // 
            this.numericUpDownLongitud.DecimalPlaces = 2;
            this.numericUpDownLongitud.Location = new System.Drawing.Point(139, 102);
            this.numericUpDownLongitud.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDownLongitud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLongitud.Name = "numericUpDownLongitud";
            this.numericUpDownLongitud.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLongitud.TabIndex = 19;
            this.numericUpDownLongitud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCabeza
            // 
            this.numericUpDownCabeza.DecimalPlaces = 2;
            this.numericUpDownCabeza.Location = new System.Drawing.Point(139, 142);
            this.numericUpDownCabeza.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownCabeza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCabeza.Name = "numericUpDownCabeza";
            this.numericUpDownCabeza.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCabeza.TabIndex = 18;
            this.numericUpDownCabeza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxVolumen
            // 
            this.comboBoxVolumen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVolumen.FormattingEnabled = true;
            this.comboBoxVolumen.Items.AddRange(new object[] {
            "litros",
            "cm3",
            "galones"});
            this.comboBoxVolumen.Location = new System.Drawing.Point(287, 180);
            this.comboBoxVolumen.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVolumen.Name = "comboBoxVolumen";
            this.comboBoxVolumen.Size = new System.Drawing.Size(104, 24);
            this.comboBoxVolumen.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(7, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Volumen:";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(108, 328);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(196, 37);
            this.button10.TabIndex = 12;
            this.button10.Text = "Generar tabla";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // numericUpDownIteraciones
            // 
            this.numericUpDownIteraciones.Location = new System.Drawing.Point(139, 271);
            this.numericUpDownIteraciones.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownIteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIteraciones.Name = "numericUpDownIteraciones";
            this.numericUpDownIteraciones.Size = new System.Drawing.Size(85, 22);
            this.numericUpDownIteraciones.TabIndex = 8;
            this.numericUpDownIteraciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownPaso
            // 
            this.numericUpDownPaso.Location = new System.Drawing.Point(139, 231);
            this.numericUpDownPaso.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPaso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPaso.Name = "numericUpDownPaso";
            this.numericUpDownPaso.Size = new System.Drawing.Size(85, 22);
            this.numericUpDownPaso.TabIndex = 7;
            this.numericUpDownPaso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPaso.ValueChanged += new System.EventHandler(this.numericUpDownPaso_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label12.Location = new System.Drawing.Point(11, 271);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Iteraciones:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label11.Location = new System.Drawing.Point(11, 231);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Paso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label10.Location = new System.Drawing.Point(7, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cabeza:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label9.Location = new System.Drawing.Point(7, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Longitud:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.Location = new System.Drawing.Point(7, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Diámetro:";
            // 
            // comboBoxDiametro
            // 
            this.comboBoxDiametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiametro.FormattingEnabled = true;
            this.comboBoxDiametro.Items.AddRange(new object[] {
            "cm",
            "pulgadas"});
            this.comboBoxDiametro.Location = new System.Drawing.Point(287, 61);
            this.comboBoxDiametro.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDiametro.Name = "comboBoxDiametro";
            this.comboBoxDiametro.Size = new System.Drawing.Size(104, 24);
            this.comboBoxDiametro.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label6.Location = new System.Drawing.Point(302, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Unidad";
            // 
            // GenerarAforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 393);
            this.Controls.Add(this.panel17);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerarAforo";
            this.Text = "GenerarAforo";
            this.Load += new System.EventHandler(this.GenerarAforo_Load);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCabeza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPaso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.NumericUpDown numericUpDownIteraciones;
        private System.Windows.Forms.NumericUpDown numericUpDownPaso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDiametro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBoxVolumen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDiametro;
        private System.Windows.Forms.NumericUpDown numericUpDownLongitud;
        private System.Windows.Forms.NumericUpDown numericUpDownCabeza;
    }
}