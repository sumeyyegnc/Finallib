

using Finallib;
using System.Security.Cryptography.X509Certificates;

namespace FinalApp
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            string dosya_adi = "kiralik_evler.txt";
            string dosya_yolu = @"c:\kiralik_evler";
            string hedef_yol = System.IO.Path.Combine(dosya_yolu, dosya_adi);
            if (System.IO.File.Exists(hedef_yol))
            {
                Console.WriteLine("Dosya zaten mevcut");

            }
            else
            {

                System.IO.File.Create(hedef_yol);
            }
            string dosyaa_adi = "satilik_evler.txt";
            string dosyaa_yolu = @"c:\satilik_evler";
            string hedefa_yol = System.IO.Path.Combine(dosyaa_yolu, dosyaa_adi);
            if (System.IO.File.Exists(hedef_yol))
            {
                Console.WriteLine("Dosya zaten mevcut");

            }
            else
            {

                System.IO.File.Create(hedef_yol);
            }


            while (true) { 
                Console.WriteLine("Lütfen bir seçim yapın:");
                Console.WriteLine("Kiralik Ev");
                Console.WriteLine("Satilik Ev");

                string secenek = Console.ReadLine();
                if (secenek == "Kiralik Ev")
                {
                    
                    Console.WriteLine("Lütfen bir seçim yapın:");
                    Console.WriteLine("1. Yeni ev girişi");
                    Console.WriteLine("2. Kiralık evleri göster");
                string secim = Console.ReadLine();

                if (secim == "1")
                        {
                            Ev yeniEv = YeniEvGirisi();
                            EvKaydet(yeniEv);
                        }
                        else if (secim == "2")
                        {
                            KiralikEvleriGoster();
                        }
                }
               else if (secenek == "Satilik Ev")
               {
                    
                    Console.WriteLine("Lütfen bir seçim yapın:");
                    Console.WriteLine("1. Yeni ev girişi");
                    Console.WriteLine("3. Satılık evleri göster");
                string secim = Console.ReadLine();
                if (secim == "1")
                    {
                        Ev yeniEv = YeniEvGirisi();
                        EvKaydet(yeniEv);
                    }

                    else if (secim == "3")
                    {
                        SatilikEvleriGoster();
                    }
               }

            }

           
        }

        private static void KiralikEvleriGoster()
        {
            string dosyaYolu = "kiralik_evler.txt";
            if (File.Exists(dosyaYolu))
            {
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        string[] evBilgileri = satir.Split(';');
                        Console.WriteLine($"Oda Sayısı: {evBilgileri[0]}, Kat Numarası: {evBilgileri[1]}, Ev Alanı: {evBilgileri[2]} m², Ev Kirası: {evBilgileri[3]} TL, Ev Depozitosu: {evBilgileri[4]} TL");
                    }
                }
            }
            else
            {
                Console.WriteLine("Kiralık ev bulunamadı.");
            }
        }

        private static void EvKaydet(Ev yeniEv)
        {
            string dosyaYolu = "kiralik_evler.txt";
            using (StreamWriter sw = new StreamWriter(dosyaYolu, true))
            {
                sw.WriteLine($"{yeniEv.OdaSayisi};{yeniEv.KatNumarasi};{yeniEv.EvAlani};{yeniEv.EvDepozitosu};{yeniEv.}");
            }
            Console.WriteLine("Ev başarıyla kaydedildi.");
        }
        private static void SatilikEvleriGoster()
        {
            string dosyaYolu = "satilik_evler.txt";
            if (File.Exists(dosyaYolu))
            {
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        string[] evBilgileri = satir.Split(';');
                        Console.WriteLine($"Oda Sayısı: {evBilgileri[0]}, Kat Numarası: {evBilgileri[1]}, Ev Alanı: {evBilgileri[2]} m², Ev Fiyatı: {evBilgileri[3]} TL, ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Satilik ev bulunamadı.");
            }
        }

        private static Ev YeniEvGirisi()
        {
            Console.WriteLine("Oda Sayısı:");
            int odaSayisi = int.Parse(Console.ReadLine());

            Console.WriteLine("Kat Numarası:");
            int katNumarasi = int.Parse(Console.ReadLine());

            Console.WriteLine("Ev Alanı (m²):");
            double evAlani = double.Parse(Console.ReadLine());

            Console.WriteLine("Ev Kirası (TL):");
            double evKirasi = double.Parse(Console.ReadLine());

            Console.WriteLine("Ev Depozitosu (TL):");
            double evDepozitosu = double.Parse(Console.ReadLine());

            Console.WriteLine("Ev Semti:");
            Console.ReadLine();

            Console.WriteLine("Ev Fiyatı (TL)");
            double evFiyati = double.Parse(Console.ReadLine());

            Ev ev = new Ev
            {
                OdaSayisi = odaSayisi,
                KatNumarasi = katNumarasi,
                EvAlani = evAlani,
                EvKirasi =evKirasi,
               EvDepozitosu= evDepozitosu


            };

            return ev

                Ev ev2 = new Ev
                {
                    OdaSayisi = odaSayisi,
                    KatNumarasi = katNumarasi,
                    EvAlani = evAlani,
                    EvFiyati = evFiyati,
                    EvDepozitosu = evDepozitosu

                }
        }
    }

       
    
}