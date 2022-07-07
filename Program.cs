using System;

namespace MerhabaNYP
{
   
    class encapsulation
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
}

public class kutu //SINIF
{
    public int x;
    //attirubutes
    public int y;
    public int z;

    public int hacmi_hesapla()//method
    {
        return x * y * z;
    }
}
class Program
{
    static void Main(string[] args)
    {
        kutu k01 = new kutu(); // nesne 1
        k01.x = 10;
        k01.y = 20;//nesne 1'in özellikleri
        k01.z = 5;
        Console.WriteLine("hacmi: " + k01.hacmi_hesapla());
        //Console.WriteLine("hacmi: " + (k01.x * k01.y * k01.z));

        kutu k02 = new kutu(); // nesne 2
        k02.x = 10;
        k02.y = 20;//nesne 2'nin özellikleri
        k02.z = 5;
        Console.WriteLine("hacmi: " + k02.hacmi_hesapla());
        //Console.WriteLine("hacmi: " + (k02.x * k02.y * k02.z));
    }
}
