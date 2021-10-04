using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Constructor que permite cargar los atributos del objeto.
        /// </summary>
        /// <param name="marca"></param> marca a cargar en el objeto.
        /// <param name="chasis"></param> chasis a cargar en el objeto.
        /// <param name="color"></param>  color a cargar en el objeto.
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }

        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        /// <summary>
        /// Devuelve la informaciòn del objeto en un string.
        /// </summary>
        /// <returns></returns> String con la informaciòn del objeto.
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
