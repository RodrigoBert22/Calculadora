using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{

    public partial class Form1 : Form
    {
        bool operacaoFormada = false;
        string operador = "";
        double resultado = 0;
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
            operacaoFormada = true;
            Button btn = (Button)sender;
            string novoOperador = btn.Text;

            txtHist.Text = txtHist.Text + " " + txtDisplay.Text + " " + novoOperador;

            switch (operador)
            {
                case "+": txtDisplay.Text = (resultado + Double.Parse(txtDisplay.Text)).ToString(); break;
                case "-": txtDisplay.Text = (resultado - Double.Parse(txtDisplay.Text)).ToString(); break;
                case "x": txtDisplay.Text = (resultado * Double.Parse(txtDisplay.Text)).ToString(); break;
                case "÷": txtDisplay.Text = (resultado / Double.Parse(txtDisplay.Text)).ToString(); break;
                default: break;
            }


            resultado = Double.Parse(txtDisplay.Text);
            operador = novoOperador;

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtHist.Text = "";
            resultado = 0;
            operador = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            txtHist.Text = "";
            operacaoFormada = true;

            switch (operador)
            {
                case "+": txtDisplay.Text = (resultado + Double.Parse(txtDisplay.Text)).ToString(); break;
                case "-": txtDisplay.Text = (resultado - Double.Parse(txtDisplay.Text)).ToString(); break;
                case "x": txtDisplay.Text = (resultado * Double.Parse(txtDisplay.Text)).ToString(); break;
                case "÷": txtDisplay.Text = (resultado / Double.Parse(txtDisplay.Text)).ToString(); break;
                default: break;
            }

            resultado = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = resultado.ToString();
            resultado = 0;
            operador = "";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!operacaoFormada && !txtDisplay.Text.Contains(","))
            {
                txtDisplay.Text += ",";
            }
            else if (operacaoFormada)
            {
                txtDisplay.Text = "0";
            }

            if (!txtDisplay.Text.Contains(","))
            {
                txtDisplay.Text += ",";
            }

            operacaoFormada = false;
        }


    }
}

