using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GecmisNotDefteriApp_Json_Linq
{
   public class Mesaj
    {
        public Mesaj()
        {

        }
        public Mesaj(string icerik)
        {
            Icerik = icerik;
        }

        public DateTime Zaman { get; set; } = DateTime.Now;
        public string Icerik { get; set; } 
        public bool YildizliMi { get; set; }

        public override string ToString()
        {
            string yildiz = YildizliMi ? "★" : "☆";

            string tarih = Zaman.Date == DateTime.Now.Date
                ? Zaman.ToString("HH:mm")
                : Zaman.ToString("dd.MM.yyyy HH:mm");
            return $"{yildiz}[{tarih}]{Icerik}";
        }


    }
}
