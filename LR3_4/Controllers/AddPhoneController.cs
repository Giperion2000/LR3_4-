using LR3_4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LR3_4.Controllers
{
    public class AddPhoneController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        [HttpGet]
        public ActionResult AddPhone()
        {
            var phones = context.Phones;
            ViewBag.Phones = phones;

            var categories = context.Categories;
            ViewBag.Categories = categories;
            SelectList categoryp = new SelectList(context.Categories, "CategoryId", "CategoryName");
            ViewBag.Category = categoryp;
            //      ViewBag.ProductId = id;
            return View("AddPhone");
        }

        [HttpPost]
        public ActionResult AddPhone(Phone phone)
        {

            context.Phones.Add(phone);
            var category = context.Categories;


            context.SaveChanges();
            return RedirectToAction("AddPhone");
        }


        [HttpGet]
        public ActionResult EditP(int id)
        {
            var works = context.Phones;
            ViewBag.Works = works;

            var categories = context.Categories;
            ViewBag.Categories = categories;
            SelectList category = new SelectList(context.Categories, "CategoryId", "CategoryName");
            ViewBag.Category = category;

            Phone phone = context.Phones.Find(id);
            if (phone != null)
            {
                return View(phone);
            }

            return View("AddPhone");
        }

        [HttpPost]
        public ActionResult EditP(Phone phone)
        {
            context.Entry(phone).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("AddPhone");
        }
        [HttpGet]
        public ActionResult Deletep(int id)
        {
            var categories = context.Categories;
            ViewBag.Categories = categories;
            Phone phone = context.Phones.Find(id);
            if (phone != null)
            {
                context.Phones.Remove(phone);
                context.SaveChanges();
            }
            return RedirectToAction("AddPhone");
        }
    }
}