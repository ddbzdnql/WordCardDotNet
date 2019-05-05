using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WordCard.Models;

namespace WordCard.Controllers
{
    public class AdminController : Controller
    {
        private readonly MyDbContext _context;
        private IWordRepository repo;
        private static string AddOrSave = "Add";
        private static int EditOrUpdate = -1;

        public AdminController(IWordRepository repository){
            repo = repository;
            _context = repository.ctxt;
        }

        // GET: Admin
        public IActionResult Display(){
            ViewBag.AddOrSave = AddOrSave;
            ViewBag.EditOrUpdate = EditOrUpdate;
            Console.WriteLine("EditOrUpdate: " + ViewBag.EditOrUpdate);
            ViewBag.List = repo;
            Console.Write("ViewBag: " + AddOrSave);
            return View();
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> Details(int? id){
            if (id == null)
            {
                return NotFound();
            }

            var word = await _context.Words
                .FirstOrDefaultAsync(m => m.Index == id);
            if (word == null)
            {
                return NotFound();
            }

            return View(word);
        }

        // GET: Admin/Create
        public IActionResult Create(){
            AddOrSave = "Save";
            Console.Write("ViewBag: " + AddOrSave);
            return RedirectToAction(nameof(Display));
        }

        [HttpPost]
        public async Task<IActionResult> Save([Bind("Name, Explanation, Index")]Word word){
            AddOrSave = "Add";
            Console.Write("Save called" + word==null);
            if (ModelState.IsValid) {
                _context.Add(word);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Display));
        }

        [HttpPost]
        public async Task<IActionResult> Update([Bind("Name, Explanation, Index")]Word word){
            if (ModelState.IsValid){
                Console.Write("Word Update: " + word.Index);
                _context.Words.Update(word);
                await _context.SaveChangesAsync();
            }

            EditOrUpdate = -1;
            return RedirectToAction(nameof(Display));
        }


        // GET: Admin/Edit/5
        public IActionResult Edit(int? id){
            EditOrUpdate = id ?? -1;
            return RedirectToAction(nameof(Display));
        }

        public IActionResult Cancel(){
            AddOrSave = "Add";
            EditOrUpdate = -1;
            return RedirectToAction(nameof(Display));
        }


        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {


            var word = _context.Words
                .FirstOrDefaultAsync(m => m.Index == id);

            Task<Word> w = _context.Words.FindAsync(id);
            _context.Remove(w.Result);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Display));
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var word = await _context.Words.FindAsync(id);
            _context.Words.Remove(word);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Display));
        }

        private bool WordExists(int id)
        {
            return _context.Words.Any(e => e.Index == id);
        }
    }
}
