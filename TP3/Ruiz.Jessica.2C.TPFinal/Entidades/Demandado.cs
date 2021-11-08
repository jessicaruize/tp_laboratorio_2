using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Demandado : Partes
    {
        private string actividadEmpresa;
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Demandado() : base()
        {

        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="actividadEmpresa"></param> valor a asignar en el atributo actividadEmpresarial
        /// <param name="nombre"></param> valor a asignar en el atributo nombre
        /// <param name="direccion"></param> valor a asignar en el atributo direccion
        /// <param name="numeroIdentificacion"></param> valor a asignar en el atributo numeroIdentificacion
        public Demandado(string actividadEmpresa, string nombre, string direccion, long numeroIdentificacion) : base(nombre, direccion, Partes.Identificacion.CUIT, numeroIdentificacion)
        {
            this.ActividadEmpresa = actividadEmpresa;
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo actividadEmpresa
        /// </summary>
        public string ActividadEmpresa
        {
            get
            {
                return this.actividadEmpresa;
            }
            set
            {
                if (value != string.Empty && value.Length < 40)
                {
                    this.actividadEmpresa = value;
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
            sb.AppendLine($"Actividad empresarial: {this.ActividadEmpresa}");
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del operador == que compara objetos de Demandados
        /// </summary>
        /// <param name="d1"></param> demandado a comparar
        /// <param name="d2"></param> demandado a comparar
        /// <returns></returns>
        public static bool operator ==(Demandado d1, Demandado d2)
        {
            if(d1.NumeroIdentificacion == d2.NumeroIdentificacion)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador == que compara objetos de Demandados
        /// </summary>
        /// <param name="d1"></param> demandado a comparar
        /// <param name="d2"></param> demandado a comparar
        /// <returns></returns>
        public static bool operator !=(Demandado d1, Demandado d2)
        {
            return !(d1 == d2);
        }
    }
}
