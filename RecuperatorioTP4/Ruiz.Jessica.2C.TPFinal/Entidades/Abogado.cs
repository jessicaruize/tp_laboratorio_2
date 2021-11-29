using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Abogado : Partes
    {
        private int folio;
        private int tomo;
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Abogado() : base()
        {

        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="folio"></param> valor a asignar en el atributo folio
        /// <param name="tomo"></param>valor a asignar en el atributo tomo
        /// <param name="nombre"></param>valor a asignar en el atributo nombre
        /// <param name="direccion"></param> valor a asignar en el atributo direccion
        /// <param name="numeroIdentificacion"></param>
        public Abogado(int folio, int tomo, string nombre, string direccion, long numeroIdentificacion) : base(nombre, direccion, Partes.Identificacion.CUIT, numeroIdentificacion)
        {
            this.Folio = folio;
            this.Tomo = tomo;
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo folio
        /// </summary>
        public int Folio
        {
            get
            {
                return this.folio;
            }
            set
            {
                if (value > 0 && value < 1000)
                {
                    this.folio = value;
                }
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo tomo
        /// </summary>
        public int Tomo 
        {
            get
            {
                return this.tomo;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    this.tomo = value;
                }
            }
        }
        /// <summary>
        /// Genera un string con el estado del objeto
        /// </summary>
        /// <returns></returns> estado del objeto en un string
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.MostrarDatos()}");
            sb.AppendLine($"Matricula: Tomo {this.Tomo} Folio {this.Folio}");
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del operador == comparando objetos abogados
        /// </summary>
        /// <param name="a1"></param> abogado a comparar
        /// <param name="a2"></param> abogado a comparar
        /// <returns></returns>
        public static bool operator ==(Abogado a1, Abogado a2)
        {
            if(a1.folio == a2.folio || a1.tomo == a2.tomo)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador != comparando objetos abogados
        /// </summary>
        /// <param name="a1"></param> abogado a comparar
        /// <param name="a2"></param> abogado a comparar
        /// <returns></returns>
        public static bool operator !=(Abogado a1, Abogado a2)
        {
            return !(a1 == a2);
        }
    }
    
}
