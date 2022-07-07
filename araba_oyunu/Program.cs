using System;

namespace araba_oyunu
{
    public class araba
    {
        private double yakit;//attiributes
        public int hiz;//attiributes

        public araba(double y, int s)//constructor
        {
            set_yakit(y);
            set_hiz(s);
        }
        public string goster()
        {
            return "yakit miktari: " + yakit.ToString() + " - hiz:" + hiz.ToString();/*bilinçli dönüşüm*/
        }

        /*TODO: METHODS*/
        public void set_yakit(double y)//encapsulation 
        {
            if (y > 60)
                y = 60;
            if (y < 0)
                y = 0;
            yakit = y;
        }

        public double get_Yakit()
        {
            return yakit;
        }
        public void set_hiz(double s)//encapsulation 
        {
            if (s > 260)
                s = 260;
            if (s < 0)
                s = 40;
            hiz = (int)s;
        }
        public int get_hiz()
        {
            return hiz;
        }

        public void Yakit_yukle(double y)
        {
            y = yakit + y;
            set_yakit(y);
        }
        public void sur()
        {
            if (hiz < 50)
                yakit -= 3;
            else if (hiz < 90)
                yakit -= 1;
            else if (hiz < 120)
                yakit -= 2;
            else if (hiz < 180)
                yakit -= 3;
            else
                yakit -= 4;

            set_yakit(yakit);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            araba nesne01 = new araba(40, 25);
            Console.WriteLine(nesne01.goster());
            nesne01.sur();
            Console.WriteLine(nesne01.goster());
            nesne01.set_hiz(80);
            nesne01.sur();
            Console.WriteLine(nesne01.goster());
            nesne01.set_hiz(220);
            nesne01.sur();
            Console.WriteLine(nesne01.goster());
            //nesne01.set_yakit(40);
            //Console.WriteLine(nesne01.goster());
            Console.WriteLine("\n");
            araba nesne02 = new araba(15, 125);
            Console.WriteLine(nesne02.goster());
            nesne02.sur();
            Console.WriteLine(nesne02.goster());
            nesne02.set_hiz(150);
            nesne02.sur();
            Console.WriteLine(nesne02.goster());
            nesne02.set_hiz(260);
            nesne02.sur();
            Console.WriteLine(nesne02.goster());
        }
    }
}