using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ProfessorDbContext _context;

        public DepartmentController(ProfessorDbContext context)
        {
            _context = context;
        }
        // GET: DepartmentController
        public ActionResult Index()
        {
            return View(_context.departments.ToList());
        }

        // GET: DepartmentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection, Department department)
        {
            try
            {
                _context.departments.Add(department);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                
                return Content(ex.InnerException.Message);
            }
        }

        // GET: DepartmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepartmentController/Edit/5
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

        // GET: DepartmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepartmentController/Delete/5
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
