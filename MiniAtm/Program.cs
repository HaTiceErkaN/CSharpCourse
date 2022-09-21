using System;

namespace MiniAtm
{

    
    class Program
    {
        public static int bakiye = 1500;
        public static int yatirilacakTutar;
        public static int cekilecekTutar;
        public static String islem;
        public static String farkliIslem;
       public static  void Main(String[] args) {
            girisEkrani();       
    }


        public static void girisEkrani()
        {
            Console.WriteLine("HALKBANK'a Hoşgeldiniz");
            Console.WriteLine();
            islemSec();
         
        }

        public static void islemSec()
        {
            Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz");
            Console.WriteLine("Bakiye Goruntuleme icin : 1");
            Console.WriteLine("Para Cekme icin         : 2");
            Console.WriteLine("Para Yatırma icin       : 3");
            Console.WriteLine("Cıkıs yapmak icin       : q");
            islem = Console.ReadLine().ToLower();

            switch (islem)
            {
                case "1":
                    bakiyeGoruntule();
                    break;

                case "2":
                    paraCekme();
                    break;
                case "3":
                    paraYatırma();
                    break;
                case "q":
                    cıkısYapma();
                    break;

                default:
                    Console.WriteLine("Lutfen gecerli bir deger giriniz");
                    break;
            }

        }

        public static void bakiyeGoruntule()
        {
            Console.WriteLine("Bakiyeniz : " + bakiye + " tl'dir");
            farklıIslem();
        }

        public static void paraCekme()
        {
            Console.WriteLine("Lutfen cekmek istediginiz tutarı giriniz");
            cekilecekTutar = Convert.ToInt16(Console.ReadLine());
            if (cekilecekTutar > bakiye)
            {
                Console.WriteLine("Bakiyeniz "+bakiye+" tl'dir, girdiginiz " + cekilecekTutar + " icin yetersizdir.Lutfen gecerli bir tutar giriniz");
                paraCekme();
               
            }
            else
            {
             
                bakiye = bakiye - cekilecekTutar;
                Console.WriteLine("Para cekme isleminiz gerceklestirilmistir. Guncel bakiyeniz: " + bakiye + " tl'dir");
                farklıIslem();
            }
            
        }

        public static void paraYatırma()
        {

            Console.WriteLine("Lutfen yatırmak istediginiz tutari giriniz");
            yatirilacakTutar = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("İsleminiz gerceklestiriliyor lutfen bekleyiniz...");
            bakiye = bakiye + yatirilacakTutar;
            Console.WriteLine("İsleminiz basarili bir seki de gerceklesmistir. Guncel bakiyeniz: " + bakiye + " tl'dir.");
            farklıIslem();
        }

        public static void cıkısYapma()
        {
            Console.WriteLine("Cıkıs isleminiz gerceklestiriliyor, Lutfen bekleyiniz..");
            Console.WriteLine("Cıkıs isleminiz gerceklesmistir. Bizi tercih ettiginiz icin tesekkur eder, iyi günler dileriz..");
           
        }

        public static void farklıIslem()
        {
            Console.WriteLine("Farkli bir islem yapmak istiyor musunuz?  Evet: E, Hayır:H");
            farkliIslem = Console.ReadLine().ToUpper();
            if (farkliIslem == "E")
            {
                girisEkrani();
            }
            else if (farkliIslem == "H")
            {
                cıkısYapma();
            }
            else
            {
                Console.WriteLine("Lutfen gecerli bir islem giriniz");
                farklıIslem();
            }
        }
    }
}




      

        

          
