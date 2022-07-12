using System;
using System.Collections.Generic;

namespace deneme
{
    class Ogrenci
    {
        public int ogrenciNo;
        public string adSoyad;

        public Ogrenci(int _ogrenciNo, string _adSoyad)
        {
            ogrenciNo = _ogrenciNo;
            adSoyad = _adSoyad;
        }
    }
    class Ogrenciler
    {
        List<Ogrenci> liste = new List<Ogrenci>();

        public void add(Ogrenci ogr)
        {
            liste.Add(ogr);
        }
        public Ogrenci get_Ogrenci(int i)
        {
            if (i >= 0 && i < get_len())
                return liste[i];
            else
                return null;
        }
        public int get_len()
        {
            return liste.Count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenciler nesne01 = new Ogrenciler();
            nesne01.add(new Ogrenci(234, "mehmet"));
            nesne01.add(new Ogrenci(15, "başak"));
            nesne01.add(new Ogrenci(2, "emre"));
            nesne01.add(new Ogrenci(23, "muco"));

            Ogrenci nesne_ogr = nesne01.get_Ogrenci(2);
            Console.WriteLine(nesne_ogr.adSoyad + ", " + nesne_ogr.ogrenciNo);

            for (int i = 0; i < nesne01.get_len(); i++)
            {
                nesne_ogr = nesne01.get_Ogrenci(i);
                    Console.WriteLine(nesne_ogr.adSoyad + ", " + nesne_ogr.ogrenciNo);   
            }
            nesne_ogr = nesne01.get_Ogrenci(2);
            if(nesne_ogr != null)
                Console.WriteLine(nesne_ogr.adSoyad + ", " + nesne_ogr.ogrenciNo);
        }
    }
}
