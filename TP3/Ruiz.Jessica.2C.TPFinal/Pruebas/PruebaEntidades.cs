using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Pruebas
{
    [TestClass]
    public class PruebaEntidades
    {
        [TestMethod]
        [ExpectedException(typeof(ExtensionInvalidaException))]
        public void Serializador_Serializar_LanzaExtensionInvalidaException()
        {
            //Arrenge
            Serializador<Abogado> serializador = new Serializador<Abogado>(IArchivos<Abogado>.ETipoArchivo.XML);
            //Acte
            serializador.Escribir(new Abogado(), ArchivoTexto.ObtenerRuta("Prueba.josn"));
        }

        [TestMethod]
        public void ArchivoTexto_ObtenerRuta_LaRutaExista()
        {
            ArchivoTexto archivo = new ArchivoTexto();
            string ruta = ArchivoTexto.ObtenerRuta("Prueba.txt");
            archivo.Escribir("hola", ruta);
            string texto =archivo.Leer(ruta);
            Assert.IsTrue(texto == "hola\n");

        }
    }
}
