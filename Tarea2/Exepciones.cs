using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Exepciones : Form
    {
        public Exepciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se asignan dos valores enteros y luego se dividen
            //por lo que arroja la excepción de división entre cero
            int a = 7, b = 0;
            int c = a / 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //se intenta darle un formato no permitido a la cadena 'Hola'
            //se trata el tipo string como un tipo numérico
            string var = "Hola";
            Console.WriteLine("Esta línea no se desplegará {0.2}", var);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //se crea un arreglo de enteros de 3 posiciones (0, 1, 2)
            int[] arreglo = new int[3];
            //se trata de asignar un valor a un índice fuera del rango estipulado (3)
            arreglo[3] = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //se crea una variable string y se inicializa como null
            string var = null;
            //se trata de aplicar un método a esa variable con referencia nula
            //el método trata de devolver la cadena var en minúsculas
            var.ToLower();
        }
    }
}
