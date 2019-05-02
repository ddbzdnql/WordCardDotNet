using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WordCard.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordCard.Controllers
{
    public class AdminController : Controller {
        public MyDbContext ctxt;
        public IWordRepository repo;
        // GET: /<controller>/
        public AdminController(IWordRepository r){
            ctxt = r.ctxt;
            repo = r;
        }

        public ViewResult Login() {
            return Display(); // not equipped to write or use an authorization middleware
        }

        public ViewResult Display() {
            ListView list = new ListView(ctxt);
            return View(repo);
        }

        [HttpDelete]
        public ViewResult Delete(Word modification){
            ctxt.Words.Remove(modification);
            ctxt.SaveChanges();
            return Display();
        }

        [HttpPost]
        public ViewResult Add(Word modification) {
            ctxt.Words.Add(modification);
            return Display();
        }

        public ViewResult Change(Word modification) {
            ctxt.Words.Update(modification);
            return Display();
        }
    }
}
