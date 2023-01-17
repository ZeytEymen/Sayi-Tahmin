using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevTahmin
{
    class Program
    {
        public static void Tahmin()
        {
            // daha kısa yoldan yapabilirdim ama ödevler iyice sıkıştı hocam .d

            Console.WriteLine("Sayı Tahmin Uygulamasına Hoşgeldiniz ZEYT EYMEN KARABUDAK 200130087");
            int NeKadarTahmin = 1; // Kaç tane tahmin yaptığını öğrenmek için
            string sonuc = ""; // Sonuc değişkenimiz

            //Sayı Üretiyorum 100 ile 999 arasında
            Random sayiUret = new Random();
            int UretilenSayi = sayiUret.Next(100, 1000);
            //Console.WriteLine("PC SAYISI : " + UretilenSayi); // Bu denemek içindi

            //Sayı Girişini Alıyorum
            Console.Write("3 Basamaklı Bir Sayı Giriniz : ");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            Console.Beep();

            // Burada sayıları stringe dönüştürüp index numarasından işlem yapmak için stringe çeviriyorum
            //bu yöntem benim için daha basit
            string uretIslem = UretilenSayi.ToString();
            string tahminIslem = tahmin.ToString();
            int yuzler, onlar, birler; // her basamakta ayrı işlem olacağı için ..

            while (UretilenSayi != tahmin)// Bilgisayarın ürettiği sayı ile kullanıcının sayısı denkleşene denk döngü devam edecek
            {
                NeKadarTahmin += 1; // her döngü başında tahmin sayısı artıyor
                sonuc = ""; //her döngü başında sonuc değişkeni sıfırlanyor

                if (tahminIslem.Length < 4 && tahminIslem.Length >= 3) // alınan değer 3 basamaklı ise devam ediliyor
                {
                    //bu şekilde her basamak değeri hesaplanıyor 0.index - 0. index 
                    yuzler = Convert.ToInt32(uretIslem[0]) - Convert.ToInt32(tahminIslem[0]);
                    if (Math.Abs(yuzler) == 0)
                    {
                        sonuc += "E";
                    }
                    else if (Math.Abs(yuzler) <= 2)
                    {
                        sonuc += "Y";
                    }
                    else
                        sonuc += "U";
                    ///
                    onlar = Convert.ToInt32(uretIslem[1]) - Convert.ToInt32(tahminIslem[1]);
                    if (Math.Abs(onlar) == 0)
                    {
                        sonuc += "E";
                    }
                    else if (Math.Abs(onlar) <= 2)
                    {
                        sonuc += "Y";
                    }
                    else
                        sonuc += "U";
                    ///
                    birler = Convert.ToInt32(uretIslem[2]) - Convert.ToInt32(tahminIslem[2]);
                    if (Math.Abs(birler) == 0)
                    {
                        sonuc += "E";
                    }
                    else if (Math.Abs(birler) <= 2)
                    {
                        sonuc += "Y";
                    }
                    else
                        sonuc += "U";

                    if (sonuc == "EEE")//Eğer Sonuc EEE ise yani doğruysa kazandınız mesajı veriliyor
                    {
                        Console.WriteLine("Sonuç : " + sonuc + "\nTebrikler " + NeKadarTahmin + "tahminde oyunu kazandınız");
                        Console.Beep(); Console.Beep(); Console.Beep(); Console.Beep();
                    }
                    else
                        Console.WriteLine("Sonuç : " + sonuc + " Tekrar Deneyin");

                    Console.Write("Tahmininiz : ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    tahminIslem = tahmin.ToString();
                }
                else // girilen değer 3 basamalı değilse bir daha girilmesi isteniyor
                {
                    Console.WriteLine("Yanlış Seçim - Lütfen 3 Basamak Girin;");
                    Console.Write("Tahmininiz : ");
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    Console.Beep();
                    tahminIslem = tahmin.ToString();

                }
            }
            Console.WriteLine("Sonuç : EEE \nTebrikler " + NeKadarTahmin + " tahminde oyunu kazandınız"); Console.Beep(); Console.Beep(); Console.Beep();


        }
        static void Main(string[] args)
        {
            Tahmin(); // metodu çağırıyorum
            Console.WriteLine("Tekrar Oynamak İster misiniz ? \n Evet = E  Hayır = H");
            char devam = Convert.ToChar(Console.ReadLine());
            if (devam == 'E' || devam == 'e')
            {
                Console.Beep();
                Tahmin();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ÇIKIŞ YAPILIYOR");
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Environment.Exit(0);
            }

            Console.ReadKey();
        }
    }
}
