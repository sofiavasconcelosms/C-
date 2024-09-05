using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores
{
    public partial class Form1 : Form
    {

        //Declara variaveis 

        float not1, not2, not3, not4;
        float media;


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
            not1 = float.Parse(txtNota1.Text);
            not2 = float.Parse(txtNota2.Text);
            not3 = float.Parse(txtNota3.Text);
            not4 = float.Parse(txtNota4.Text);

            float soma = not1 +not2 + not3 + not4;

            media = soma/4;

            txtMedia.Text = Convert.ToString(media);

            //condição IF

            if (media == 7){
                lblSituacao.Text = "APROVADO NA MARRA";
            }
            else if (media > 7 && media < 10)
            {
                lblSituacao.Text = "APROVADO";

            }else if(media == 10)
            {
                lblSituacao.Text = "PARABENS PELA NOTA";
            }
            else
            {
                lblSituacao.Text = "REPROVADO";
            }

            /*
             Operadores:

            == --> igual
            != --> Diferende 
            && --> e  [Ex: if(media != 7 && MEDIA == 8)]
            || --> ou [Ex: if(media != 7 || MEDIA == 8)]
            >  --> maior
            <  --> menor
            >=  --> maior ou igual
            <=  --> menor ou igual


            INCREMENTO / DECREMENTO

            ++ --> MEDIA = ++ (media recebe mais um)
            -- --> MEDIA = -- (media recebe menos um)

            MEDIA += (Ela mesmo mais ela memso)
            MEDIA -= (Ela menos ela mesmo)

             */

        }
    }
}
