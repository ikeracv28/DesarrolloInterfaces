using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_A1._8
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void MenuInicio_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            FormCarta formCarta = new FormCarta();
            formCarta.Show();
            this.SetVisibleCore(false);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show();
            this.SetVisibleCore(true);
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedidos formPedidos = new FormPedidos();
            formPedidos.Show();
            this.SetVisibleCore(true);
        }
        

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarta formCarta = new FormCarta();
            formCarta.Show();
            this.SetVisibleCore(false);
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void lblSaludo_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }
    }
}
