using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Causa> causas;
            List<Juzgado> juzgados;
            Serializador<List<Causa>> serializadorCausas;
            Serializador<List<Juzgado>> serializadorJuzgados;
            causas = new List<Causa>();
            juzgados = new List<Juzgado>();
            serializadorCausas = new Serializador<List<Causa>>(IArchivos<List<Causa>>.ETipoArchivo.XML);
            serializadorJuzgados = new Serializador<List<Juzgado>>(IArchivos<List<Juzgado>>.ETipoArchivo.JSON);
            try
            {
                causas = serializadorCausas.Leer(ArchivoTexto.ObtenerRuta("Causas.xml"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error, {ex.Message}");
            }
            try
            {
                juzgados = serializadorJuzgados.Leer(ArchivoTexto.ObtenerRuta("Juzgados.json"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error, {ex.Message}");
            }
            foreach(Causa c in causas)
            {
                Console.WriteLine(c.MostrarDatos());
            }
            foreach(Juzgado j in juzgados)
            {
                Console.WriteLine(j.MostrarDatos());
            }
            Causa causa = new Causa(new Demandado("Comercio", "Raul Tobares", "Color 121", 20239434332), new Abogado(12, 21, "Lucas Martinez", "Tel Aviv 221", 20342212334), new Actor(new DateTime(1960, 10, 10), Actor.Genero.Femenino, "LuciaBRitos", "Peñarol 232", 23464534), juzgados[2], DateTime.Now, Causa.Objeto.Amparo, 12342300, causas.Last().NumeroIdentificacion + 1);
            causas.Add(causa);
            try
            {
                serializadorCausas.Escribir(causas, "Causas.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error, {ex.Message}");
            }
        }
        
    }
}
