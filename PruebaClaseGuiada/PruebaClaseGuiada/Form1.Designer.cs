namespace PruebaClaseGuiada
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHola = new System.Windows.Forms.Button();
            this.lblSaludos = new System.Windows.Forms.Label();
            this.userControl11 = new PruebaClaseGuiada.UserControl1();
            this.userControl12 = new PruebaClaseGuiada.UserControl1();
            this.SuspendLayout();
            // 
            // btnHola
            // 
            this.btnHola.BackColor = System.Drawing.SystemColors.Info;
            this.btnHola.Location = new System.Drawing.Point(293, 69);
            this.btnHola.Name = "btnHola";
            this.btnHola.Size = new System.Drawing.Size(165, 98);
            this.btnHola.TabIndex = 0;
            this.btnHola.Text = "Saludar";
            this.btnHola.UseVisualStyleBackColor = false;
            this.btnHola.Click += new System.EventHandler(this.btnHola_Click);
            // 
            // lblSaludos
            // 
            this.lblSaludos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSaludos.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSaludos.Location = new System.Drawing.Point(236, 9);
            this.lblSaludos.Name = "lblSaludos";
            this.lblSaludos.Size = new System.Drawing.Size(292, 57);
            this.lblSaludos.TabIndex = 1;
            this.lblSaludos.Text = "Ventana de saludos";
            // 
            // userControl11
            // 
            this.userControl11.AutoSize = true;
            this.userControl11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userControl11.Location = new System.Drawing.Point(49, 173);
            this.userControl11.Mensaje = "Adios mundo cruel";
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(627, 87);
            this.userControl11.TabIndex = 2;
            // 
            // userControl12
            // 
            this.userControl12.AutoSize = true;
            this.userControl12.BackColor = System.Drawing.SystemColors.Highlight;
            this.userControl12.Location = new System.Drawing.Point(64, 292);
            this.userControl12.Mensaje = "HolaMundo";
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(645, 81);
            this.userControl12.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.lblSaludos);
            this.Controls.Add(this.btnHola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHola;
        private System.Windows.Forms.Label lblSaludos;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
    }
}

