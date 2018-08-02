using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            structCliente c = new structCliente();

            Console.Write("Inserte Una edad para la Clase: ");
            classCliente.Edad = int.Parse(Console.ReadLine());

            Console.Write("Inserte Una edad para la Estructura: ");
            c.Edad = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            classCliente.IncrementaEdad(classCliente.Edad);

            Console.WriteLine($"Resultado despues de ejecutar el metodo de la clase {classCliente.Edad}");
            Console.WriteLine();
            Console.WriteLine();
            
            c.IncrementaEdad(c.Edad);

            Console.WriteLine($"Resultado despues de ejecutar el metodo de la clase {c.Edad}");
            Console.ReadKey();


        }
    }

    static class classCliente
    {
        public static string Nombre { get; set; }
        public static int Edad { get; set; }

        public static  void IncrementaEdad(int n)
        {
            n++;
            Console.WriteLine($"Resultado dentro del metodo de la Clase {n} y {Edad}");
        }

    }

    struct structCliente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void IncrementaEdad(int n)
        {

            n++;
            Console.WriteLine($"Dentro del metodo de la Estructura {n} y {Edad}");
        }
    }
}
