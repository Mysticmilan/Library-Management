using Library_Management.Data;
using Library_Management.Filters;
using Library_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Library_Management.Controllers
{
    [ServiceFilter(typeof(AdminAuthorizeFilter))]
    public class NoticeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public NoticeController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var notics = _context.Notices.Where(x => x.Status == true).ToList();
            return View(notics);
        }

        //Get for ADD New Data
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //Post for ADD New Data
        [HttpPost]
        public IActionResult Create(Notice notice)
        {
            Notice value = new Notice();
            value.Title = notice.Title;
            value.ValidFrom = notice.ValidFrom;
            value.ValidUntil = notice.ValidUntil;
            value.Details = notice.Details;
            value.Status = true;
            _context.Notices.Add(value);
            _context.SaveChanges();
            return RedirectToAction("Index", "Notice");

        }

        //Post for Delete
        //Or use Post Method for using the Form Method
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Notice value = _context.Notices.Find(id);
            value.Status = false;
            _context.SaveChanges();
            return RedirectToAction("Index", "Notice");
        }

        //GET for Edit Data
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Notice notice = _context.Notices.Where(x => x.Id == id).First();
            return View(notice);
        }

        //Post for Edit Data
        [HttpPost]
        public IActionResult Edit(Notice notice, int id)
        {
            Notice value = _context.Notices.Find(id);
            value.Title= notice.Title;
            value.ValidFrom = notice.ValidFrom;
            value.ValidUntil = notice.ValidUntil;
            value.Details= notice.Details;
            value.Status = true;
            _context.SaveChanges();
            return RedirectToAction("Index", "Notice");

        }
    }
}
