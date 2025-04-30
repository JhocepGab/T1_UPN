using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int billet100 = 0, billet50 = 0, billet20 = 0, billet10 = 0;
            int mone5 = 0, mone2 = 0, mone1 = 0, mone0_5 = 0;
            int mone0_2 = 0, mone0_1 = 0;
            Console.Write("Ingrese el monto total a pagar: ");
            double mont = Convert.ToDouble(Console.ReadLine());
            if (mont >= 100)
            {
                billet100 = (int)(mont / 100);
                mont %= 100;
            }
            if (mont >= 50)
            {
                billet50 = (int)(mont / 50);
                mont %= 50;
            }
            if (mont >= 20)
            {
                billet20 = (int)(mont / 20);
                mont %= 20;
            }
            if (mont >= 10)
            {
                billet10 = (int)(mont / 10);
                mont %= 10;
            }
            if (mont >= 5)
            {
                mone5 = (int)(mont / 5);
                mont %= 5;
            }
            if (mont >= 2)
            {
                mone2 = (int)(mont / 2);
                mont %= 2;
            }
            if (mont >= 1)
            {
                mone1 = (int)(mont / 1);
                mont %= 1;
            }
            if (mont >= 0.5)
            {
                mone0_5 = (int)(mont / 0.5);
                mont %= 0.5;
            }
            if (mont >= 0.2)
            {
                mone0_2 = (int)(mont / 0.2);
                mont %= 0.2;
            }
            if (mont >= 0.1)
            {
                mone0_1 = (int)(mont / 0.1);
                mont %= 0.1;
            }
            Console.WriteLine("Billetes de 100 soles: " + billet100);
            Console.WriteLine("Billetes de 50 soles: " + billet50);
            Console.WriteLine("Billetes de 20 soles: " + billet20);
            Console.WriteLine("Billetes de 10 soles: " + billet10);
            Console.WriteLine("Monedas de 5 soles: " + mone5);
            Console.WriteLine("Monedas de 2 soles: " + mone2);
            Console.WriteLine("Monedas de 1 sol: " + mone1);
            Console.WriteLine("Monedas de 0.5 soles: " + mone0_5);
            Console.WriteLine("Monedas de 0.2 soles: " + mone0_2);
            Console.WriteLine("Monedas de 0.1 soles: " + mone0_1);
        }
    }
}
