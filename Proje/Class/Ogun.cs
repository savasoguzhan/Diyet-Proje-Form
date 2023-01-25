using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Proje.Class
{
    public class Ogun
    {
        public int Id { get; set; }
        public string Zaman { get; set; }        
        public List<Besin> Besinler { get; set; }
        public List<Kullanici> Kullanicilar { get; set; } = new();
        
    }
}
