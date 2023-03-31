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
            Console.ReadLine();
            Console.Clear();


            Console.Write("\n1.Telefon Jokerinizi Giriniz: ");
            string telefonJoker1 = Console.ReadLine();
            Console.Write("2.Telefon Jokerinizi Giriniz: ");
            string telefonJoker2 = Console.ReadLine();
            Console.Write("3.Telefon Jokerinizi Giriniz: ");
            string telefonJoker3 = Console.ReadLine();
            Console.WriteLine("Jokerleriniz: " + "1" + telefonJoker1 + "2" + telefonJoker2 + "3" + telefonJoker3);
            Console.ReadLine();

            Console.Clear();

            Console.Write("Kuralları Biliyor Musunuz? : ");
            char kuralCevap = char.Parse(Console.ReadLine().ToUpper());

            if (kuralCevap != 'E')
            {
                // TODO: Kurallar eklenecek.
                Console.WriteLine("Kurallar: asdfasdaads");
            }

            Console.Write("Hazır Mısınız? : ");
            char hazirCevap = char.Parse(Console.ReadLine().ToUpper());

            if (hazirCevap != 'E')
            {
                Console.WriteLine("Hazır olmananız bekleniyor.");
                Console.WriteLine("Hazır olduğunuzda Enter'a Basın");
                Console.ReadLine();
            }
            bool seyirciHak = true, yuzdeHak = true, telefonHak = true;
            int kasa = 0;

            int soruNo = 1, odul, baraj;
            int seyirciYuzdeA, seyirciYuzdeB, seyirciYuzdeC, seyirciYuzdeD;
            bool gizleA, gizleB, gizleC, gizleD;
            string soru, a, b, c, d;
            char cevap;

            #region Soru Bilgileri
            soruNo = 1;
            soru = "Türkiyenin Başkenti Neresidir?";
            a = "Ankara";
            b = "Bursa";
            c = "Van";
            d = "Denizli";
            cevap = 'A';
            odul = 1000;
            baraj = 0;// TODO: SoruNo ile baraj ilişkisi.

            // TODO: SoruNo ile ilişkili olarak Rastgele değerler olması lazım.
            seyirciYuzdeA = 80; seyirciYuzdeB = 10;
            seyirciYuzdeC = 5; seyirciYuzdeD = 5;

            // TODO: Daha iyi olabirlir mi? Her seferinde bunu tekrarlamaya gerek yok gibi.
            gizleA = false; gizleB = false;
            gizleC = false; gizleD = false;
            #endregion
        }
    }
}