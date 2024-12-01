using System;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе числ: ");int num2 = int.Parse(Console.ReadLine());
            int count = 0;
            while (num1 >= num2)
            {
                num1 -= num2;
                count++; 
            }
            Console.WriteLine(count);

        }
    }
}