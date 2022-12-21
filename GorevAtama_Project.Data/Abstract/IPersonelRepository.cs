using GorevAtama_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Data.Abstract
{
    public interface IPersonelRepository : IRepository<Personel>
    {
        List<Personel> GetListAll();
    }
}
