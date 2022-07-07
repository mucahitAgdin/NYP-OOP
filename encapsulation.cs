using System;


namespace MerhabaNYP
{
    class Kututester{
        static void Main(string[] args)
        {
            encapsulation Kutu1 = new encapsulation();
            encapsulation Kutu2 = new encapsulation();

            //Nesne 1 yordam üzerinden
            Kutu1.setLength(6.0);
            Kutu1.setBreadth(7.0);
            Kutu1.setHeight(5.0);

            //Nesne 2 yordam üzerinden 
            Kutu2.setLength(12.0);
            Kutu2.setBreadth(10.0);
            Kutu2.setHeight(13.0);

            //nesne 1 için hacim yordam üzerinden 
            Console.WriteLine("Volume of kutu1: {0}", Kutu1.getValume());

            //nesne 2 için hacim yordam üzerinden
            Console.WriteLine("Volume of kutu2: {0}",Kutu2.getValume());

            Console.ReadKey();
        }
    }
}