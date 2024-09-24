namespace Hesapmakinasıv3;

class Program
{
    static void Main(string[] args)
    {
        int işlem;
        string devam;

        do
        {





            int sayac = 1;
            Console.WriteLine("Hangi işlemi yapmak istiyorsunuz?");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Çarpma");
            Console.WriteLine("4- Bölme");
            Console.Write("Hangi işlemi yapacağınızı 1-4 arasında sayı girerek belirtin => ");
            işlem = int.Parse(Console.ReadLine());
            Console.Write("Kaç adet sayı ile işlem yapmak istiyorsunuz => ");
            int adet = int.Parse(Console.ReadLine());

            int[] list = new int[adet];

            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{sayac}. sayınız => ");
                list[i] = int.Parse(Console.ReadLine());
                sayac++;
            }

            double sonuc = list[0];

            switch (işlem)
            {
                case 1:
                    for (int i = 1; i < list.Length; i++)
                    {
                        sonuc += list[i];
                    }
                    Console.WriteLine($"işlem sonucu => {sonuc}");
                    break;

                case 2:
                    for (int i = 1; i < list.Length; i++)
                    {
                        sonuc -= list[i];
                    }
                    Console.WriteLine($"işlem sonucu => {sonuc}");
                    break;

                case 3:
                    for (int i = 1; i < list.Length; i++)
                    {
                        sonuc *= list[i];
                    }
                    Console.WriteLine($"İşlem sonucu => {sonuc}");
                    break;

                case 4:
                    for (int i = 1; i < list.Length; i++)
                    {
                        if (list[i] != 0)
                        {
                            sonuc /= list[i];
                        }
                        else
                        {
                            Console.WriteLine("0'a bölünmez");
                            break;
                        }
                    }
                    Console.WriteLine($"İşlem sonucu: {sonuc}");
                    break;

                default:
                    Console.WriteLine("Lütfen 1 - 4 arasında bir sayı giriniz!");
                    break;


                    
            }

            Console.Write("başka bir işlem yapmak istemiyorsanız 'e'ye basınız devam etmek için klabyeden herhangi bir sayıya basınız:");
            devam = Console.ReadLine().ToLower();
        } while (devam!="e") ;


        
      }
}