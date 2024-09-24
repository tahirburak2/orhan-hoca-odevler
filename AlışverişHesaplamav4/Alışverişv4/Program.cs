namespace Alışverişv4;
// v2
// - En az 10 tane ürün gösterelim
// - Kullanıcı kaç adet ürün almak istediğini seçsin
// - İşlemler tamamlandığında kullanıcıya neleri aldığını ve toplam tutarı söyleyelim

// v3
// - Kullanıcıya para üstü bilgisi vermek adına ödediği tutarı da girelim

// v4
// - Ürünlerin stok durumlarını da ayrı bir paralel dizide tutalım.Ekleme yapılırken adet girişi de yapılsın.

class Program
{
    static void Main(string[] args)
    {
        string[] urunler = { "sürpriz yumurta", "çikolata", "cips", "su", "kola", "bueno", "meyveli yoğurt", "tutku", "browni", "iphone" };
        int[] fiyatlar = { 1, 3, 5, 6, 4, 3, 8, 9, 3, 100 };
        int[] stok = { 4, 5, 6, 4, 3, 5, 6, 4, 3, 6};
        int toplamFiyat = 0;



        System.Console.WriteLine("---------MARKETTEKİ ÜRÜNLERİMİZ---------");

        for (int i = 0; i < urunler.Length; i++)
        {
            System.Console.WriteLine($"{i + 1}. ürün {urunler[i]} stok adeti: {stok[i]}\nfiyatı: {fiyatlar[i]} tl");

        }
        System.Console.Write("Kaç adet ürün almak istediğinizi giriniz:");
        int adet = int.Parse(Console.ReadLine());
        string[] seçilenUrunler = new string[adet];
        for (int i = 0; i < adet; i++)
        {
            System.Console.Write("kaç no'lu ürünü seçmek istediğinizi giriniz:");
            int seçilen = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Seçtiğiniz üründen kaç adet almak istersiniz: ");
            int kaçAdet=int.Parse(Console.ReadLine());
            seçilenUrunler[i] = urunler[seçilen];
            for (int f = 0; f < kaçAdet; f++)
            {
                toplamFiyat += fiyatlar[seçilen - 1];
            }
        }

        System.Console.WriteLine($"Seçilen ürünler:");
        for (int i = 0; i < adet; i++)
        {
            System.Console.WriteLine(seçilenUrunler[i]);
        }
        System.Console.WriteLine($"Aldığınız ürünlerin toplam fiyatı: {toplamFiyat}");

        System.Console.Write("Verdiğiniz parayı yazınız: ");
        int verilenPara = int.Parse(Console.ReadLine());

        System.Console.WriteLine($"Para üstü= {verilenPara - toplamFiyat}");
    }
}
