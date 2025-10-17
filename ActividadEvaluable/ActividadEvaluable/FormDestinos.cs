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
    public partial class FormDestinos : Form
    {
        public FormDestinos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormOfertas formOfertas = new FormOfertas();
            formOfertas.ShowDialog();
            
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormReserva formReserva = new FormReserva();
            formReserva.ShowDialog();
            
        }
    }
}
