namespace DI_A1._10_PracticarExamen
{
    partial class FormAgenda
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgenda));
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewImageColumn();
            Column2 = new DataGridViewComboBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            Column4 = new DataGridViewButtonColumn();
            pnlCabecera = new Panel();
            lblTitulo = new Label();
            menuStrip1 = new MenuStrip();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            ponentesToolStripMenuItem = new ToolStripMenuItem();
            ubicacionToolStripMenuItem = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lblPiePagina = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlCabecera.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(88, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(637, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            Column1.DefaultCellStyle = dataGridViewCellStyle3;
            Column1.HeaderText = "Conferencia de apertura";
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Taller de IA aplicada";
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Taller de Fronted";
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Taller de Backend";
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = SystemColors.ActiveCaption;
            pnlCabecera.Controls.Add(lblTitulo);
            pnlCabecera.Controls.Add(menuStrip1);
            pnlCabecera.Dock = DockStyle.Top;
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(840, 109);
            pnlCabecera.TabIndex = 2;
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
            menuStrip1.Size = new Size(840, 24);
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
            panel1.Location = new Point(0, 522);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 51);
            panel1.TabIndex = 3;
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
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "iker", "richi", "iris", "cristian feo", "rafa", "marcos", "" });
            listBox1.Location = new Point(302, 250);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(190, 139);
            listBox1.TabIndex = 4;
            // 
            // FormAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 573);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(pnlCabecera);
            Controls.Add(dataGridView1);
            Name = "FormAgenda";
            Text = "FormAgenda";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel pnlCabecera;
        private Label lblTitulo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem agendaToolStripMenuItem;
        private ToolStripMenuItem ponentesToolStripMenuItem;
        private ToolStripMenuItem ubicacionToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem;
        private Panel panel1;
        private Label lblPiePagina;
        private DataGridViewImageColumn Column1;
        private DataGridViewComboBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
        private DataGridViewButtonColumn Column4;
        private ListBox listBox1;
    }
}