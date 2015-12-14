using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Variant4_task2
{
    class Program
    {
        //2 Написати програму, яка введе значення змінної n, і порахує значення виразу:
        // 1/2 * 3/4 * ... * (2*n - 1)/2*n
        static void Main(string[] args)
        {
            float n;
            float product = 1;
            Console.Write("Введите значение переменной n: ");
            n = float.Parse(Console.ReadLine());

            for (float i = 1; i <= n; i++)
            {
                product *= (2*i - 1)/(2*i);
            }

            Console.WriteLine("The product is " + product);
            Console.ReadKey();
        }
    }
}
