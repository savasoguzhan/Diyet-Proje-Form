using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Proje.Class
{
    public class Besin
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public decimal Kalori { get; set; }
        public decimal Miktar { get; set; }
        public int OgunId { get; set; }
        public Ogun Ogun { get; set; }

    }
}
