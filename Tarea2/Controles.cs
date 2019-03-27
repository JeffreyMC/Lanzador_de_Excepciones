using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Tarea2
{
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //uso try..cacth por si no se ingresan numeros
            try
            {
                //se convierten el valor del monto a decimal // se utiliza numberFormat info para manejar los puntos como comas
                decimal monto1 = Convert.ToDecimal((monto.Text), new NumberFormatInfo() { NumberDecimalSeparator = "."});
                //se realiza la operación para obtener el valor del monto IVA
                decimal valorIVA = (monto1 * Convert.ToInt32(porcentaje.Value)) / 100;
                //se pasa el resultado de la operación al campo monto de IVA
                montoIVA.Text = valorIVA.ToString("0.##");

                //luego se pasa el resultado del total al campo de monto con iva
                resultado.Text = (monto1 + valorIVA).ToString("0.##");
            }
            catch(FormatException)
            {
                MessageBox.Show("Por favor ingrese solo datos numéricos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                monto.Text = "";
                monto.Focus(); //coloca el foco en la primera casilla
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
