using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //lista.Items.Add(1);
            //lista.Items.Add(2);
            //lista.Items.Add(3);
            //lista.Items.Add(50);

            //FOR (para)

            for (int valor=0; valor<=50; valor++) //++ incremento
            {
                lista.Items.Add(valor);
            }

        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            for(int valorII = 50; valorII >= 0; valorII--) //-- decremento
            {
                lista2.Items.Add(valorII);
            }
        }



        private void btnImpares_Click(object sender, EventArgs e)
        {
            for(int valor3=1; valor3<=50; valor3 += 2)  //1+2=3+2=5...
            {
                NImpares.Items.Add(valor3);
            }
        }


        private void btnPar_Click(object sender, EventArgs e)
        {
            for(int valor4=0; valor4<=50; valor4 += 2) //0+2=2+2=4...
            {
                Npar.Items.Add(valor4);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
