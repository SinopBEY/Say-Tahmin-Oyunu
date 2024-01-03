using System.ComponentModel.Design;
using System.Drawing;

namespace Sayı_Tahmin_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Sayı Tahmin oyununa Hosgeldiniz.(Lütfen Seviye Seçiniz:KOLAY/ORTA/ZOR)");
            
                var Easy = Console.ReadLine();

            


            if (Easy == "KOLAY")
            {
                Console.WriteLine("Oyun Başlıyor---Tahmin Hakkın'8'---'1 ile 10 arasında bir sayı seç bunlarda dahil'");
                

                var sayi = rnd.Next(1, 11);
                
                
                for (byte i = 1; i < 10; i++)
                {
                    
                    byte gamer = byte.Parse(Console.ReadLine());



                    if (gamer != sayi)
                    {
                        Console.WriteLine($"Yanlış Tahmin  Dostum .");


                    }


                    else if (gamer == sayi)
                    {

                        int point = (11 - i) * 10;
                        Console.WriteLine($"Tebrikler Dostum Başardın PUAN={point}");

                        break;
                    }

                    if (i == 9)
                    {
                        Console.WriteLine($"Gündünde Değilsin.Tuttuğum Sayım={sayi}");
                        break;
                    }
                }
               
                    
                
           }
          

            if (Easy == "ORTA")
            {
                Console.WriteLine("Oyun Başlıyor---Tahmin Hakkın'10'---'1 ile 50 arasında bir sayı seç bunlarda dahil'");


                var sayi = rnd.Next(1, 51);
                for (byte i = 1; i < 12; i++)
                {

                    byte gamer = byte.Parse(Console.ReadLine());



                    if (gamer != sayi)
                    {
                        Console.WriteLine($"Yanlış Tahmin  Dostum .");


                    }
                    

                    else if (gamer == sayi)
                    {

                        int point = (11 - i) * 10;
                        Console.WriteLine($"Tebrikler Dostum Başardın PUAN={point}");

                        break;
                    }

                    if (i == 11)
                    {
                        Console.WriteLine($"Gündünde Değilsin.Tuttuğum Sayım={sayi}");
                        break;
                    }
                }
                

            }


            if (Easy == "ZOR") 
            {
                Console.WriteLine("Oyun Başlıyor---Tahmin Hakkın'20'---'1 ile 100 arasında bir sayı seç bunlarda dahil'");


                var sayi = rnd.Next(1, 100);
                for (byte i = 1; i < 22; i++)
                {

                    byte gamer = byte.Parse(Console.ReadLine());



                    if (gamer != sayi)
                    {
                        Console.WriteLine($"Yanlış Tahmin  Dostum .");


                    }
                    

                    else if (gamer == sayi)
                    {

                        int point = (21 - i) * 5;
                        Console.WriteLine($"Tebrikler Dostum Başardın PUAN={point}");

                        break;
                    }
                    if (i == 21)
                    {
                        Console.WriteLine($"Gündünde Değilsin.Tuttuğum Sayım={sayi}");
                        break;
                    }

                }

               


            }




          






























        }
    }
}