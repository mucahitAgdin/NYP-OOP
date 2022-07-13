using System;

namespace static_
{
    class a
    {
        public int x = 15;

        public static int y = 20;
    }
    class Program
    {
        public const double E = 2.7;
        public readonly double F = 1.1;
        public readonly static double G = 1.8;
        static void Main(string[] args)
        {
            Program nesne1 = new Program();
            a nesne0 = new a();
            Console.WriteLine("x: " + nesne0.x);
            Console.WriteLine("\ny: " + a.y);
            Console.WriteLine(Program.E);
            Console.WriteLine(nesne1.F);
            Console.WriteLine(Program.G);
        }
    }
}
