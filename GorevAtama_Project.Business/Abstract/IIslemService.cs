using GorevAtama_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Business.Abstract
{
    public interface IIslemService
    {
        Islem GetById(int id);
        List<Islem> GetAll();
        List<Islem> GetListAll();
        void Create(Islem entity);  
        void Update(Islem entity);
        void Delete(Islem entity);  
    }
}
