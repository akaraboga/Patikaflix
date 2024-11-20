using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflixş
{
    internal class KomediDizi//Sadece komedi için olusturlan sınıf
    {
        public string ad { get; set; }
        public string tür { get; set; }
        public string yonetmenler { get; set; }

        public KomediDizi()
        {
            Console.WriteLine("Dizinin Adı : {0}",ad);
            Console.WriteLine("Türü : {0}",tür);
            Console.WriteLine("Yonetmeni : {0}", yonetmenler);
        }

    }
}
