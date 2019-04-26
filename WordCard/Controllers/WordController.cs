using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordCard.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordCard.Controllers
{
    public class WordController : Controller{
        private IWordRepository repo;

        public WordController(IWordRepository r) {
            repo = r;
        }

        // GET: /<controller>/
        public ViewResult List()
        {
            return View(repo.Words);
        }
    }
}
