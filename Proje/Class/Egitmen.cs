using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Proje.Class
{
    public class Egitmen
    {
        public int Id { get; set; }
        public string Adı { get; set; }
        public string Soyad { get; set; }        
        public List<Kullanici> Kullanicilar { get; set; }


    }
}
