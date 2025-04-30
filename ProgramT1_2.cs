using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese un número entero positivo: ");
            num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("El número debe ser positivo.");
            }
            else
            {
                int suma = 0;
                while (num > 0)
                {
                    suma += num % 10;
                    num /= 10;
                }
                Console.WriteLine("La suma de los dígitos es: " + suma);
            }
        }
    }
}
