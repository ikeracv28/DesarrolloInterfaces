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
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblEleccion = new System.Windows.Forms.Label();
            this.userControl11 = new DI_A1._8.UserControl1();
            this.panel1.SuspendLayout();
            this.menuCartaPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarta
            // 
            this.btnCarta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCarta.Location = new System.Drawing.Point(134, 234);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(214, 57);
            this.btnCarta.TabIndex = 0;
            this.btnCarta.Text = "Ver Carta";
            this.btnCarta.UseVisualStyleBackColor = false;
            this.btnCarta.Click += new System.EventHandler(this.btnCarta_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPedidos.Location = new System.Drawing.Point(491, 234);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(214, 57);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Ver Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
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
            this.lblTitulo.Location = new System.Drawing.Point(205, 41);
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
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(206, 124);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(442, 31);
            this.lblSaludo.TabIndex = 4;
            this.lblSaludo.Text = "¡¡Bienvenido a nuestra tienda digital!!";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaludo.Click += new System.EventHandler(this.lblSaludo_Click);
            // 
            // lblEleccion
            // 
            this.lblEleccion.AutoSize = true;
            this.lblEleccion.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEleccion.Location = new System.Drawing.Point(259, 170);
            this.lblEleccion.Name = "lblEleccion";
            this.lblEleccion.Size = new System.Drawing.Size(352, 22);
            this.lblEleccion.TabIndex = 5;
            this.lblEleccion.Text = "Elige una opcion del menu para comenzar\r\n";
            // 
            // userControl11
            // 
            this.userControl11.AutoSize = true;
            this.userControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl11.Location = new System.Drawing.Point(321, 329);
            this.userControl11.Name = "userControl11";
            this.userControl11.NombreProducto = "Este es el cafe del dia";
            this.userControl11.Size = new System.Drawing.Size(183, 84);
            this.userControl11.TabIndex = 3;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load_1);
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEleccion);
            this.Controls.Add(this.lblSaludo);
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
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblEleccion;
    }
}

