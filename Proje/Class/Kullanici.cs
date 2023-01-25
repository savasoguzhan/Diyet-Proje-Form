using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Proje.Class
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AdSoyad { get; set; }
        public int Yas { get; set; }

        public double Kilo { get; set; }
        public double Boy { get; set; }
        public string Cinsiyet { get; set; }
        public int EgitmenId { get; set; }
        public Egitmen Egitmen { get; set; }
        public Admin Admin { get; set; }
        public List<Ogun> Ogunler { get; set; } = new();
        public override string ToString()
        {
            return UserName+Environment.NewLine + AdSoyad+ Environment.NewLine + Cinsiyet+Environment.NewLine +Yas+Environment.NewLine +EgitmenId;
        }

        
    }
}
