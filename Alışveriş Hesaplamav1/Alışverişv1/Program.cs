using System.Reflection;

namespace Alışverişv1;
//v1
// - Kullanıcıya hazır ürünler çıkaralım.Örneğin market alışverinde olabilecek şeyler. Paralel dizi ile fiyatlarını da listeyelim.
// - Kullanıcı hangi ürünleri istiyorsa onun fiyatını toplam fiyata ekleyelim.eğer t harfini girerse toplam gösterip sonuçlandıralım
class Program
{
    static void Main(string[] args)
    {
        string devam;
        string klavye="";
       string[] urunler={"makarna","danone","çilek","çikolata","dondurma"};
       double[] fiyatlar={2.99,1.25,15,3.75,5};
int sayaç=1;
double toplamFiyat=0;
       do
       {
        for (int i = 0; i < urunler.Length; i++)
        {
            System.Console.WriteLine($"{sayaç}. {urunler[i]} fiyatları: {fiyatlar[i]} tl");
            sayaç++;
        }
        
        System.Console.Write("ürün seçmek için numarasını giriniz (alışverişi bitirip toplam fiyatı görmek için ise 'T'ye basınız):");
         devam=Console.ReadLine().ToLower();
         
if (devam!="t")
{
    int urunNum;
    bool kontrol=int.TryParse(devam, out urunNum);
   if (urunNum>=1&&urunNum<=urunler.Length)
   {
                    toplamFiyat += fiyatlar[urunNum-1];
                    Console.WriteLine($"{urunler[urunNum - 1]} sepete eklendi. Fiyatı: {fiyatlar[urunNum - 1]} TL");
                }
        
        
    
}
           if(devam=="t")
            {
                System.Console.WriteLine($"Ürünlerin Toplamı = {toplamFiyat}TL");
                System.Console.WriteLine("Alışverişe devam etmek istemiyorsanız 'D' tuşuna basınız");
                klavye = Console.ReadLine().ToLower();
            }
        } while (devam!="d"); 
       
    }
}
