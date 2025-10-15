using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DI_A1._8
{
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void btnVolverPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblProductos_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbNombre.Text = "";
            txbProducto.Text = "";
            txbCantidad.Text = "";

        }
    }
}
