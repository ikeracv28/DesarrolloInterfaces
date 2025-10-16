using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_A1._10_PracticarExamen
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }




        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro enviado");
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro cancelado");
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
