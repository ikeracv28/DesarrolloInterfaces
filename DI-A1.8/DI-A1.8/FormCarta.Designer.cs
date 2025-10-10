namespace DI_A1._8
{
    partial class FormCarta
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
            this.btnVolverCarta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolverCarta
            // 
            this.btnVolverCarta.Location = new System.Drawing.Point(335, 306);
            this.btnVolverCarta.Name = "btnVolverCarta";
            this.btnVolverCarta.Size = new System.Drawing.Size(115, 61);
            this.btnVolverCarta.TabIndex = 0;
            this.btnVolverCarta.Text = "Volver";
            this.btnVolverCarta.UseVisualStyleBackColor = true;
            this.btnVolverCarta.Click += new System.EventHandler(this.btnVolverCarta_Click);
            // 
            // FormCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverCarta);
            this.Name = "FormCarta";
            this.Text = "FormCarta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolverCarta;
    }
}