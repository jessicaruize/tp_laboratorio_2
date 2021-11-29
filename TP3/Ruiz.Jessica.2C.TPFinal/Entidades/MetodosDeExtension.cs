using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosDeExtension
    {
        /// <summary>
        /// Permite calcular un promedio de un entero pasandole la cantidad total.
        /// </summary>
        /// <param name="cantidad"></param> cantidad que se quiere calcular.
        /// <param name="cantidadTotal"></param> cantidad total para calcular promedio.
        /// <returns></returns> devuelve el promedio calculado
        public static double Promedio(this int cantidad, int cantidadTotal)
        {
            return ((double)cantidad * 100) / cantidadTotal;
        }
    }
}
