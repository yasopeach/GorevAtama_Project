using GorevAtama_Project.Data.Abstract;
using GorevAtama_Project.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Data.Concrete.EfCore
{
    public class EfCorePersonelRepository : EfCoreGenericRepository<Personel, GorevAtama_ProjectContext>, IPersonelRepository
    {
        public List<Personel> GetListAll()
        {
            using (var context = new GorevAtama_ProjectContext())
            {
                return context.Personels.Include(x => x.Islem).ToList();
            }
        }
    }
}
