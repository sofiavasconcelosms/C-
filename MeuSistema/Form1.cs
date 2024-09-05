using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuSistema
{
    public partial class FrmMeuSistema : Form
    {
        string meuNome = "";//texto

        //modificador //tipo //nome
        public string nome;
        private int valor;
        protected string senha;

        //mais usados 
        int numeros = 0;
        string endereco = "Digite seu end.";
        bool estarPago;
        double valores;
        decimal vPago;

        public FrmMeuSistema()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //txtFrase.Text = "Sofia Vasconcelos";

            meuNome = txtDigite.Text;

            txtFrase.Text = txtDigite.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtFrase.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
