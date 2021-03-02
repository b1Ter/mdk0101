using System;

namespace pz6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Английский алфавит - 0, русский - 1: ");
            byte p = Convert.ToByte(Console.ReadLine());
            GetAbc abc = new GetAbc(p);
            Console.ReadKey();
            
        }
    }
    public class GetAbc
    {
        public GetAbc(byte p)
        {
            abc k = (abc)p;
            char[] l = k.ToString().ToCharArray();
            foreach (var x in l)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.Write("Выберите номер последовательности букв на данном языке: ");
            int e = Convert.ToInt32(Console.ReadLine());
            int r = (int)k;
            switch ((abc)r)
            {
                case abc.abcdefghijklmnopqrstuvwxyz:
                    lalala y = (lalala)e;
                    Console.WriteLine(y);
                    break;
                case abc.абвгдеёжзийклмнопрстуфхцчшщъыьэюя:
                    zazaza z = (zazaza)e;
                    Console.WriteLine(z);
                    break;
                default:
                    break;
            }
        }
    }

    public enum abc : byte
    {
        abcdefghijklmnopqrstuvwxyz,
        абвгдеёжзийклмнопрстуфхцчшщъыьэюя
    }
    public enum lalala
    {
        lalalalala = 1,
        tralalalala = 2,
        zuzuzuzu = 3
    }
    public enum zazaza : int
    {
        лалалалала = 1,
        тралалала = 2,
        зазазаза = 3
    }
}
