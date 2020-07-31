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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int fila = 3;  //Dimension de Fil
        int columna = 3; //?Dimensiones de Col
        
        int f=0,c=0; //Indices de la Matriz

        int n = 0; //Contador
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] Num = new int[fila, columna]; //Declarando la Matriz

            //El primer ciclo recorre Filas (f)
            for (f = 0; f < fila; f++) {
                //El segundo ciclo recorre Columnas (c)
                for (c = 0; c < columna; c++)
                {
                    Num[f,c] = n;
                    n++;
                }
            }
            //Mostrando los valores de la Matriz
            for (f = 0; f < fila; f++)
            {
                for (c = 0; c < columna; c++)
                {
                    TxtMostrar.Text += "M["+f+","+c+"] : "+Num[f,c].ToString() +"\t"; //Contatena los valores de la Magtriz con una Tab
                }
                TxtMostrar.Text += "\r\n"; //Genera un salto de linea
            }  
                
        }

    }
}
