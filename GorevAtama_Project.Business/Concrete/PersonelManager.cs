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
    public class PersonelManager : IPersonelService
    {
        //private IPersonelService _personelService;
        //public PersonelManager(IPersonelService personelService)
        //{
        //    _personelService = personelService;
        //}

        private IPersonelRepository _personelRepository;

        public PersonelManager(IPersonelRepository personelRepository)
        {
            _personelRepository = personelRepository;
        }

        public void Create(Personel entity)
        {
            _personelRepository.Create(entity);
        }

        public void Delete(Personel entity)
        {
            _personelRepository.Delete(entity);
        }

        public List<Personel> GetAll()
        {
            return _personelRepository.GetAll();
        }

        public Personel GetById(int id)
        {
            return _personelRepository.GetById(id);
        }

        public List<Personel> GetListAll()
        {
            return _personelRepository.GetListAll();
        }

        public void Update(Personel entity)
        {
            _personelRepository.Update(entity);
        }
    }
}
