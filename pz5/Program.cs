using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
        public class ABC
        {
            //вывод символов
            public void letters(string lets)
            {
                char[] letters = lets.ToCharArray();
                foreach (var x in letters)
                {
                    Console.WriteLine(x + " ");
                }
            }
        }
        public partial class ABC
        {
            //вызов методы для вывода русских букв
            public void rusABC()
            {
                letters("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            }
        }
        public partial class ABC
        {
            public void engABC()
            {
                //вызов методов для английских букв
                letters("abcdefghijklmnopqrstuvwxy");
            }
        }
        public class Calc
        {
            decimal result;
            public void Sum(decimal[] arr)
            {
                foreach (var x in arr)
                {
                    result += x;
                    Console.WriteLine("Сумма массива: {0}", result);
                }
            }
        }
        public partial class Calc
        {
            public void Mult(decimal[] arr)
            {
                decimal y = 1;
                foreach (var x in arr)
                {
                    y *= x;
                    Console.WriteLine("Сумма массива: {0}", y);
                }
                result = y;
            }
        }


    }
}
