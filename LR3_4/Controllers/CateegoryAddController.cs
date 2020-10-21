using LR3_4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LR3_4.Controllers
{
    public class CateegoryAddController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        [HttpGet]
        public ActionResult Create()
        {
            var categories = context.Categories;
            ViewBag.Categories = categories;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            var categories = context.Categories;
            ViewBag.Categories = categories;
            context.Entry(category).State = EntityState.Added;
            context.SaveChanges();

            return RedirectToAction("Create");
        }
        [HttpGet]
        public ActionResult Deletec(int id)
        {
            Category category= context.Categories.Find(id);
            if (category != null)
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
            return RedirectToAction("CateegoryAdd");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Category b = context.Categories.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Category b = context.Categories.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            context.Categories.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}