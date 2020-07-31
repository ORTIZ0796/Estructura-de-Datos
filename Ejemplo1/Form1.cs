using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Tipo de Dato entero int
            //Tipo de Dato real float
            //Tipo de Dato entero caracter char
            //Tipo de Dato entero Cadena string

            //-------------*-------------------

            int cant1, cant2, suma; //Tipo de Dato simple Entero
            cant1 = int.Parse(TxtA.Text);
            cant2 = int.Parse(TxtB.Text);
            suma = cant1 + cant2;
            TxtResp.Text = suma.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float cant1, cant2, suma;
            cant1 = float.Parse(TxtA.Text);
            cant2 = float.Parse(TxtB.Text);
            suma = cant1 + cant2;
            TxtRespR.Text = suma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char caracter;
            caracter = char.Parse(TxtC.Text);
            TxtCarac.Text = caracter.ToString();
            //'1' 'L' '%'
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cadena1,cadena2;

            cadena1 = TxtCad.Text;
            cadena2 = TxtCad2.Text;
            TxtSal.Text = cadena1 + cadena2;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            bool A, B;
            if(N1.Value == 1)
            {
                A = true;
            }
            else
            {
                A = false;
            }
            if (N2.Value == 1)
            {
                B = true;
            }
            else
            {
                B = false;
            }

            if ((A == false) && (B == false))
            {
                TxtN3.Text = "0";
            }
            else
            {
                TxtN3.Text = "1";
            }
        }
    }
}