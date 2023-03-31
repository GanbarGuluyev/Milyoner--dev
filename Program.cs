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


            Console.Write("\n1.Telefon Jokerinizi Giriniz: ");
            string telefonJoker1 = Console.ReadLine();
            Console.Write("2.Telefon Jokerinizi Giriniz: ");
            string telefonJoker2 = Console.ReadLine();
            Console.Write("3.Telefon Jokerinizi Giriniz: ");
            string telefonJoker3 = Console.ReadLine();


        }
    }
}