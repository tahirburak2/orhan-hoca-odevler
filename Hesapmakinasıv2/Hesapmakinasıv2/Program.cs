namespace Hesapmakinasıv2;

class Program
{
    static void Main(string[] args)
    {
        // Bu sorudaki bölme işleminde bir hatam var ve çözemedim sadece iki sayı ile işlem yapabiliyorum şuan


        Console.WriteLine("Hangi işlemi yapmak istiyorsunuz?");
        Console.WriteLine("1- Toplama");
        Console.WriteLine("2- Çıkarma");
        Console.WriteLine("3- Çarpma");
        Console.WriteLine("4- Bölme");
        Console.Write("İşlem numarasını girin (1-4): ");
        int işlem = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Kaç adet sayı ile işlem yapmak istersiniz: ");
        int adet=int.Parse(Console.ReadLine());

 int[] sayılar=new int[adet];
 int sayaç=1;
for (int i = 0; i < adet; i++)
{
    System.Console.WriteLine($"{sayaç}. sayınız: ");
    int input2=int.Parse(Console.ReadLine());
    sayılar[i]=input2;
}
        double sonuç=sayılar[0];
                switch (işlem)
                {
                    case 1:
                        for (int i = 0; i < adet; i++)
                        {
                            sonuç += sayılar[i];
                        }
                        break;
                    case 2:
                        for (int i = 0; i < adet; i++)
                        {
                            sonuç -= sayılar[i];
                        }
                        break;
                    case 3:
                        sonuç = sonuç + 1;
                        for (int i = 0; i < adet; i++)
                        {

                            sonuç *= sayılar[i];
                        }
                        break;
                    case 4:
                if (sayılar[1] != 0)
                {
                    sonuç /= sayılar[1];
                }
                else
                {
                    System.Console.WriteLine("sayılar 0 a bölünmez");
                }
                break;

                    default:
                    System.Console.WriteLine("geçersiz sayı girdiniz öyle bir işlem kodu bulunmamakta");
                    return;
                }
        System.Console.WriteLine($"sonuç: {sonuç}");
    }
}
