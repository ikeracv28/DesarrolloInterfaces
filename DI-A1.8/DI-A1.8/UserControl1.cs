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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        // esto es para poder editar el texto de un label del componente reutilizable en otros forms
        private String nombreProducto;
        public String NombreProducto
        {
            get { return nombreProducto; }
            set
            {
                nombreProducto = value;
                //nombre del label que queramos editar luego
                label1.Text = nombreProducto;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
