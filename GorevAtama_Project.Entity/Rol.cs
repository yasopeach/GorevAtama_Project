using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Entity
{
    public class Rol
    {
        public int RolID { get; set; }
        public string RolAd { get; set; }
        public List<Personel> Personels { get; set; }
    }
}
