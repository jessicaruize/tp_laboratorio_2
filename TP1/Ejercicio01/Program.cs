using System;

namespace Ejercicio01
{
    class Program
    {
        /*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el  valor máximo, el valor mínimo y el promedio. */
        static void Main(string[] args)
        {
            int numero;
            int valorMaximo = int.MinValue;
            int valorMinimo = int.MaxValue;
            int acumulador = 0;
            float promedio;

            int cantidad = 5;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese un nùmero: ");
                numero = int.Parse(Console.ReadLine());
                if(numero > valorMaximo)
                {
                    valorMaximo = numero;
                }
                if(numero < valorMinimo)
                {
                    valorMinimo = numero;
                }
                acumulador += numero;
            }
            promedio = (float)acumulador / cantidad;
            Console.WriteLine($"Valor maximo: {valorMaximo} \nValor minimo: {valorMinimo} \nPromedio: {promedio}");
        }
            

            
    }
}
