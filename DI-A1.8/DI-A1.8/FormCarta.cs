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
    public partial class FormCarta : Form
    {
        public FormCarta()
        {
            InitializeComponent();
        }

        private void btnVolverCarta_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
        }
    }
}
