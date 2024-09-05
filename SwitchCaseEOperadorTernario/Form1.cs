using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCaseEOperadorTernario
{
    public partial class Form1 : Form
    {

        int valor=10;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //CONDIÇAO IF
            valor = int.Parse(txtNumero.Text);

            //if (valor==10)
            //{
            //    lblResultado.Text = "é 10";
            //}
            //else if (valor == 7)
            //{
            //    lblResultado.Text = "É 7";
            //}
            //else if(valor >= 50)
            //{
            //    lblResultado.Text = "Maior ou igual a 50";
            //}
            //else
            //{
            //    lblResultado.Text = "foi nenhuma";
            //}



            //switch(valor)
            //{
            //    case 10: //caso for dez -> 1 opçao
            //        lblResultado.Text = "É 10";
            //        //intruções
            //        break;
            //    case 7:
            //        lblResultado.Text = "É 7";
            //        break;
            //    case 50:
            //        lblResultado.Text = "É 50";
            //        break;
            //    default:
            //        lblResultado.Text = "Não foi achado";
            //        break;
            //}


            //Operador ternario

            lblResultado.Text = valor == 10 ? "SIMM" : "NÃOO"; 

            //if(valor == 10)
            //{
            //    lblResultado.Text = "Sim";
            //}
            //else{
            //    lblResultado.Text = "não";
            //}
        }

       
    }
}
