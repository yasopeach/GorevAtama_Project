using GorevAtama_Project.Business.Abstract;
using GorevAtama_Project.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GorevAtama_Project.WebUI.Controllers
{
    public class PersonelController : Controller
    {
        private IPersonelService _personelService;
        private IIslemService _ıslemService;

        public PersonelController(IPersonelService personelService, IIslemService ıslemService)
        {
            _personelService = personelService;
            _ıslemService = ıslemService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PersonelList()
        {
            var values = _personelService.GetListAll();
            return View(values);
        }

        public IActionResult PersonelEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PersonelEkle(Personel personel)
        {
            int rnd1 = new Random().Next(1, 8);
            personel.RolID = rnd1;
            int rnd2 = new Random().Next(1, 8);
            personel.IslemID = rnd2;
            _personelService.Create(personel);
            return RedirectToAction("PersonelList", "Personel");
        }

        public IActionResult PersonelDuzenle(int id)
        {
            List<SelectListItem> value1 = (from x in _ıslemService.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.IslemAd,
                                               Value = x.IslemID.ToString()
                                           }).ToList();
            ViewBag.cv = value1;
            var value2 = _personelService.GetById(id);
            return View(value2);
        }

        [HttpPost]
        public IActionResult PersonelDuzenle(Personel personel)
        {
            var entity = _personelService.GetById(personel.PersonelID);
            entity.PersonelAd = personel.PersonelAd;
            entity.PersonelSoyad = personel.PersonelSoyad;
            entity.IslemID = personel.IslemID;
            _personelService.Update(entity);
            return RedirectToAction("PersonelList", "Personel");
        }

        public IActionResult PersonelSil(int id)
        {
            var entity = _personelService.GetById(id);
            _personelService.Delete(entity);
            return RedirectToAction("PersonelList", "Personel");
        }

        public IActionResult PersonelAta(Personel personel)
        {
            int rnd = new Random().Next(1, 8);
            personel.IslemID = rnd;
            ViewBag.v1 = rnd;
            var value = _personelService.GetListAll();
            return View(value);
        }
    }
}
