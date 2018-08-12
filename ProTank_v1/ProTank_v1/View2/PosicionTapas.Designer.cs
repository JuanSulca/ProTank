namespace ProTank_v1.View2
{
    partial class PosicionTapas
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAns = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownNumTapas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVolTapas = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumTapas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolTapas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Silver;
            this.panel17.Controls.Add(this.label3);
            this.panel17.Controls.Add(this.label2);
            this.panel17.Controls.Add(this.button1);
            this.panel17.Controls.Add(this.numericUpDownVolTapas);
            this.panel17.Controls.Add(this.numericUpDownNumTapas);
            this.panel17.Controls.Add(this.label1);
            this.panel17.Controls.Add(this.textBoxAns);
            this.panel17.Controls.Add(this.button10);
            this.panel17.Controls.Add(this.label9);
            this.panel17.Controls.Add(this.label8);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(423, 248);
            this.panel17.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Distancia:";
            // 
            // textBoxAns
            // 
            this.textBoxAns.Location = new System.Drawing.Point(245, 156);
            this.textBoxAns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAns.Name = "textBoxAns";
            this.textBoxAns.ReadOnly = true;
            this.textBoxAns.Size = new System.Drawing.Size(74, 22);
            this.textBoxAns.TabIndex = 15;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(12, 146);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(137, 37);
            this.button10.TabIndex = 12;
            this.button10.Text = "Calcular";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label9.Location = new System.Drawing.Point(7, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Volúmen por tapa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.Location = new System.Drawing.Point(7, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Número de Tapas:";
            // 
            // numericUpDownNumTapas
            // 
            this.numericUpDownNumTapas.Location = new System.Drawing.Point(177, 64);
            this.numericUpDownNumTapas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumTapas.Name = "numericUpDownNumTapas";
            this.numericUpDownNumTapas.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNumTapas.TabIndex = 17;
            this.numericUpDownNumTapas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownVolTapas
            // 
            this.numericUpDownVolTapas.DecimalPlaces = 2;
            this.numericUpDownVolTapas.Location = new System.Drawing.Point(177, 104);
            this.numericUpDownVolTapas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownVolTapas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVolTapas.Name = "numericUpDownVolTapas";
            this.numericUpDownVolTapas.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownVolTapas.TabIndex = 18;
            this.numericUpDownVolTapas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 194);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "[cm]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "[litros]";
            // 
            // PosicionTapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 248);
            this.Controls.Add(this.panel17);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PosicionTapas";
            this.Text = "PosicionTapas";
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumTapas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolTapas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAns;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownVolTapas;
        private System.Windows.Forms.NumericUpDown numericUpDownNumTapas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}