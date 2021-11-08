using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializador<T> : IArchivos<T> where T : class
    {
        private IArchivos<T>.ETipoArchivo tipo;

        public Serializador(IArchivos<T>.ETipoArchivo tipo)
        {
            this.tipo = tipo;
        }

        public void Escribir(T dato, string path)
        {
            try
            {
                if(this.tipo == IArchivos<T>.ETipoArchivo.XML)
                {
                    if(Path.GetExtension(path) == ".xml")
                    {
                        using(XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8))
                        {
                            xmlTextWriter.Formatting = Formatting.Indented;
                            XmlSerializer xmlSerializar = new XmlSerializer(typeof(T));
                            xmlSerializar.Serialize(xmlTextWriter, dato);
                        }
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extension invàlida para xml");
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".json")
                    {
                        ArchivoTexto archivoTexto = new ArchivoTexto();
                        JsonSerializerOptions opciones = new JsonSerializerOptions();
                        opciones.WriteIndented = true;
                        archivoTexto.Escribir(JsonSerializer.Serialize(dato, typeof(T), opciones), path);
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extension invàlida para json");
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public T Leer(string path)
        {
            try
            {
                if(this.tipo == IArchivos<T>.ETipoArchivo.XML)
                {
                    if(Path.GetExtension(path) == ".xml")
                    {
                        using(XmlTextReader xmliTextReader = new XmlTextReader(path))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            T objeto = xmlSerializer.Deserialize(xmliTextReader) as T;
                            return objeto;
                        }
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extensiòn invalida para XML.");
                    }
                }
                else
                {
                    if(Path.GetExtension(path) == ".json")
                    {
                        ArchivoTexto archivoTexto = new ArchivoTexto();
                        T objeto = JsonSerializer.Deserialize<T>(archivoTexto.Leer(path));
                        return objeto;
                    }
                    else
                    {
                        throw new ExtensionInvalidaException("Extensiòn invalida para JSON");
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
