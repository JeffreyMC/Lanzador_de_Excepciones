using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Tarea 2 Programación Avanzada
//Estudiante: Jeffrey Muñoz Castro
//Cédula: 1-1370-0324
//Profesor: Henry Mendez Chavarría
//Primer Cuatrimestre 2017

namespace Tarea2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void botonExcepciones_Click(object sender, EventArgs e)
        {
            //Se crea el objeto del formulario de excepciones y se muestra
            Exepciones ventana1 = new Exepciones();
            ventana1.Show();
        }

        private void botonControles_Click(object sender, EventArgs e)
        {
            //se crea el objeto del formulario de controles y se muestra
            Controles ventana2 = new Controles();
            ventana2.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
