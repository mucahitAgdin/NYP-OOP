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
}

class Ogrenciler
{
    List<Ogrenci> liste = new List<Ogrenci>();

    public void add(Ogrenciler ogr){

    }
}
class Program
{
    static void Main(string[] args)
    {

    }
}