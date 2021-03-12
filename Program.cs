using System;

namespace pz10
{
    class Program
    {
        //объявление делегата
        delegate double Operation(double a, double b);
        static void Main()
        {
            Console.WriteLine("1 - сложение, 2 - умножение, 3 - деление, 4 - разность.");
            Console.Write("Выберите операцию: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число а: ");
            aMas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b: ");
            bMas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат операции: {0}", ChooseOperation(x));
            Console.WriteLine("Посчитать ещё что-нибудь? 0 или 1.");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Main();
            }
            Console.ReadKey();
        }
        //переменные класса Program, чтобы не отправлять их поровозом по всем методам через ChooseOperation и далее к нужному методу
        static double aMas { get; set; }
        static double bMas { get; set; }
        static Operation op { get; set; }
        //выбор операции и возвращени результата
        private static double ChooseOperation(int x)
        {
            switch (x)
            {
                case 1:
                    op = Add;
                    break;
                case 2:
                    op = Multiply;
                    break;
                case 3:
                    op = Division;
                    break;
                case 4:
                    op = Difference;
                    break;
            }
            return ReturnResult(op, aMas, bMas);
        }
        //вовзвращение результата
        private static double ReturnResult(Operation op, double a, double b)
        {
            return op(a, b);
        }
        //методы сложения, умножения и проч
        private static double Add(double a, double b)
        {
            return a + b;
        }
        private static double Multiply(double a, double b)
        {
            return a * b;
        }
        private static double Division(double a, double b)
        {
            return a / b;
        }
        private static double Difference(double a, double b)
        {
            return a - b;
        }
    }
}
