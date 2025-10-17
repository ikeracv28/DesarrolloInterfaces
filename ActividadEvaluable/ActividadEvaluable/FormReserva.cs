using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadEvaluable
{
    public partial class FormReserva : Form
    {
        public FormReserva()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            comboBox1.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void destinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormDestinos formDestinos = new FormDestinos();
            formDestinos.ShowDialog();
            
        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormOfertas formOfertas = new FormOfertas();
            formOfertas.ShowDialog();
            
        }
    }
}
