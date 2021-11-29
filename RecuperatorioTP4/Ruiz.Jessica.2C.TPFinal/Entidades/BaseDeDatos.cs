using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// En esta clase se aplica Base de Datos y excepsiones
    /// </summary>
    public class BaseDeDatos
    {
        private static string cadenaConexion;
        private static SqlCommand command;
        private static SqlConnection connection;
        /// <summary>
        /// Constructor sin parametros statico que genera la conexion para trabajar con la base de datos
        /// </summary>
        static BaseDeDatos()
        {
            BaseDeDatos.cadenaConexion = @"Server=DESKTOP-TGPB9LS;DataBase=Causas;Trusted_Connection=true";
            command = new SqlCommand();
            connection = new SqlConnection(cadenaConexion);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }
        /// <summary>
        /// Metodo que permite almacenar en la base de datos un actor
        /// </summary>
        /// <param name="actor"></param>
        public void Guardar(Actor actor)
        {
            string identificacion = "CUIT";
            string genero = "Masculino";
            if(actor.TipoIdentificacion == Partes.Identificacion.DNI)
            {
                identificacion = "DNI";
            }
            if(actor.GeneroActor == Actor.Genero.Femenino)
            {
                genero = "Femenino";
            }
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO Actores (numeroIdentificacion, tipoIdentificacion, nombre, direccion, fechaNacimiento, genero) VALUES (@numeroIdentificacion, @tipoIdentificacion, @nombre, @direccion, @fechaNacimiento, @genero)";
                command.Parameters.AddWithValue("@numeroIdentificacion", actor.NumeroIdentificacion);
                command.Parameters.AddWithValue("@tipoIdentificacion", identificacion);
                command.Parameters.AddWithValue("@nombre", actor.Nombre);
                command.Parameters.AddWithValue("@direccion", actor.Direccion);
                command.Parameters.AddWithValue("@fechaNacimiento", actor.FechaNacimiento);
                command.Parameters.AddWithValue("@genero", genero);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(connection is not null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        /// <summary>
        /// Metodo que permite almacenar en la base de datos un demandado
        /// </summary>
        /// <param name="demandado"></param>
        public void Guardar(Demandado demandado)
        {
            string identificacion = "CUIT";
            if (demandado.TipoIdentificacion == Partes.Identificacion.DNI)
            {
                identificacion = "DNI";
            }
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO Demandados (numeroIdentificacion, tipoIdentificacion, nombre, direccion, actividadEmpresa) VALUES (@numeroIdentificacion, @tipoIdentificacion, @nombre, @direccion, @actividadEmpresa)";
                command.Parameters.AddWithValue("@numeroIdentificacion", demandado.NumeroIdentificacion);
                command.Parameters.AddWithValue("@tipoIdentificacion", identificacion);
                command.Parameters.AddWithValue("@nombre", demandado.Nombre);
                command.Parameters.AddWithValue("@direccion", demandado.Direccion);
                command.Parameters.AddWithValue("@actividadEmpresa", demandado.ActividadEmpresa);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        /// <summary>
        /// Metodo que permite almacenar en la base de datos un abogado
        /// </summary>
        /// <param name="abogado"></param>
        public void Guardar(Abogado abogado)
        {
            string identificacion = "CUIT";
            if (abogado.TipoIdentificacion == Partes.Identificacion.DNI)
            {
                identificacion = "DNI";
            }
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO Abogados (numeroIdentificacion, tipoIdentificacion, nombre, direccion, folio, tomo) VALUES (@numeroIdentificacion, @tipoIdentificacion, @nombre, @direccion, @folio, @tomo)";
                command.Parameters.AddWithValue("@numeroIdentificacion", abogado.NumeroIdentificacion);
                command.Parameters.AddWithValue("@tipoIdentificacion", identificacion);
                command.Parameters.AddWithValue("@nombre", abogado.Nombre);
                command.Parameters.AddWithValue("@direccion", abogado.Direccion);
                command.Parameters.AddWithValue("@folio", abogado.Folio);
                command.Parameters.AddWithValue("@tomo", abogado.Tomo);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        /// <summary>
        /// Metodo que permite almacenar en la base de datos una causa
        /// </summary>
        /// <param name="causa"></param>
        public void Guardar(Causa causa)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "INSERT INTO Causas (numeroIdentificacion, montoReclamo, fechaAsignacion, idActor, idAbogado, idDemandado, idJuzgado, idObjeto) VALUES (@numeroIdentificacion, @montoReclamo, @fechaAsignacion, @idActor, @idAbogado, @idDemandado, @idJuzgado, @idObjeto)";
                command.Parameters.AddWithValue("@numeroIdentificacion", causa.NumeroIdentificacion);
                command.Parameters.AddWithValue("@montoReclamo", causa.MontoReclamo);
                command.Parameters.AddWithValue("@fechaAsignacion", causa.FechaAsignacion);
                command.Parameters.AddWithValue("@idActor", causa.Actor.NumeroIdentificacion);
                command.Parameters.AddWithValue("@idAbogado", causa.AbogadoActor.NumeroIdentificacion);
                command.Parameters.AddWithValue("@idDemandado", causa.Demandado.NumeroIdentificacion);
                command.Parameters.AddWithValue("@idJuzgado", causa.Juzgado.NumeroIdentificacion);
                command.Parameters.AddWithValue("@idObjeto", (int)causa.ObjetoCausa);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
        /// <summary>
        /// Metodo que permite almacenar en la base de datos un juzgado
        /// </summary>
        /// <param name="juzgado"></param>
        public void Guardar(Juzgado juzgado)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText =
                command.CommandText = "INSERT INTO Juzgados1 (direccion, juez, secretario) VALUES (@direccion, @juez, @secretario)";
                command.Parameters.AddWithValue("@direccion", juzgado.Direccion);
                command.Parameters.AddWithValue("@juez", juzgado.Juez);
                command.Parameters.AddWithValue("@secretario", juzgado.Secretario);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
