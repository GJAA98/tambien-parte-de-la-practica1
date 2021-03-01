using System;

namespace Practica_tabla_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Inserte un numero:");
                string valor =  Console.ReadLine();
                int numero = int.Parse(valor);
                if(numero == -1)
                {
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Tabla de multiplicar de " + numero);
                    for (int i = 1; i <=12; i++)
                    {
                        int resultado = numero * i;
                        Console.WriteLine(numero + "x" + i + "=" + resultado);
                    }
                }
            }
        }
    }
}
