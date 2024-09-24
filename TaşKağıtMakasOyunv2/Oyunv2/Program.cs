namespace Oyunv2;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            
        
        int sayaç=0;
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
            sayaç++;
            Console.WriteLine($"Kazandınız ve şuanki puanınız: {sayaç}");

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
        System.Console.WriteLine("oyuna devam etmek için herhangi bir tuşa basınız çıkış yapmak için ise 'çıkış' yazınız.");
       devam=Console.ReadLine();
        } while (devam=="çıkış");
    }
}
