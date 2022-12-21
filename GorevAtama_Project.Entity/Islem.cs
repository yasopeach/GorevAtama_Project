using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Entity
{
    public class Islem
    {
        public int IslemID { get; set; }
        public string IslemAd { get; set; }
        public string IslemZorluk { get; set; }
        public List<Personel> Personels { get; set; }
    }
}
