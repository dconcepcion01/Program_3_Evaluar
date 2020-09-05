using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3_Evaluar
{
    class Program
    {
        private static object MessageBox;

        static void Main(string[] args)
        {

            //Este Programa evaluar cual es mayor y cual es menor

            Console.WriteLine("Evaluar cual es mayor");


            double num1,num2;

            Console.WriteLine("Digite un primer numero");
            num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite un segundo numero");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El primer numero es mayor:      " + num1);
            }else if ( num1 < num2)
            {

               Console.WriteLine("El segundo numero es mayor :      " + num2);
                

            }
            Console.ReadKey();




        }
    }
}
