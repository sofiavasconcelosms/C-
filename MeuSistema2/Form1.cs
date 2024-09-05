using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuSistema2
{
    public partial class FrmMeuSistema : Form
    {

        //conversão e operadores aritimeticos
        int valor1;
        int valor2;
        int res; 
        public FrmMeuSistema()
        {
            InitializeComponent();
        }


        private void btnSoma_Click(object sender, EventArgs e)
        {
            //valor1 = txtParc1.Text;  //modo errado pois tem que converter

            valor1 = int.Parse(txtParc1.Text);
            valor2 = int.Parse(txtParc2.Text);
            // + , - , * , / , %

            //10/2 = 5
            //10%2 = 0 --> resto -->par
            //15%2 = 1           -->impar

            res = valor1 + valor2;
            //txtResult.Text = res;      //modo errado pois tem que converter
            txtResult.Text = Convert.ToString(res);
        }

        
        private void btnSubtr_Click(object sender, EventArgs e)
        {
            valor1=int.Parse(txtParc1.Text);
            valor2=int.Parse(txtParc2.Text);

            res = valor1 - valor2;

            txtResult.Text=Convert.ToString(res);
        }

       
        private void btnMulti_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txtParc1.Text);
            valor2 = int.Parse(txtParc2.Text);

            res = valor1 * valor2;  

            txtResult.Text=Convert.ToString(res);
        }

       
        private void btnDivi_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txtParc1.Text);
            valor2 = int.Parse(txtParc2.Text);

            res = valor1 / valor2;

            txtResult.Text = Convert.ToString(res);
        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(txtParc1.Text);
            valor2 = int.Parse(txtParc2.Text);

            res = valor1 % valor2;

            txtResult.Text = Convert.ToString(res);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
