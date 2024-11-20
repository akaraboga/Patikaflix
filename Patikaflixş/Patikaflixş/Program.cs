using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflixş
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Diziler> dizi = new List<Diziler>();//Filmleri tutacağımız dizi listesi



            bool dongu = true;//dongu true oldukca donmeye devam edecek



            Console.WriteLine("Dizi kaydetme uygulaması.Kaydetmek istediğiniz dizileri giriniz");

            while (dongu)
            {
                Console.WriteLine("Dizinin adı");
                string DiziAd = Console.ReadLine();

                Console.WriteLine("Yapım yılı ");
                int YapıYılı = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dizinin türü ");
                string Dtür = Console.ReadLine();

                Console.WriteLine("Yayın yılı ");
                int YayınY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yonetmeni");
                string Yonetmen = Console.ReadLine();

                Console.WriteLine("Yayınlandığı ilk platform");
                string İlkYayın = Console.ReadLine();//Kullanıcıdan verileri alıyoruz.


                Diziler DiziEkle = new Diziler(DiziAd, YapıYılı, Dtür, YayınY, Yonetmen, İlkYayın);//Diziler sınıfından DiziEkle nesnesini tureterek propertylere değerleri atıyoruz.

                dizi.Add(DiziEkle);//nesneyi de olusturduğumuz listeye ekliyoruz



                Console.WriteLine("Başka dizi eklemek ister misiniz?E/H");
                string cevap = Console.ReadLine().ToUpper();//cevap E olduğu surece donecek

                if (cevap == "E")
                {
                    Console.Clear();
                    dongu = true;
                }
                else
                {
                    dongu = false;
                    Console.Clear();

                    Console.WriteLine("Tüm filmler");

                   

                }


            }


            

            foreach (var d in dizi)//d ile dizi listesni donerek tüm dizileri ekrana bastırıyoruz
            {
                Console.WriteLine("Dizinin Adı : {0}",d.Ad);
                Console.WriteLine("Yapım yılı : {0}", d.Yapımyıl);
                Console.WriteLine("Türü : {0}", d.Tür);
                Console.WriteLine("Yayınyılı : {0}", d.Yayınyılı);
                Console.WriteLine("Yonetmenler : {0}", d.Yonetmenler);
                Console.WriteLine("yayınlandığı ilk platform : {0}", d.İlkYayınyeri);
                Console.WriteLine();
            }
            
            Console.WriteLine();
            
            List<KomediDizi> komediler = dizi//Yeni bir liste olusturarak sadece Adı "Komediye eşit olanları alıyoruz"
            .Where(d => string.Equals(d.Tür, "Komedi",StringComparison.OrdinalIgnoreCase))
             .Select(d => new KomediDizi
              {
                   ad = d.Ad,
                   tür = d.Tür,
                   yonetmenler = d.Yonetmenler
              }).ToList();

            Console.WriteLine("Komedi dizileri : ");

            var sıralama = komediler.OrderBy(k => k.ad)//Once adı sonra yonetmen adını yazmasını sağlıyoruz
                .ThenBy(k => k.yonetmenler)
                .ToList();

            foreach (var komedi in komediler)//Ekrana bastırma
            {
                Console.WriteLine("Dizi Adı: {0}", komedi.ad);
                Console.WriteLine("Dizi Türü: {0}", komedi.tür);
                Console.WriteLine("Yönetmen: {0}", komedi.yonetmenler);
                Console.WriteLine("");
            }
        
            Console.ReadLine();
        }
    }
}
