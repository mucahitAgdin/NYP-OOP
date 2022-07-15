using System;

namespace constructor_overloading
{
    public class overload
    {
        private int i;
        public overload()
        {
            i = 0;
        }
        public overload(int x)
        {
            i = x;
        }
        public overload(int y, int z)
        {
            i = y + z;
        }
        public int m_get()
        {
            return i;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            overload nesne0 = new overload();
            Console.WriteLine("not params: " + nesne0.m_get());
            overload nesne1 = new overload(4);
            Console.WriteLine("not params: " + nesne1.m_get());
            overload nesne2 = new overload(3, 5);
            Console.WriteLine("not params: " + nesne2.m_get());
        }
    }
}
