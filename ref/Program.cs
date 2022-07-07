class Program
{
    //ref anahtar kelimesi değer tipinden önce kullanılmalı.
    static void kareAl(ref double d)
    {
        d = d * d;
    }
    static void Main(string[] args)
    {
        double i = 3.45;
        Console.WriteLine("Double sayi: {0}", i);
        kareAl(ref i); // ref parametresini içeren metod çağırılıyor.
        Console.WriteLine("Karesi: {0}",i);
        Console.ReadKey();

    }
}
