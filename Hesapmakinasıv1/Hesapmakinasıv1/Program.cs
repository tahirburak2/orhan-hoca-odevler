namespace Hesapmakinasıv1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Kaç sayı girmek istediğiniz girin: ");
        int input=int.Parse(Console.ReadLine());
        int sayaç=1;
        int toplam=0;
        for (int i = 0; i < input; i++)
        {
            System.Console.Write($"{sayaç}. sayı: ");
            sayaç++;
            int input1=int.Parse(Console.ReadLine());
            toplam+=input1;
        }
        System.Console.WriteLine($"girdiğiniz sayıların toplamı: {toplam}");
    }
}
