using System;

namespace pz8
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public class DiscountCard : IDiscount
        {
            int card;
            int size;
            public DiscountCard(int id, int size)
            {
                card = id;
                this.size = size;
            }
        }
        public interface IDiscount
        {
            public static int _id;
            public static int _size;
            public int DiscountSize
            {
                get => _size;
                set => _size = value;
            }
            public int DiscountCard
            {
                get => _id;
                set => _id = value;
            }
        }
    }
}
