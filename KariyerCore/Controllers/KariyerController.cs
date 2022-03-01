using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KariyerCore.Models;
using KariyerCore.Data;
using Microsoft.AspNetCore.Hosting;


namespace KariyerCore.Controllers
{
    public class KariyerController : Controller
    {
        private readonly KariyerDbContext _context;
        private readonly IWebHostEnvironment _webHost;

        public KariyerController(KariyerDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<BasvuruSahibi> applicants;
            applicants = _context.BasvuruSahibis.ToList();


            return View(applicants);
        }

        public IActionResult Create()
        {
            BasvuruSahibi basvuruSahibi = new BasvuruSahibi();
            return View(basvuruSahibi);

        }

        [HttpPost]
        public IActionResult Create(BasvuruSahibi basvuruSahibi)
        {
            _context.Add(basvuruSahibi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
