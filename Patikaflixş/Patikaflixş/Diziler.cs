using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflixş
{
    internal class Diziler//Diziler sınıfı ile dizilerin ozelliklerini alıyoruz
    {
        public string Ad { get; set; }

        public int  Yapımyıl { get; set; }

        public string Tür { get; set; }


        public int Yayınyılı { get; set; }

        public string Yonetmenler { get; set; }

        public string İlkYayınyeri { get; set; }

        public  Diziler(string _ad,int _yapımyılı,string _tür,int _yayınyılı,string _yonetmenler,string _ilkyayınyeri)
        {



            Ad = _ad;
            Yapımyıl=_yapımyılı;
            Tür = _tür;
            Yayınyılı=_yayınyılı;
            Yonetmenler = _yonetmenler;
            İlkYayınyeri=_ilkyayınyeri;


           
        }
      
    }
}
