using System;
using System.Collections.Generic;
using System.IO;

namespace Finallib
{
    public class Ev
    {
        public int OdaSayisi { get; set; }
        public int KatNumarasi { get; set; }
        public double EvAlani { get; set; }
        public double EvKirasi { get; set; }
        public double EvDepozitosu { get; set; }
        public string EvSemt {  get; set; }
        public string EvFiyati {  get; set; }   


        static void EvKaydet(Ev ev)
        {
            string dosyaYolu = "kiralik_evler.txt";
            using (StreamWriter sw = new StreamWriter(dosyaYolu, true))
            {
                sw.WriteLine($"{ev.OdaSayisi};{ev.KatNumarasi};{ev.EvAlani};{ev.EvKirasi};{ev.EvDepozitosu}");
            }
            Console.WriteLine("Ev başarıyla kaydedildi.");

        }
        static Ev YeniEvGirisi()
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
            double evFiyati=double.Parse(Console.ReadLine());


          Ev ev = new Ev
            {
                OdaSayisi = odaSayisi,
                KatNumarasi = katNumarasi,
                EvAlani = evAlani,
                EvKirasi = evKirasi,
                EvDepozitosu = evDepozitosu
            };
            return ev;
        }
        static void SatilikEvleriGoster()
        {
            string dosyaa_adi = "satilik_evler.txt";
            string dosyaa_yolu = @"c:\satilik_evler";
            string hedefa_yol = System.IO.Path.Combine(dosyaa_yolu, dosyaa_adi);

            if (File.Exists(dosyaa_yolu))
            {
                
                
                    string satir;
                    try
                    {
                        // StreamWriter kullanarak dosyayı oluştur ve içeriği yaz
                        using (StreamWriter sw = new StreamWriter(dosyaa_adi + ".txt"))
                        {
                        sw.WriteLine("içeril");

                    }

                    Console.WriteLine("Dosya başarıyla oluşturuldu ve içerik yazıldı.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                    }
                
            }
            else
            {
                Console.WriteLine("Satilik ev bulunamadı.");
            }


        }


        static void KiralikEvleriGoster()
        {
            string dosya_yolu = "kiralik_evler.txt";
            if (File.Exists(dosya_yolu))
            {
                using (StreamReader sr = new StreamReader(dosya_yolu))
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
    }
}
