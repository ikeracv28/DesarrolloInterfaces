namespace DI_A1._10_PracticarExamen
{
    partial class FormRegistro
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            btnEnviar = new Button();
            btnCancelar = new Button();
            pnlCabecera.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
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
            pnlCabecera.Size = new Size(804, 109);
            pnlCabecera.TabIndex = 1;
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
            menuStrip1.Size = new Size(804, 24);
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
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblPiePagina);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 438);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 51);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 144);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 218);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "IA", "Conferencia de apertura" });
            comboBox1.Location = new Point(302, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Seleccione actividad";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(302, 320);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 10;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(494, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 489);
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviar);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pnlCabecera);
            Name = "FormRegistro";
            Text = "FormRegistro";
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button btnEnviar;
        private Button btnCancelar;
    }
}