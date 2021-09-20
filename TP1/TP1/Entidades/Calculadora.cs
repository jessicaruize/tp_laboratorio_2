using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Hace operaciones entre los atributos numero de los objetos Operando pasados por parametro, segun el caracter que le pasen. 
        /// </summary>
        /// <param name="num1"></param>primer operando
        /// <param name="num2"></param>segundo operando
        /// <param name="operador"></param>puede ser + - / ò * (si se para cualquier otra cosa, sera pasado el +.)
        /// <returns></returns>resultado de dicha operaciòn. Si en la division ingresan como segundo operando un cero, devolvera el valor mìnimo de un double.
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado;
            switch(ValidarOperando(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                default:
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida que el operador sea un valor valido + - / *
        /// </summary>
        /// <param name="operador"></param>operador a validar
        /// <returns></returns> retorna el operador, si no es un operador valido retornara el +.
        private static char ValidarOperando(char operador)
        {
            if (operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }
    }
}
