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
    public partial class FormOfertas : Form
    {
        public FormOfertas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOferta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea viajar con la oferta seleccionada llame a: 62222222");
        }

        private void destinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormDestinos formDestinos = new FormDestinos();
            formDestinos.ShowDialog();
            
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormReserva formReserva = new FormReserva();
            formReserva.ShowDialog();
            
        }
    }
}
