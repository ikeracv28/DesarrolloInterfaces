using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuizy
{
    public partial class Form1 : Form
    {
        // Crear un objeto Random llamado randomizer
        // para generar números aleatorios.
        Random randomizer = new Random();

        // Estas variables enteras almacenan los números
        // para el problema de suma.
        int addend1;
        int addend2;
        


        /// <summary>
        /// Iniciar el cuestionario llenando todos los problemas
        /// y comenzando el temporizador.
        /// </summary>
        public void StartTheQuiz()
        {
            // Llenar el problema de suma.
            // Generar dos números aleatorios para sumar.
            // Almacenar los valores en las variables 'addend1' y 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convertir los dos números generados aleatoriamente
            // en cadenas para que puedan mostrarse
            // en los controles de etiqueta.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' es el nombre del control NumericUpDown.
            // Este paso asegura que su valor sea cero antes de
            // agregarle cualquier valor.
            sum.Value = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
