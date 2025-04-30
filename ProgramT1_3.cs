using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Ingrese el sueldo del empleado: ");
                double suel = Convert.ToDouble(Console.ReadLine());
                double imp = 0;
                double suelNet = suel;
                if (suel <= 1500)
                {
                    imp = suel * 0.10;
                    suelNet = suel - imp;
                }
                else
                {
                    if (suel <= 3000)
                    {
                        imp = (suel - 1500) * 0.05;
                        suelNet = suel - imp;
                    }
                    else
                    {
                        imp = (suel - 3000) * 0.03; 
                        suelNet = suel - imp;
                    }
                }
                Console.WriteLine("El impuesto a descontar es: " + imp);
                Console.WriteLine("El salario neto es: " + suelNet);
        }
    }
}
