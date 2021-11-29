using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Causa
    {
        public enum Objeto { Accidente, Amparo, Despido, DirefenciaSalario, EjecucionDeCredito }
        private int numeroIdentificacion;
        private Demandado demandado;
        private Abogado abogadoActor;
        private Actor actor;
        private Juzgado juzgado;
        private DateTime fechaAsignacion;
        private Objeto objetoCausa;
        private float montoReclamo;
        /// <summary>
        /// Constructor sin parametro
        /// </summary>
        public Causa()
        {

        }
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="demandado"></param> valor a asignar en el atributo demandado
        /// <param name="abogadoActor"></param> valor a asignar en el atributo  abogadoActor
        /// <param name="actor"></param> valor a asignar en el atributo actor
        /// <param name="juzgado"></param> valor a asignar en el atributo juzgado
        /// <param name="fechaAsignacion"></param> valor a asignar en el atributo fechaAsignacion
        /// <param name="objeto"></param> valor a asignar en el atributo objetoCausa
        /// <param name="montoReclamo"></param> valor a asignar en el atributo montoReclamo
        /// <param name="numeroIdentificacion"></param> valor a asignar en el atributo numeroIdentificacion
        public Causa(Demandado demandado, Abogado abogadoActor, Actor actor, Juzgado juzgado, DateTime fechaAsignacion, Objeto objeto, float montoReclamo, int numeroIdentificacion)
        {
            this.demandado = demandado;
            this.abogadoActor = abogadoActor;
            this.actor = actor;
            this.juzgado = juzgado;
            this.fechaAsignacion = fechaAsignacion;
            this.objetoCausa = objeto;
            this.montoReclamo = montoReclamo;
            this.numeroIdentificacion = numeroIdentificacion;
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
        /// Prppiedad lectura y escritura para el atributo demandado
        /// </summary>
        public Demandado Demandado 
        {
            get
            {
                return this.demandado;
            }
            set 
            {
                this.demandado = value;
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo abogadoActor
        /// </summary>
        public Abogado AbogadoActor 
        {
            get
            {
                return this.abogadoActor;
            }
            set
            {
                this.abogadoActor = value;
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo actor
        /// </summary>
        public Actor Actor 
        {
            get
            {
                return this.actor;
            }
            set 
            {
                this.actor = value;
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo juzgado
        /// </summary>
        public Juzgado Juzgado 
        {
            get
            {
                return this.juzgado;
            }
            set 
            {
                this.juzgado = value;
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo fechaAsignacion
        /// </summary>
        public DateTime FechaAsignacion 
        {
            get
            {
                return this.fechaAsignacion;
            }
            set 
            {
                this.fechaAsignacion = value;
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo objetoCausa
        /// </summary>
        public Objeto ObjetoCausa 
        {
            get
            {
                return this.objetoCausa;
            }
            set
            {
                this.objetoCausa = value;
            }
        }
        /// <summary>
        /// Prppiedad lectura y escritura para el atributo montoReclamo
        /// </summary>
        public float MontoReclamo 
        {
            get
            {
                return this.montoReclamo;
            }
            set
            {
                this.montoReclamo = value;
            }
        }
        /// <summary>
        /// Genera un string con el estado del objeto
        /// </summary>
        /// <returns></returns> estado del objeto en un string
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\n\t\tCAUSA NÙMERO: {this.NumeroIdentificacion}/{this.FechaAsignacion.Year}\n");
            sb.AppendLine($"Fecha de asignaciòn: {this.FechaAsignacion.ToString("dd/MM/yyyy")}");
            sb.AppendLine("\n\tDATOS DEL ACTOR");
            sb.AppendLine($"\n{this.Actor.MostrarDatos()}");
            sb.AppendLine("\n\tDATOS DEL ABOGADO DEL ACTOR");
            sb.AppendLine($"\n{this.AbogadoActor.MostrarDatos()}");
            sb.AppendLine("\n\tDATOS DEL DEMANDADO");
            sb.AppendLine($"\n{this.Demandado.MostrarDatos()}");
            sb.AppendLine("\n\tDETALLES");
            sb.AppendLine($"\nObjeto: {this.ObjetoCausa}");
            sb.AppendLine($"Monto de reclamo: {this.MontoReclamo}");
            sb.AppendLine("\n\tJUZGADO ASIGNADO");
            sb.AppendLine($"\nJuzgado: {this.Juzgado.MostrarDatos()}");
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del operador == que compara objetos de causas
        /// </summary>
        /// <param name="c1"></param> Causas a comparar
        /// <param name="c2"></param>Causas a comparar
        /// <returns></returns>
        public static bool operator ==(Causa c1, Causa c2)
        {
            if(c1.Actor == c2.Actor && c1.Demandado == c2.Demandado && c2.ObjetoCausa == c1.ObjetoCausa)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador != que compara objetos de causas
        /// </summary>
        /// <param name="c1"></param> Causas a comparar
        /// <param name="c2"></param>Causas a comparar
        /// <returns></returns>
        public static bool operator !=(Causa c1, Causa c2)
        {
            return !(c1 == c2);
        }
    }
}
