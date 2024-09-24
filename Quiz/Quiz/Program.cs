namespace Quiz;

class Program
{
    static void Main(string[] args)
    {
        string[] sorular = { "Gökyüzü ne renktir?", "Türkiye'nin başkenti neresidir?" };
        string[] cevaplar = { "mavi", "ankara" };
        string[] şıklar = {"kırmızı|mavi|sarı","diyarbakır|istanbul|ankara"};
        int dogruSayisi = 0;
        int yanlisSayisi = 0;

        for (int i = 0; i < sorular.Length; i++)
        {
            System.Console.WriteLine(sorular[i]);

            string[] mevcutSecenekler = şıklar[i].Split('|');
            for (int j = 0; j < mevcutSecenekler.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {mevcutSecenekler[j]}");
            }
            Console.Write("Cevabınızı girin: ");
            int secim = int.Parse(Console.ReadLine()) - 1;
            if (mevcutSecenekler[secim].ToLower() == cevaplar[i].ToLower())
            {
                Console.WriteLine("Doğru!");
                dogruSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış!");
                yanlisSayisi++;
            }
        }

        
        Console.WriteLine($"Toplam Doğru Sayısı: {dogruSayisi}");
        Console.WriteLine($"Toplam Yanlış Sayısı: {yanlisSayisi}");
    }
}

        
