using GorevAtama_Project.Business.Abstract;
using GorevAtama_Project.Data.Abstract;
using GorevAtama_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama_Project.Business.Concrete
{
    public class IslemManager : IIslemService
    {
        private IIslemRepository _ıslemRepository;
        public IslemManager(IIslemRepository ıslemRepository)
        {
            _ıslemRepository = ıslemRepository;
        }

        public void Create(Islem entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Islem entity)
        {
            throw new NotImplementedException();
        }

        public List<Islem> GetAll()
        {
            return _ıslemRepository.GetAll();
        }

        public Islem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Islem> GetListAll()
        {
            return _ıslemRepository.GetListAll();
        }

        public void Update(Islem entity)
        {
            throw new NotImplementedException();
        }
    }
}
