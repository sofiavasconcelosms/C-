using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //For Each

            //string frase = "Meu curso C# na zatec cursos";
            ////lista.Items.Add(frase.ToUpper());

            ////string frase2 = "Meu nome é Sofia";
            ////lista.Items.Add(frase2.Length); //comprimento

            //foreach (char f in frase)
            //{ // para cada caracteres de frases dentro de f 

            //    lista.Items.Add(f);
            //}


            List<string> lista_nomes = new List<string>()
            {
                "leo", "jose", "alex", "alice", "bernardo", "marcia"
            };

            foreach (string ls in lista_nomes) 
            {
                lista.Items.Add(ls);
            }

        }
    }
}
