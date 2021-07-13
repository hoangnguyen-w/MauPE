using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PE.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PE.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly ProfessorDbContext _context;
        private IWebHostEnvironment _webHostEnvironment;

        public ProfessorController(ProfessorDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        // GET: ProfessorController
        public ActionResult Index()
        {
            return View(_context.professors.ToList());
        }

        // GET: ProfessorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfessorController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProfessorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Professor professor,IFormFile hinhanh)
        {
            try
            {
                if (hinhanh == null || hinhanh.Length == 0)
                {
                    //Trả về 1 chuỗi
                    return Content("Hình ảnh chưa được chọn");
                }
                else
                {
                    //Truyền hình ảnh
                    var path = Path.Combine(this._webHostEnvironment.WebRootPath, "Images", hinhanh.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    await hinhanh.CopyToAsync(stream);

                    professor.Photo = hinhanh.FileName;

                    //truyền data
                    _context.professors.Add(professor);
                    await _context.SaveChangesAsync();

                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return Content(ex.Message);
            }
        }

        // GET: ProfessorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfessorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfessorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfessorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
