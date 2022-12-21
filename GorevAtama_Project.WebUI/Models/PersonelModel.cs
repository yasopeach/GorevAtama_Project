using GorevAtama_Project.Entity;
using System.Collections.Generic;

namespace GorevAtama_Project.WebUI.Models
{
    public class PersonelModel
    {
        public int PersonelID { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public List<Islem> SelectedIslem { get; set; }
    }
}
