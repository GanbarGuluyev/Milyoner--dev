using System.Transactions;

namespace Milyoner_Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kim Milyoner Olmak İstemez Ki: \n");
            Console.WriteLine("Adınızı Giriniz: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı Girin: ");
            string soyad = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hoş Geldiniz: " + ad + " " + soyad);
        }
    }
}