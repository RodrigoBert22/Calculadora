using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPOO
{
    public partial class Form1 : Form
    {
        Calcular calcular = new Calcular();
        bool operacaoFormada;
        string operador;
        public double valor1;
        public double resultado;
        public double valor2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Numero(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operacaoFormada)
                txtDisplay.Clear();

            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
            operacaoFormada = false;
        }

        private void Operador(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtDisplay.Text);
            operacaoFormada = true;
            Button btn = (Button)sender;
            string novoOperador = btn.Text;

            txtHist.Text = "";
            txtHist.Text = valor1.ToString() + " " + novoOperador;

            calcular.operadorCalc(novoOperador);


            operador = novoOperador;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtHist.Text = "";
            resultado = 0;
            calcular.resultado = 0;
            operador = "";
            valor1 = 0;
            valor1 = 0;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            txtHist.Text = "";
            valor2 = Convert.ToDouble(txtDisplay.Text);

            calcular.Calcula(valor1, valor2);

            txtHist.Text = valor1.ToString() + " " + calcular.operadorVar + " " + valor2.ToString();
            txtDisplay.Text = calcular.resultado.ToString();
           

        }
    }
}
