using System;

namespace pz7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Number n = (Number)(a > 0 ? 1 : (a<0 ? -1 : 0 ));
            Console.WriteLine("Число {0} {1}", a, n);
            Console.ReadKey();
        }
        public enum Number
        {
            отрицательное = -1,
            нулевое = 0,
            положительное
        }
    }
}
