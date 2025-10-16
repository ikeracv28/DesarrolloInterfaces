namespace DI_A1._10_PracticarExamen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            btnAgenda = new Button();
            btnPonentes = new Button();
            btnUbiccion = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            pnlCabecera.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCabecera.BackColor = SystemColors.ActiveCaption;
            pnlCabecera.Controls.Add(lblTitulo);
            pnlCabecera.Controls.Add(menuStrip1);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(815, 109);
            pnlCabecera.TabIndex = 0;
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
            lblTitulo.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { agendaToolStripMenuItem, ponentesToolStripMenuItem, ubicacionToolStripMenuItem, registroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(815, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
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
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblPiePagina);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 434);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 51);
            panel1.TabIndex = 1;
            // 
            // lblPiePagina
            // 
            lblPiePagina.AutoSize = true;
            lblPiePagina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPiePagina.Location = new Point(272, 18);
            lblPiePagina.Name = "lblPiePagina";
            lblPiePagina.Size = new Size(288, 21);
            lblPiePagina.TabIndex = 0;
            lblPiePagina.Text = "© Eventos 360 - contacto@eventos.com";
            lblPiePagina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgenda
            // 
            btnAgenda.Location = new Point(262, 178);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(126, 60);
            btnAgenda.TabIndex = 2;
            btnAgenda.Text = "Agenda";
            btnAgenda.UseVisualStyleBackColor = true;
            // 
            // btnPonentes
            // 
            btnPonentes.Location = new Point(438, 178);
            btnPonentes.Name = "btnPonentes";
            btnPonentes.Size = new Size(126, 60);
            btnPonentes.TabIndex = 3;
            btnPonentes.Text = "Ponentes";
            btnPonentes.UseVisualStyleBackColor = true;
            // 
            // btnUbiccion
            // 
            btnUbiccion.Location = new Point(262, 263);
            btnUbiccion.Name = "btnUbiccion";
            btnUbiccion.Size = new Size(126, 60);
            btnUbiccion.TabIndex = 4;
            btnUbiccion.Text = "Ubicación";
            btnUbiccion.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(438, 263);
            button4.Name = "button4";
            button4.Size = new Size(126, 60);
            button4.TabIndex = 5;
            button4.Text = "Registro";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "IA", "Conferencia de apertura" });
            comboBox1.Location = new Point(96, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Seleccione actividad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 485);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(btnUbiccion);
            Controls.Add(btnPonentes);
            Controls.Add(btnAgenda);
            Controls.Add(panel1);
            Controls.Add(pnlCabecera);
            Name = "Form1";
            Text = "Form1";
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Button btnAgenda;
        private Button btnPonentes;
        private Button btnUbiccion;
        private Button button4;
        private ComboBox comboBox1;
    }
}
