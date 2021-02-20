using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz4
{
    class Program
    {
        static void Main(string[] args)
        {
            Num c = new Num(5);
            Abc a = new Abc();
            Console.ReadKey();
        }
        //статистический конструктор
         class Num
        {
            int num = 0;
            //статистический конструктор
            static Num()
            {
                Console.Write("Номер: ");
            }
            //конструктор с параметром
            public Num(int a)
            {
                this.num = a;
                Console.WriteLine(a);
            }
        }
         class Abc
         {
             public Abc()
             {
                 char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                 foreach (var x in letters)
                 {
                     Console.Write(x + " ");
                 }
             }
         }
    }
}
