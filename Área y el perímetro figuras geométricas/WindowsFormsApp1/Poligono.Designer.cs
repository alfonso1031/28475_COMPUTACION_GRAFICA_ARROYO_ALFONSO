namespace WindowsFormsApp1
{
    partial class Poligono
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.btnCalcularPoligono = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el perimetro del poligono: ";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(400, 48);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el apotema del poligono:";
            // 
            // txtApotema
            // 
            this.txtApotema.Location = new System.Drawing.Point(400, 141);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(100, 20);
            this.txtApotema.TabIndex = 3;
            // 
            // btnCalcularPoligono
            // 
            this.btnCalcularPoligono.Location = new System.Drawing.Point(590, 101);
            this.btnCalcularPoligono.Name = "btnCalcularPoligono";
            this.btnCalcularPoligono.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularPoligono.TabIndex = 4;
            this.btnCalcularPoligono.Text = "Calcular";
            this.btnCalcularPoligono.UseVisualStyleBackColor = true;
            this.btnCalcularPoligono.Click += new System.EventHandler(this.btnCalcularPoligono_Click);
            // 
            // Poligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCalcularPoligono);
            this.Controls.Add(this.txtApotema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.label1);
            this.Name = "Poligono";
            this.Text = "Poligono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.Button btnCalcularPoligono;
    }
}