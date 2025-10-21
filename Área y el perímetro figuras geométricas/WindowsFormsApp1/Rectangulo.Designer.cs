namespace WindowsFormsApp1
{
    partial class Rectangulo
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
            this.lblPrimerLado = new System.Windows.Forms.Label();
            this.lblSegundoLado = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimerLado
            // 
            this.lblPrimerLado.AutoSize = true;
            this.lblPrimerLado.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblPrimerLado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrimerLado.Location = new System.Drawing.Point(132, 60);
            this.lblPrimerLado.Name = "lblPrimerLado";
            this.lblPrimerLado.Size = new System.Drawing.Size(177, 13);
            this.lblPrimerLado.TabIndex = 0;
            this.lblPrimerLado.Text = "Ingrese el primer lado del rectangulo";
            // 
            // lblSegundoLado
            // 
            this.lblSegundoLado.AutoSize = true;
            this.lblSegundoLado.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblSegundoLado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSegundoLado.Location = new System.Drawing.Point(135, 127);
            this.lblSegundoLado.Name = "lblSegundoLado";
            this.lblSegundoLado.Size = new System.Drawing.Size(190, 13);
            this.lblSegundoLado.TabIndex = 1;
            this.lblSegundoLado.Text = "Ingrese el segundo lado del rectangulo";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(384, 60);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 2;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(384, 119);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Location = new System.Drawing.Point(412, 242);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(568, 94);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Rectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.lblSegundoLado);
            this.Controls.Add(this.lblPrimerLado);
            this.Name = "Rectangulo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Calcular el area de un rectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimerLado;
        private System.Windows.Forms.Label lblSegundoLado;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}