using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColecaoArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //ARRAYS,
            //10,20,30,40,50

            //int[] valores;
            //valores = new int[5]; //de indice 5 --> sempre começa com o indice 0
            //valores[0] = 10;
            //valores[1] = 20;
            //valores[2] = 30;
            //valores[3] = 40;
            //valores[4] = 50;

            //lista.Items.Add(valores[2]);


            //int[] valores = new int[] { 10, 20, 30, 40, 50, 60 }; // de zero a seis

            //foreach(int valor in valores)
            //    lista.Items.Add(valor);


            //int[] valores = new int[] { 10, 20, 30, 40, 50, 60 };
            //for (int indice = 0; indice <= 5; indice++) 
            //{ 
            //    lista.Items.Add(valores[indice]);
            //}


            int[] valores = new int[] { 10, 20, 30, 40, 50, 60, 20, 30, 40, 50, 60, 20, 30, 40, 50, 60, 70 };
            for (int indice = 0; indice< valores.Length/*comprimento*/; indice++)
                lista.Items.Add(valores[indice]);
            
        }
    }
}
