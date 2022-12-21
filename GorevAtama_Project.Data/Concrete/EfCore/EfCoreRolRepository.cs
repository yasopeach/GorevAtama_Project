using GorevAtama_Project.Data.Abstract;
using GorevAtama_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Data.Concrete.EfCore
{
    public class EfCoreRolRepository : EfCoreGenericRepository<Rol, GorevAtama_ProjectContext>, IRolRepository
    {

    }
}
