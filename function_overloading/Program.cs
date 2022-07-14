using System;

namespace function_overloading
{
    public class islem
    {
        public int topla()
        {
            return 0;
        }
        public int topla(int i)
        {
            return i;
        }
        public int topla(int i, int j)
        {
            return i + j;
        }
        public int topla(int i, int j, int k)
        {
            return i + j + k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            islem toplam = new islem();
            Console.WriteLine("topla1: "+toplam.topla()+ "\ntopla2: "+ toplam.topla(1)+ "\ntopla3: "+ toplam.topla(1,2)+"\ntopla4: "+ toplam.topla(1,2,3));
        }
    }
}
