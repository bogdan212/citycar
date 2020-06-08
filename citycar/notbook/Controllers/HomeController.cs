using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using notbook.Models;

namespace notbook.Controllers
{
    public class HomeController : Controller
    {
        NotebookContext db;
        //конструктор подключния на главную страницу
        public HomeController(NotebookContext context)
        {
            db = context;
        }

        //редактирование
        [HttpGet]
        public ActionResult EditBook(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("index");
            }
            Order person = db.People.Find(id);
            if (person != null)
            {
                return View(person);
            }
            return RedirectToAction("index");




        }
        [HttpPost]
        public ActionResult EditBook(Order person)
        {
            db.Entry(person).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        // добавление или создание


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Order person)
        {
            db.People.Add(person);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        //для user

      



        public IActionResult Index()
        {
            return View(db.People.ToList());

        }

        //куки
       

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return RedirectToAction("index");

            Order person = db.People.Find(id);

            if (person != null)
                return View(person);

            return RedirectToAction("index");

        }

        public IActionResult Statss(int? id)
        {
            if (id == null)
                return RedirectToAction("index");

            Order person = db.People.Find(id);

            if (person != null)
                return View(person);

            return RedirectToAction("index");

            
        }

        public IActionResult Editing(int? id)
        {
            if (id == null)
                return RedirectToAction("index");

            Order person = db.People.Find(id);

            if (person != null)
                return View(person);

            return RedirectToAction("index");


        }

     






        public IActionResult Search(string searchText)
        {
            var people = db.People.Where(p=> p.Secondname.Contains(searchText)
            || p.Firstname.Contains(searchText)).ToList();

            return View("index" ,people);

        }

        //
        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}
       // [HttpPost]
        //public ActionResult Create(People people)
        //{
         //   db.People.Add(people);
         //   db.SaveChanges();

         //   return RedirectToAction("Index");
       // }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
