using nonAccessModifiers.models;
using System;

namespace nonAccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Square");
            Console.WriteLine("2.Rectanglular");
            Console.WriteLine("0.Quit");
            int Choise;

            Choise = Convert.ToInt32(Console.ReadLine());
            if (Choise == 1)
            {
                Console.Write("input side:");
                float Side = Convert.ToSingle(Console.ReadLine());
                Square s = new Square(Side);
                Console.WriteLine($"Area:{s.CalcArea()}");
            }
            else if (Choise==2)
            {
                Console.Write("input Width:");
                float Width = Convert.ToSingle(Console.ReadLine());
                Console.Write("input Length:");
                float Length = Convert.ToSingle(Console.ReadLine());
                Rectangular r = new Rectangular(Width, Length);
                Console.WriteLine($"Area:{r.CalcArea()}");
            }
            else if (Choise==0)
            {
                Console.WriteLine("Quit");
            }
        }
    }
}
