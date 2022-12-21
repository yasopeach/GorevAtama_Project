using GorevAtama_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Business.Abstract
{
    public interface IPersonelService
    {
        Personel GetById(int id);
        List<Personel> GetAll();
        List<Personel> GetListAll();
        void Create(Personel entity);
        void Update(Personel entity);
        void Delete(Personel entity);
    }
}
