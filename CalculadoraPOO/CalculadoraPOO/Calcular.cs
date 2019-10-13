using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
   
    public class Calcular
    {
        public string operadorVar;
        public double valor2;
        public double resultado { get; set; }

        public void operadorCalc(string operadorCalc)
        {
            operadorVar = operadorCalc;           
        }


        public double Calcula(double valor1, double valor2)
        {
            
            switch (operadorVar)
            {
                case "+": resultado = (valor1 + valor2); return resultado;
                case "-": resultado = (valor1 - valor2); return resultado;
                case "x": resultado = (valor1 * valor2); return resultado;
                case "÷": resultado = (valor1 / valor2);  return resultado;

                default: return 0;    

            }  
        }

    }
}
