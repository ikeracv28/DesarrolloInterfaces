namespace DI_A1._8
{
    partial class MenuInicio
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
            this.btnCarta = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuCartaPedidos = new System.Windows.Forms.MenuStrip();
            this.cartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControl11 = new DI_A1._8.UserControl1();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuCartaPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarta
            // 
            this.btnCarta.Location = new System.Drawing.Point(199, 344);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(118, 57);
            this.btnCarta.TabIndex = 0;
            this.btnCarta.Text = "Carta";
            this.btnCarta.UseVisualStyleBackColor = true;
            this.btnCarta.Click += new System.EventHandler(this.btnCarta_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(486, 344);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(95, 57);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.menuCartaPedidos);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 103);
            this.panel1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(209, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(444, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "☕ Café Digital 2025 ☕";
            // 
            // menuCartaPedidos
            // 
            this.menuCartaPedidos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuCartaPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartaToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuCartaPedidos.Location = new System.Drawing.Point(0, 0);
            this.menuCartaPedidos.Name = "menuCartaPedidos";
            this.menuCartaPedidos.Size = new System.Drawing.Size(801, 24);
            this.menuCartaPedidos.TabIndex = 1;
            this.menuCartaPedidos.Text = "menuStrip1";
            this.menuCartaPedidos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cartaToolStripMenuItem
            // 
            this.cartaToolStripMenuItem.Name = "cartaToolStripMenuItem";
            this.cartaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.cartaToolStripMenuItem.Text = "Carta";
            this.cartaToolStripMenuItem.Click += new System.EventHandler(this.cartaToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.LightSlateGray;
            this.userControl11.Location = new System.Drawing.Point(148, 108);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(531, 196);
            this.userControl11.TabIndex = 3;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "👋👋 ¡¡Bienvenido a la pagina de nuestra tienda!! 👋👋";
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnCarta);
            this.MainMenuStrip = this.menuCartaPedidos;
            this.Name = "MenuInicio";
            this.Text = "MenuInicio";
            this.Load += new System.EventHandler(this.MenuInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuCartaPedidos.ResumeLayout(false);
            this.menuCartaPedidos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarta;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuCartaPedidos;
        private System.Windows.Forms.ToolStripMenuItem cartaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label label1;
    }
}

