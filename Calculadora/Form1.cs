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

        double primeiroValor;
        string operador;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void btnUm_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnUm.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "" +btnUm.Text;
            }

        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnDois.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "" + btnDois.Text;
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnTres.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "" + btnTres.Text;
            }
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnQuatro.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "" + btnQuatro.Text;
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnCinco.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "" + btnCinco.Text;
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnSeis.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "" + btnSeis.Text;
            }
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnSete.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "" + btnSete.Text;
            }
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnOito.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "" + btnOito.Text;
            }
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = btnNove.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "" + btnNove.Text;
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            txtHist.Text = " + "+ txtDisplay.Text;
            primeiroValor = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            operador = "+";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            txtHist.Text = " - " + txtDisplay.Text;
            primeiroValor = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            operador = "-";

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtHist.Text = " / " + txtDisplay.Text;
            primeiroValor = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            operador = "/";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txtHist.Text = " * " + txtDisplay.Text;
            primeiroValor = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "0";
            operador = "*";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double segundoValor;
            double resultado;

            txtHist.Text = txtDisplay.Text + txtHist.Text;
            segundoValor = Convert.ToDouble(txtDisplay.Text);

       

            if(operador == "+")
            {
                resultado = (primeiroValor + segundoValor);
                txtDisplay.Text = Convert.ToString(resultado);
                primeiroValor = resultado;
            }

            if(operador == "-")
            {
                resultado = (primeiroValor - segundoValor);
                txtDisplay.Text = Convert.ToString(resultado);
                primeiroValor = resultado;
            }

            if (operador == "*")
            {
                resultado = (primeiroValor * segundoValor);
                txtDisplay.Text = Convert.ToString(resultado);
                primeiroValor = resultado;
            }

            if (operador == "/")
            {
                if (segundoValor == 0)
                {
                    txtHist.Text = "Divisão por zero";
                    txtDisplay.Text = "0";
                    
                }
                else
                {
                    resultado = (primeiroValor / segundoValor);
                    txtDisplay.Text = Convert.ToString(resultado);
                    primeiroValor = resultado;
               }
            }

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHist.Text = "";
            txtDisplay.Text = "0";
            primeiroValor = 0;
            
        }
    }
}
