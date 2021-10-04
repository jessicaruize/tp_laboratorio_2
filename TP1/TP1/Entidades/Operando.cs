using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        /// <summary>
        /// Atributo de la clase Operando
        /// </summary>
        private double numero;
        
        /// <summary>
        ///Constructor sin parametros. 
        /// Inicializa el atributo numero en cero.
        /// </summary>
        public Operando()
        {
        }

        /// <summary>
        /// Constructor con parametro.
        /// </summary>
        /// <param name="numero"></param> valor a cargar en el atributo numero.
        public Operando(double numero)
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor con parametro.
        /// </summary>
        /// <param name="strNumero"></param> valor que va a tomar el atributo numero.
        public Operando(string strNumero) 
        {
            Numero = strNumero;
        }
        
        /// <summary>
        /// Propiedad que va a cargar al atributo numero.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Valida que el string recibido por parametro pueda convertirse en double
        /// </summary>
        /// <param name="strNumero"></param> cadena a validar
        /// <returns></returns>Retorna 0 si no se pudo convertir o sino el numero convertido.
        public double ValidarOperando(string  strNumero)
        {
            double.TryParse(strNumero, out double retorno);
            return numero;
        }

        /// <summary>
        /// valida si el calor de un string es binario
        /// </summary>
        /// <param name="numero"></param> cadena a examinar.
        /// <returns></returns>true si es binario o false si no lo es.
        private bool EsBinario(string numero)
        {
            int i = 0;
            foreach(char caracter in numero)
            {
                if(caracter == '0' || caracter == '1')
                {
                    i++;
                }
            }
            return i == numero.Length;
        }

        /// <summary>
        /// Convierte un numero binario a decimal.
        /// </summary>
        /// <param name="binario"></param> numero a convertir.
        /// <returns></returns> retorna el numero convertido a decimal si pudo, si no "valor invàlido".
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invàlido.";
            double numero = 0;
            int cantidadCaracteres = binario.Length;
            if (EsBinario(binario))
            {
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;
                    if (caracter == '1')
                    {
                        numero += (int)Math.Pow(2, cantidadCaracteres);
                    }
                }
                retorno = numero.ToString();
            }
            return retorno;
        }

        /// <summary>
        /// Convierte un numero decimal a binario.
        /// </summary>
        /// <param name="numero"></param> numero a convertir.
        /// <returns></returns>devuelve el numero binario si pudo, si no "Valor invàlido".
        public string DecimalBinario(double numero)
        {
            string binario;
            binario = DecimalBinario(numero.ToString());
            return binario;
        }

        /// <summary>
        /// Convierte un decimal a binario.
        /// </summary>
        /// <param name="numero"></param> numero a convertir
        /// <returns></returns>Devuelve el numero convertido, si no "valor invàlido".
        public string DecimalBinario(string numero)
        {
            string binario = "Valor invàlido.";
            int resultadoDivision;
            int restoDivision;
            if (int.TryParse(numero, out resultadoDivision))
            {
                binario = "";
                do
                {
                    restoDivision = resultadoDivision % 2;
                    resultadoDivision /= 2;
                    binario = restoDivision.ToString() + binario;
                } while (resultadoDivision > 0);
                
            }
            return binario;
        }

        /// <summary>
        /// Sobrecarga de operadores que suma los atributos de la clases Operando recibidos.
        /// </summary>
        /// <param name="n1"></param>Operando a sumar.
        /// <param name="n2"></param>Operando a sumar.
        /// <returns></returns>retorna el resultado de la suma de los atributos numero de cada Operando.
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga de operadores que resta los atributos de la clases Operando recibidos.
        /// </summary>
        /// <param name="n1"></param>Operando a restar.
        /// <param name="n2"></param>Operando a restar
        /// <returns></returns>retorna el resultado de la resta de los atributos numero de cada Operando.
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Sobrecarga de operadores que devide los atributos de la clases Operando recibidos.
        /// </summary>
        /// <param name="n1"></param>Operando a sumar.
        /// <param name="n2"></param>Operando a sumar.
        /// <returns></returns>retorna el resultado de la divisiòn de los atributos numero de cada Operando, ò el valor mìnimo del double si el segundo operando es cero
        public static double operator /(Operando n1, Operando n2)
        {
            return  n2.numero != 0 ? n1.numero / n2.numero : double.MinValue;
        }

        /// <summary>
        /// Sobrecarga de operadores que multiplica los atributos de la clases Operando recibidos.
        /// </summary>
        /// <param name="n1"></param>Operando a multiplicarar.
        /// <param name="n2"></param>Operando a multiplicar.
        /// <returns></returns>retorna el resultado de la multiplicaciòn de los atributos numero de cada Operando.
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
    }
}
