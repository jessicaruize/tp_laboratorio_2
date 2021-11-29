using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Aca se trabajo con interfaz y un genérico
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IArchivos<T> where T : class
    {
        /// <summary>
        /// Representa al tipo de serialización
        /// </summary>
        public enum ETipoArchivo {XML, JSON};
        /// <summary>
        /// Lee un archivo
        /// </summary>
        /// <param name="path"></param> recibe la ruta del archivo
        /// <returns></returns> Tipo generico
        T Leer(string path);
        /// <summary>
        /// Escribe un archivo
        /// </summary>
        /// <param name="dato"></param> dato generico que se va a escribir en el archivo
        /// <param name="path"></param> recibe la ruta del archivo donde se quiere escribir
        void Escribir(T dato, string path);
    }
}
