using System;
using System.Runtime.Serialization;

namespace Entidades
{
    ///[Serializable]
    public class ExtensionInvalidaException : Exception
    {
        /// <summary>
        /// Constructor que recibe mensaje
        /// </summary>
        /// <param name="message"></param> mensaje a recibir
        public ExtensionInvalidaException(string message) : base(message)
        {
        }
        /// <summary>
        /// Constructor que recibe mensaje y la innerException
        /// </summary>
        /// <param name="message"></param> mensaje a recibir
        /// <param name="innerException"></param> innerException a recibir
        public ExtensionInvalidaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}