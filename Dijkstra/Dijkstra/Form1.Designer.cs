namespace Dijkstra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_calc = new System.Windows.Forms.Button();
            this.comboBox_Origen = new System.Windows.Forms.ComboBox();
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Dijkstra.Properties.Resources.logo_ryanair;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(321, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino:";
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(198, 220);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(74, 40);
            this.button_calc.TabIndex = 5;
            this.button_calc.Text = "Calcular distancia";
            this.button_calc.UseVisualStyleBackColor = true;
            // 
            // comboBox_Origen
            // 
            this.comboBox_Origen.FormattingEnabled = true;
            this.comboBox_Origen.Location = new System.Drawing.Point(49, 69);
            this.comboBox_Origen.Name = "comboBox_Origen";
            this.comboBox_Origen.Size = new System.Drawing.Size(220, 21);
            this.comboBox_Origen.TabIndex = 6;
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Location = new System.Drawing.Point(49, 166);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(223, 21);
            this.comboBox_destino.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 321);
            this.Controls.Add(this.comboBox_destino);
            this.Controls.Add(this.comboBox_Origen);
            this.Controls.Add(this.button_calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmo Dijkstra";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.ComboBox comboBox_Origen;
        private System.Windows.Forms.ComboBox comboBox_destino;
    }
}

