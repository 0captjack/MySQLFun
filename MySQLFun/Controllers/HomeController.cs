using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySQLFun.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Controllers
{
    public class HomeController : Controller
    {
        private BowlersDbContext context { get; set; }
        public HomeController(BowlersDbContext temp)
        {
            context = temp;
        }
        public IActionResult Index()
        {
            var blah = context.Bowlers.ToList();
            
            return View(blah);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View(new Bowler());
        }
       [HttpPost]
       public IActionResult Add(Bowler b)
        {
            if (ModelState.IsValid)
            {
                context.Add(b);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(b);
            }
        }
        [HttpGet]
        public IActionResult Edit(int bowlerid)
        {
            var b = context.Bowlers.Single(x => x.BowlerID == bowlerid);

            return View("Edit", b);
        }
        [HttpPost]
        public IActionResult Edit(Bowler b)
        {
            context.Update(b);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete (Bowler b)
        {
            context.Remove(b);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
