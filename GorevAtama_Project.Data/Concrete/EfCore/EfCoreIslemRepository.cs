using GorevAtama_Project.Data.Abstract;
using GorevAtama_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Data.Concrete.EfCore
{
    public class EfCoreIslemRepository : EfCoreGenericRepository<Islem, GorevAtama_ProjectContext>, IIslemRepository
    {
        public List<Islem> GetListAll()
        {
            throw new NotImplementedException();
        }
    }
}
