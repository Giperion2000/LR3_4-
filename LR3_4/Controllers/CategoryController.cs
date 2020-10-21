using LR3_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LR3_4.Models;
using System.Data.Entity;
namespace LR3_4.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: CategoryP
        [HttpGet]
        public ActionResult Category(int? id)
        {

            ViewBag.Id = id;
            var categories = context.Categories;
            ViewBag.Categories = categories;
            var phones = context.Phones.Include(c => c.CN1);
            ViewBag.Phones = phones;




            if (id == null)
            {
                return HttpNotFound();
            }
            Category category1 = context.Categories.Include(t => t.Phones).FirstOrDefault(t => t.CategoryId == id);
            if (category1 == null)
            {
                return HttpNotFound();
            }

            return View(category1);

        }
    }
}