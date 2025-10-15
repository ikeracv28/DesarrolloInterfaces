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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuCartaPedidos = new System.Windows.Forms.MenuStrip();
            this.cartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControl13 = new DI_A1._8.UserControl1();
            this.userControl12 = new DI_A1._8.UserControl1();
            this.userControl11 = new DI_A1._8.UserControl1();
            this.lblProductos = new System.Windows.Forms.Label();
            this.btnVolverPedidos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuCartaPedidos.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.menuCartaPedidos);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 110);
            this.panel1.TabIndex = 11;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(246, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(276, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nuestra Carta";
            // 
            // menuCartaPedidos
            // 
            this.menuCartaPedidos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuCartaPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartaToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuCartaPedidos.Location = new System.Drawing.Point(0, 0);
            this.menuCartaPedidos.Name = "menuCartaPedidos";
            this.menuCartaPedidos.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuCartaPedidos.Size = new System.Drawing.Size(807, 24);
            this.menuCartaPedidos.TabIndex = 1;
            this.menuCartaPedidos.Text = "menuStrip1";
            // 
            // cartaToolStripMenuItem
            // 
            this.cartaToolStripMenuItem.Name = "cartaToolStripMenuItem";
            this.cartaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.cartaToolStripMenuItem.Text = "Carta";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // userControl13
            // 
            this.userControl13.AutoSize = true;
            this.userControl13.BackColor = System.Drawing.Color.DarkTurquoise;
            this.userControl13.Location = new System.Drawing.Point(321, 308);
            this.userControl13.Name = "userControl13";
            this.userControl13.NombreProducto = "Croissant";
            this.userControl13.Size = new System.Drawing.Size(126, 60);
            this.userControl13.TabIndex = 10;
            // 
            // userControl12
            // 
            this.userControl12.AutoSize = true;
            this.userControl12.BackColor = System.Drawing.Color.DarkTurquoise;
            this.userControl12.Location = new System.Drawing.Point(321, 236);
            this.userControl12.Name = "userControl12";
            this.userControl12.NombreProducto = "Te Verde";
            this.userControl12.Size = new System.Drawing.Size(126, 66);
            this.userControl12.TabIndex = 9;
            // 
            // userControl11
            // 
            this.userControl11.AutoSize = true;
            this.userControl11.BackColor = System.Drawing.Color.DarkTurquoise;
            this.userControl11.Location = new System.Drawing.Point(321, 163);
            this.userControl11.Name = "userControl11";
            this.userControl11.NombreProducto = "Cafe Latte";
            this.userControl11.Size = new System.Drawing.Size(126, 67);
            this.userControl11.TabIndex = 8;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(62, 142);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(225, 23);
            this.lblProductos.TabIndex = 7;
            this.lblProductos.Text = "Productos disponibles";
            // 
            // btnVolverPedidos
            // 
            this.btnVolverPedidos.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolverPedidos.Location = new System.Drawing.Point(321, 383);
            this.btnVolverPedidos.Name = "btnVolverPedidos";
            this.btnVolverPedidos.Size = new System.Drawing.Size(126, 62);
            this.btnVolverPedidos.TabIndex = 6;
            this.btnVolverPedidos.Text = "Volver";
            this.btnVolverPedidos.UseVisualStyleBackColor = false;
            // 
            // FormCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnVolverPedidos);
            this.Controls.Add(this.btnVolverCarta);
            this.Name = "FormCarta";
            this.Text = "FormCarta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuCartaPedidos.ResumeLayout(false);
            this.menuCartaPedidos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverCarta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuCartaPedidos;
        private System.Windows.Forms.ToolStripMenuItem cartaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private UserControl1 userControl13;
        private UserControl1 userControl12;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Button btnVolverPedidos;
    }
}