using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Factory_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(textBox1.Text);
            double num2 = Convert.ToInt32(textBox2.Text);
            var factory = new Cls_operacionConcreta() as Interface_suma;
            var mysuma = factory.CreaOperacionSUMA(num1, num2);
            MessageBox.Show("EL RESULTADO DE LA SUMA ES: " + mysuma.num3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(textBox1.Text);
            double num2 = Convert.ToInt32(textBox2.Text);
            var factory = new Cls_operacionConcreta() as Interface_suma;
            var myresta = factory.creaoperacionRESTA(num1, num2);
            MessageBox.Show("EL RESULTADO DE LA RESTA ES: " + myresta.num3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(textBox1.Text);
            double num2 = Convert.ToInt32(textBox2.Text);
            var factory = new Cls_operacionConcreta() as Interface_suma;
            var mymultiplicacion = factory.creaoperacionMULTIPLICACION(num1, num2);
            MessageBox.Show("EL RESULTADO DE LA MULTIPLICACION ES: " + mymultiplicacion.num3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(textBox1.Text);
            double num2 = Convert.ToInt32(textBox2.Text);
            var factory = new Cls_operacionConcreta() as Interface_suma;
            var mydivicion = factory.creaoperacionDIVICION(num1, num2);
            MessageBox.Show("EL RESULTADO DE LA DIVICION ES: " + mydivicion.num3);
        }
    }
}
