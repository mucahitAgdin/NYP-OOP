using System;

namespace property
{
    public class Daire
    {
        private int r;
        public Daire(int _r)//constructor
        {
            this.Yaricap = _r;
        }

        //TODO: Property olmadan yapılan method
        // public void set_Yaricap(int _r)
        // {
        //     if (_r < 0)
        //         _r = 0;
        //     r = _r;
        // }
        // public int get_Yaricap()
        // {
        //     return r;
        // },

        // Property Methodu
        public int Yaricap
        {
            set
            {
                if (value < 0)
                    r = 0;
                else
                    r = value;
            }
            get
            {
                return r;
            }
        }
        // public double cevre_hesapla()
        // {
        //     return 2 * Math.PI * r;
        // }
        public double cevre // Property: sadece get var -> read only
        {
            get
            {
                return 2 * Math.PI * r;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Daire nesne0 = new Daire(5); // constructor ile
            //nesne0.set_Yaricap(3);
            //Console.WriteLine("çevresi: " + nesne0.cevre_hesapla());
            //nesne0.Yaricap = 5; // constructor'sız Daire(5) şeklinde değil new Daire(); şeklinde
            Console.WriteLine("çevresi: " + nesne0.cevre);
        }
    }
}
