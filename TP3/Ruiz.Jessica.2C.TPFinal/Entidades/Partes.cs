using System;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Actor))]
    [XmlInclude(typeof(Abogado))]
    [XmlInclude(typeof(Demandado))]
    public abstract class Partes
    {
        public enum Identificacion { DNI, CUIT }
        private string nombre;
        private string direccion;
        private Identificacion tipoIdentificacion;
        private long numeroIdentificacion;
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Partes()
        {

        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="nombre"></param> valor a asignar en el atributo nombre
        /// <param name="direccion"></param>valor a asignar en el atributo  direccion
        /// <param name="identificacion"></param>valor a asignar en el atributo tipoIdentificacio
        /// <param name="numeroIdentificacion"></param>valor a asignar en el atributo numeroIdentificacion
        public Partes(string nombre, string direccion, Identificacion identificacion, long numeroIdentificacion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.TipoIdentificacion = identificacion;
            this.NumeroIdentificacion = numeroIdentificacion;
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (value != string.Empty && value.Length < 50)
                {
                    this.nombre = value;
                }
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
                if (value != string.Empty && value.Length < 200)
                {
                    this.direccion = value;
                }
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo tipoIdentificacion
        /// </summary>
        public Identificacion TipoIdentificacion
        {
            get
            {
                return this.tipoIdentificacion;
            }
            set
            {
                this.tipoIdentificacion = value;
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo numeroIdentificacion
        /// </summary>
        public long NumeroIdentificacion
        {
            get
            {
                return this.numeroIdentificacion;
            }
            set
            {
                if (value > 0 && value < 1000000000000)
                {
                    this.numeroIdentificacion = value;
                }
            }
        }
        /// <summary>
        /// Genera un string con el estado del objeto
        /// </summary>
        /// <returns></returns> estado del objeto en un string
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"{this.TipoIdentificacion.ToString()}: {this.NumeroIdentificacion}");
            sb.AppendLine($"Dirección: {this.Direccion}");
            return sb.ToString();
        }
    }

}
