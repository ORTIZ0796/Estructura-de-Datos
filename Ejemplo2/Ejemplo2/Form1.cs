using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Num = new int[20]; //Arreglo unidimensional
        int i=0; //indice

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                    Num[i] = int.Parse(TxtNum.Text);
                    LbMostrar.Items.Add("Num["+i+"] : "+Num[i]);
                    i++; //incrementa el indice
                    TxtNum.Clear(); //Limpiar el ListBox
            }
            catch(Exception x)
            {
                MessageBox.Show("Error"+x);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sumatoria=0;
            float promedio=0;
            for (int a = 0; a < Num.Length; a++)
            {
                sumatoria += Num[a];
                //sumatoria = sumatoria + Num[a]
            }
            promedio = sumatoria / Num.Length;
            TxtProm.Text = promedio.ToString();
        }
    }
}
