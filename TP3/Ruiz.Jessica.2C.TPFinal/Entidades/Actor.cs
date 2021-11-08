using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Actor : Partes
    {
        public enum Genero { Femenino, Masculino };
        private DateTime fechaNacimiento;
        private Genero generoActor;
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Actor() : base()
        {

        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo fechaNacimiento
        /// </summary>
        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                if (value.CompareTo(DateTime.Now.AddYears(-18)) < 0)
                {
                    this.fechaNacimiento = value;
                }
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo generoActor
        /// </summary>
        public Genero GeneroActor
        {
            get
            {
                return this.generoActor;
            }
            set
            {
                this.generoActor = value;
            }
        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="fechaNacimiento"></param> valor a asignar en el atributo fechaNacimiento
        /// <param name="genero"></param>valor a asignar en el atributo genero
        /// <param name="nombre"></param>valor a asignar en el atributo nombre
        /// <param name="direccion"></param>valor a asignar en el atributo direccion
        /// <param name="numeroIdentificacion"></param> valor a asignar en el atributo numeroIdentificacion
        public Actor(DateTime fechaNacimiento, Genero genero, string nombre, string direccion, long numeroIdentificacion) : base(nombre, direccion, Partes.Identificacion.DNI, numeroIdentificacion)
        {
            this.FechaNacimiento = fechaNacimiento;
            this.generoActor = genero;
        }
        /// <summary>
        /// Genera un string con el estado del objeto
        /// </summary>
        /// <returns></returns> estado del objeto en un string
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.MostrarDatos()}");
            sb.AppendLine($"Fecha de Nacimiento: {this.FechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Genero: {this.GeneroActor}");
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del operador == que compara objetos de actores
        /// </summary>
        /// <param name="a1"></param> actor a comparar
        /// <param name="a2"></param> actor a comparar
        /// <returns></returns>
        public static bool operator ==(Actor a1, Actor a2)
        {
            if(a1.NumeroIdentificacion == a2.NumeroIdentificacion)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador != que compara objetos de actores
        /// </summary>
        /// <param name="a1"></param> actor a comparar
        /// <param name="a2"></param> actor a comparar
        /// <returns></returns>
        public static bool operator !=(Actor a1, Actor a2)
        {
            return !(a1 == a2);
        }
    }
}
