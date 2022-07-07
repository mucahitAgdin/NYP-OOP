namespace Constructor_Destructor
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
        #region Değer okuma işlemler (GET)
        public double getLength()
        {
            return length;
        }
        public double getBreadth()
        {
            return breadth;
        }
        public double getHeight()
        {
            return height;
        }
        #endregion
        //constructor
        public Kutu(double len, double bre, double hei)
        {
            setLength(len);
            setBreadth(bre);
            setHeight(hei);
        }
    ~Kutu()
    {
        Console.WriteLine("bye bye");
    }
        public double getValume()
        {
            return length * breadth * height;
        }
        class Kututester
        {
            static void Main(string[] args)
            {
                Kutu Kutu1 = new Kutu(6.10, 9.5, 5.2);
                Kutu Kutu2 = new Kutu(14.5, 12.5, 13);

                //nesne 1 için hacim yordam üzerinden 
                Console.WriteLine("Volume of kutu1: {0}", Kutu1.getValume());

                //nesne 2 için hacim yordam üzerinden
                Console.WriteLine("Volume of kutu2: {0}", Kutu2.getValume());

                Kutu1 = null;
                Kutu2 = null;
                GC.Collect();//gc HAREKET GEÇİRME, ANCAK BU İŞLEMİ ÇAĞIRMAYA GEREK YOK 

                Console.ReadKey();
            }
        }
    }
}