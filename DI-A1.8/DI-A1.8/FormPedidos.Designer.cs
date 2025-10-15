namespace DI_A1._8
{
    partial class FormPedidos
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
            this.btnVolverPedidos = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.userControl13 = new DI_A1._8.UserControl1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuCartaPedidos = new System.Windows.Forms.MenuStrip();
            this.cartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuCartaPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolverPedidos
            // 
            this.btnVolverPedidos.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolverPedidos.Location = new System.Drawing.Point(330, 367);
            this.btnVolverPedidos.Name = "btnVolverPedidos";
            this.btnVolverPedidos.Size = new System.Drawing.Size(126, 62);
            this.btnVolverPedidos.TabIndex = 0;
            this.btnVolverPedidos.Text = "Cancelar";
            this.btnVolverPedidos.UseVisualStyleBackColor = false;
            this.btnVolverPedidos.Click += new System.EventHandler(this.btnVolverPedidos_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(33, 121);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(315, 16);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Complete el formulario para realizar un pedido";
            this.lblProductos.Click += new System.EventHandler(this.lblProductos_Click);
            // 
            // userControl13
            // 
            this.userControl13.AutoSize = true;
            this.userControl13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userControl13.Location = new System.Drawing.Point(583, 209);
            this.userControl13.Name = "userControl13";
            this.userControl13.NombreProducto = "Producto seleccionado";
            this.userControl13.Size = new System.Drawing.Size(180, 77);
            this.userControl13.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.menuCartaPedidos);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 107);
            this.panel1.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(246, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(310, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Realizar Pedido";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // menuCartaPedidos
            // 
            this.menuCartaPedidos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuCartaPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartaToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuCartaPedidos.Location = new System.Drawing.Point(0, 0);
            this.menuCartaPedidos.Name = "menuCartaPedidos";
            this.menuCartaPedidos.Size = new System.Drawing.Size(804, 24);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(265, 180);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(254, 20);
            this.txbNombre.TabIndex = 9;
            this.txbNombre.TextChanged += new System.EventHandler(this.txbNombre_TextChanged);
            // 
            // txbProducto
            // 
            this.txbProducto.Location = new System.Drawing.Point(265, 229);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.Size = new System.Drawing.Size(254, 20);
            this.txbProducto.TabIndex = 10;
            this.txbProducto.TextChanged += new System.EventHandler(this.txbProducto_TextChanged);
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(265, 273);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(254, 20);
            this.txbCantidad.TabIndex = 11;
            this.txbCantidad.TextChanged += new System.EventHandler(this.txbCantidad_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(188, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 62);
            this.button1.TabIndex = 12;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(473, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 62);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.txbProducto);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnVolverPedidos);
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuCartaPedidos.ResumeLayout(false);
            this.menuCartaPedidos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverPedidos;
        private System.Windows.Forms.Label lblProductos;
        private UserControl1 userControl13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuCartaPedidos;
        private System.Windows.Forms.ToolStripMenuItem cartaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}