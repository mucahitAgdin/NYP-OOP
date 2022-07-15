using System;

namespace function_overloading
{
    //aynı türlerde fakat parametre sayıları farklı 
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
        //aynı parametreli farklı türlerde function overloading
        public int carp(int x,int y)
        {
            return x*y;
        }
        public int carp(string x,string y)
        {
            return Convert.ToInt32(x)*Convert.ToInt32(y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            islem carpim = new islem();
            islem toplam = new islem();
            Console.WriteLine("topla1: " + toplam.topla() + "\ntopla2: " + toplam.topla(1) + "\ntopla3: " + toplam.topla(1, 2) + "\ntopla4: " + toplam.topla(1, 2, 3));
            Console.WriteLine("\ncarp_int: "+ carpim.carp(2,5)+"\ncarp_string: "+carpim.carp('x','y'));
        }
    }
}
