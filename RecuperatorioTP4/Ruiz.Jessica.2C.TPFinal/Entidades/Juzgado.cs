using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juzgado
    {
        private int numeroIdentificacion;
        private string juez;
        private string secretario;
        private string direccion;
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Juzgado()
        {

        }
        /// <summary>
        /// Constructor con parametros que asigna los valores correspondientes a sus atributos
        /// </summary>
        /// <param name="numeroIdentificaciòn"></param> valor a cargar en el atributo numeroIdentificacion
        /// <param name="juez"></param> valor a cargar en el atributo juez
        /// <param name="secretario"></param> valor a cargar en el atributo secretario
        /// <param name="direccion"></param> direccón
        public Juzgado(int numeroIdentificacion, string juez, string secretario, string direccion)
        {
            this.NumeroIdentificacion = numeroIdentificacion;
            this.Juez = juez;
            this.Secretario = secretario;
            this.Direccion = direccion;
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo numeroIdentificacion
        /// </summary>
        public int NumeroIdentificacion 
        {
            get
            { 
                return this.numeroIdentificacion;
            }
            set
            {
                this.numeroIdentificacion = value;
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo juez
        /// </summary>
        public string Juez 
        { 
            get
            { 
                return this.juez; 
            }
            set
            {
                this.juez = value;
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo secretario
        /// </summary>
        public string Secretario 
        { 
            get
            { 
                return this.secretario; 
            }
            set
            {
                this.secretario = value; 
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo direccion
        /// </summary>
        public string Direccion 
        { 
            get
            { 
                return this.direccion; 
            }
            set
            {
                this.direccion = value;
            }
        }
        /// <summary>
        /// Genera un string con el estado del objeto
        /// </summary>
        /// <returns></returns> estado del objeto en un string
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Juzgado número {this.NumeroIdentificacion}");
            sb.AppendLine($"Juez: {this.Juez}");
            sb.AppendLine($"Secretàrio: {this.Secretario}");
            sb.AppendLine($"Direcciòn: {this.Direccion}");
            return sb.ToString();
        }
    }
}
