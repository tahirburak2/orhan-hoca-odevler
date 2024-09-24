using System.ComponentModel;
using System.IO.Compression;

namespace alışverişv2;
// v2
// - En az 10 tane ürün gösterelim
// - Kullanıcı kaç adet ürün almak istediğini seçsin
// - İşlemler tamamlandığında kullanıcıya neleri aldığını ve toplam tutarı söyleyelim
class Program
{
    static void Main(string[] args)
    {
        string[] urunler = { "sürpriz yumurta", "çikolata", "cips", "su", "kola", "bueno", "meyveli yoğurt", "tutku", "browni", "iphone" };
        int[] fiyatlar = { 1, 3, 5, 6, 4, 3, 8, 9, 3, 100 };
        int toplamFiyat = 0;
        


            System.Console.WriteLine("---------MARKETTEKİ ÜRÜNLERİMİZ---------");

            for (int i = 0; i < urunler.Length; i++)
            {
                System.Console.WriteLine($"{i + 1}. ürün {urunler[i]} fiyatı: {fiyatlar[i]} tl");

            }
            System.Console.Write("Kaç adet ürün almak istediğinizi giriniz:");
            int adet = int.Parse(Console.ReadLine());
        string[] seçilenUrunler = new string[adet];
            for (int i = 0; i < adet; i++)
            {
                System.Console.Write("kaç no'lu ürünü seçmek istediğinizi giriniz:");
                int seçilen = int.Parse(Console.ReadLine());
                seçilenUrunler[i]=urunler[seçilen];
                toplamFiyat += fiyatlar[seçilen-1];
            }

        System.Console.WriteLine($"Seçilen ürünler:");
        for (int i = 0; i < adet; i++)
            {
                System.Console.WriteLine(seçilenUrunler[i]);
            }
            System.Console.WriteLine($"Aldığınız ürünlerin toplam fiyatı: {toplamFiyat}");
        
    }
}
