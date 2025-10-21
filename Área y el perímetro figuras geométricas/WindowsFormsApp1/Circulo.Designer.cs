namespace WindowsFormsApp1
{
    partial class Circulo
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
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnCalcularCirculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(219, 79);
            this.lblRadio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(170, 16);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Ingrese el radio del circulo: ";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(468, 79);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(132, 22);
            this.txtRadio.TabIndex = 1;
            // 
            // btnCalcularCirculo
            // 
            this.btnCalcularCirculo.Location = new System.Drawing.Point(800, 74);
            this.btnCalcularCirculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularCirculo.Name = "btnCalcularCirculo";
            this.btnCalcularCirculo.Size = new System.Drawing.Size(100, 28);
            this.btnCalcularCirculo.TabIndex = 2;
            this.btnCalcularCirculo.Text = "Calcular";
            this.btnCalcularCirculo.UseVisualStyleBackColor = true;
            this.btnCalcularCirculo.Click += new System.EventHandler(this.btnCalcularCirculo_Click);
            // 
            // Circulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnCalcularCirculo);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Circulo";
            this.Text = "Circulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnCalcularCirculo;
    }
}