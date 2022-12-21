using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Entity
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public int RolID { get; set; }
        public Rol Rol { get; set; }
        public int IslemID { get; set; }
        public Islem Islem { get; set; }
    }
}
