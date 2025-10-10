namespace DI_A1._9
{
    partial class FormSecundario
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
            this.datosUsuarioControl1 = new DI_A1._9.DatosUsuarioControl();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datosUsuarioControl1
            // 
            this.datosUsuarioControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.datosUsuarioControl1.Location = new System.Drawing.Point(41, 12);
            this.datosUsuarioControl1.Name = "datosUsuarioControl1";
            this.datosUsuarioControl1.Size = new System.Drawing.Size(483, 301);
            this.datosUsuarioControl1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Beige;
            this.btnAceptar.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(199, 319);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(136, 68);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.datosUsuarioControl1);
            this.Name = "FormSecundario";
            this.Text = "FormSecundario";
            this.ResumeLayout(false);

        }

        #endregion

        private DatosUsuarioControl datosUsuarioControl1;
        private System.Windows.Forms.Button btnAceptar;
    }
}