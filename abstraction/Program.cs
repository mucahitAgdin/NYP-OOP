using System;


namespace abstraction
{
    class Kutu
    {
        private double length;
        private double breadth;
        private double height;
        public void setLength(double len)
        {
            if (len <= 0)
                length = 1;
            else
                length = len;
        }
        public void setBreadth(double bre)
        {
            if (bre <= 0)
                breadth = 1;
            else
                breadth = bre;
        }
        public void setHeight(double hei)
        {
            if (hei <= 0)
                height = 1;
            else
                height = hei;
        }
        public double getValume()
        {
            return length * breadth * height;
        }
    }
    class Kututester
    {
        static void Main(string[] args)
        {
            Kutu Kutu1 = new Kutu();
            Kutu Kutu2 = new Kutu();

            //Nesne 1 yordam üzerinden
            Kutu1.setLength(-1.0);
            Kutu1.setBreadth(7.0);
            Kutu1.setHeight(5.0);

            //Nesne 2 yordam üzerinden 
            Kutu2.setLength(12.0);
            Kutu2.setBreadth(10.0);
            Kutu2.setHeight(13.0);

            //nesne 1 için hacim yordam üzerinden 
            Console.WriteLine("Volume of kutu1: {0}", Kutu1.getValume());

            //nesne 2 için hacim yordam üzerinden
            Console.WriteLine("Volume of kutu2: {0}", Kutu2.getValume());

            Console.ReadKey();
        }
    }
}

