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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            
        }

        private void destinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormDestinos destinos = new FormDestinos();
            destinos.ShowDialog();
             

        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormOfertas formOfertas = new FormOfertas();
            formOfertas.ShowDialog();
            
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormReserva formReserva = new FormReserva();
            formReserva.ShowDialog();
            
        }
    }
}
