namespace DI_A1._10_PracticarExamen
{
    partial class FormPonentes
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
            pnlCabecera = new Panel();
            lblTitulo = new Label();
            menuStrip1 = new MenuStrip();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            ponentesToolStripMenuItem = new ToolStripMenuItem();
            ubicacionToolStripMenuItem = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lblPiePagina = new Label();
            pictureBox1 = new PictureBox();
            lblFoto1 = new Label();
            label1 = new Label();
            pnlCabecera.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = SystemColors.ActiveCaption;
            pnlCabecera.Controls.Add(lblTitulo);
            pnlCabecera.Controls.Add(menuStrip1);
            pnlCabecera.Dock = DockStyle.Top;
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(788, 109);
            pnlCabecera.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Franklin Gothic Medium", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(302, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(229, 43);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Eventos 360";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { agendaToolStripMenuItem, ponentesToolStripMenuItem, ubicacionToolStripMenuItem, registroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(788, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(60, 20);
            agendaToolStripMenuItem.Text = "Agenda";
            // 
            // ponentesToolStripMenuItem
            // 
            ponentesToolStripMenuItem.Name = "ponentesToolStripMenuItem";
            ponentesToolStripMenuItem.Size = new Size(68, 20);
            ponentesToolStripMenuItem.Text = "Ponentes";
            // 
            // ubicacionToolStripMenuItem
            // 
            ubicacionToolStripMenuItem.Name = "ubicacionToolStripMenuItem";
            ubicacionToolStripMenuItem.Size = new Size(72, 20);
            ubicacionToolStripMenuItem.Text = "Ubicacion";
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(62, 20);
            registroToolStripMenuItem.Text = "Registro";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblPiePagina);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 439);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 51);
            panel1.TabIndex = 4;
            // 
            // lblPiePagina
            // 
            lblPiePagina.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPiePagina.AutoSize = true;
            lblPiePagina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPiePagina.Location = new Point(272, 18);
            lblPiePagina.Name = "lblPiePagina";
            lblPiePagina.Size = new Size(288, 21);
            lblPiePagina.TabIndex = 0;
            lblPiePagina.Text = "© Eventos 360 - contacto@eventos.com";
            lblPiePagina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2025_10_12_a_las_13_16_51_26aff6ac__1_;
            pictureBox1.Location = new Point(69, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblFoto1
            // 
            lblFoto1.AutoSize = true;
            lblFoto1.Location = new Point(69, 232);
            lblFoto1.Name = "lblFoto1";
            lblFoto1.Size = new Size(116, 15);
            lblFoto1.TabIndex = 6;
            lblFoto1.Text = "Iker Acevedo Donate";
            // 
            // label1
            // 
            label1.Location = new Point(35, 262);
            label1.Name = "label1";
            label1.Size = new Size(205, 99);
            label1.TabIndex = 7;
            label1.Text = "Ingeniero en informática con más de 10 años de experiencia en desarrollo de software y ciberseguridad. Actualmente trabaja como líder de proyectos en una empresa tecnológica internacional.";
            // 
            // FormPonentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 490);
            Controls.Add(label1);
            Controls.Add(lblFoto1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(pnlCabecera);
            Name = "FormPonentes";
            Text = "Form2";
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecera;
        private Label lblTitulo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem agendaToolStripMenuItem;
        private ToolStripMenuItem ponentesToolStripMenuItem;
        private ToolStripMenuItem ubicacionToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem;
        private Panel panel1;
        private Label lblPiePagina;
        private PictureBox pictureBox1;
        private Label lblFoto1;
        private Label label1;
    }
}