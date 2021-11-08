using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoTexto : IArchivos<string>
    {
        /// <summary>
        /// Escribe un archivo, si no existe lo crea, si existe lo pisa.
        /// </summary>
        /// <param name="dato"></param> dato a escribir en el archivo
        /// <param name="path"></param> ruta del archivo a escribir
        public void Escribir(string dato, string path)
        {
            try
            {
                using(StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.WriteLine(dato);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Lee un archivo.
        /// </summary>
        /// <param name="path"></param> ruta del archivo a leer
        /// <returns></returns>
        public string Leer(string path)
        {
            string aux = string.Empty;
            try
            {
                using(StreamReader streamReader = new StreamReader(path))
                {
                    while(!streamReader.EndOfStream)
                    { 
                       aux += $"{streamReader.ReadLine()}\n"; 
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
            return aux;
        }
        /// <summary>
        /// Genera y devuelve la ruta donde esta el proyecto juntos con el nombre del archivo deseado
        /// </summary>
        /// <param name="nombreArchivo"></param> nombre que quiere poner al archivo
        /// <returns></returns>
        public static string ObtenerRuta(string nombreArchivo)
        {
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            string rutaArchivo = Path.Combine(rutaBase, nombreArchivo);
            return rutaArchivo;
        }
    }
}
