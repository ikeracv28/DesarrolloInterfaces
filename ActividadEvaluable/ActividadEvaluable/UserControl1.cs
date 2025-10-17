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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LLama al siguiente numero para mas informacion: 62222222");
        }
    }
}
