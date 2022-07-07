namespace NYP
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 100);
            int i = 1;
            while (true)
            {
                Console.Write("tahmin No:" + i + ", bir sayi giriniz: ");
                i++;
                string cevap = Console.ReadLine();
                int cevap_sayi = Convert.ToInt32(cevap);

                if (cevap_sayi == sayi)
                {
                    Console.WriteLine("orospular kazanır");
                    break;
                }
                else if (Math.Abs(cevap_sayi - sayi) < 5)
                    Console.WriteLine("çok sıcak");

                else if (Math.Abs(cevap_sayi - sayi) < 10)
                    Console.WriteLine("sıcak");

                else if (Math.Abs(cevap_sayi - sayi) < 15)
                    Console.WriteLine("ılık");

                else if (Math.Abs(cevap_sayi - sayi) < 20)
                    Console.WriteLine("soğuk");

                else
                    Console.WriteLine("çok soğuk");

            }
            //Console.WriteLine(sayi);

        }
    }
}
/*TODO: CONST: value must be given at the time of identification.
value does not change afterwards*/

