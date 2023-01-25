using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Proje.Class
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Kullanici Kullanici { get; set; }
        public int KullaniciId { get; set; }

    }
}