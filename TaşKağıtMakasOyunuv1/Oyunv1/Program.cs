﻿namespace Oyunv1;
// v1
// - string dizisi içinde taş kağıt makas seçenekleri olsun.
// - kullanıcıya hangi seçeneği seçtiğini sorun
// - durumlara bağlı olarak kazandın veya kaybettin deyin
class Program
{
    static void Main(string[] args)
    {
        string[] secenekler = { "Taş", "Kağıt", "Makas" };
        Random rnd = new Random();

        Console.WriteLine("Taş, Kağıt veya Makastan birini seçin: ");
        string seçilen = Console.ReadLine().ToLower();
        int ındex = rnd.Next(0, secenekler.Length);
        string rastgeleSeçilen = secenekler[ındex];
        Console.WriteLine($"Siz: {seçilen}");
        Console.WriteLine($"Bilgisayar: {rastgeleSeçilen}");
        if (seçilen.ToLower() == rastgeleSeçilen.ToLower())
        {
            Console.WriteLine("Berabere!");
        }
        else if ((seçilen.ToLower() == "taş" && rastgeleSeçilen.ToLower() == "makas") ||
                 (seçilen.ToLower() == "kağıt" && rastgeleSeçilen.ToLower() == "taş") ||
                 (seçilen.ToLower() == "makas" && rastgeleSeçilen.ToLower() == "kağıt"))
        {
            Console.WriteLine("Kazandınız!");

        }
        else if ((seçilen.ToLower() == "taş" && rastgeleSeçilen.ToLower() == "kağıt") ||
                     (seçilen.ToLower() == "kağıt" && rastgeleSeçilen.ToLower() == "makas") ||
                     (seçilen.ToLower() == "makas" && rastgeleSeçilen.ToLower() == "taş"))
        {
            Console.WriteLine("Kaybettiniz!");
        }
        else
        {
            Console.WriteLine("Geçersiz seçim! Lütfen Taş, Kağıt veya Makas yazın.");
        }
    }
}

