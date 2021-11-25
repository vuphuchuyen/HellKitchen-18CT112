using FoodWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodWeb.Controllers
{
    public class CategoryFoodController : Controller
    {
        // GET: CategoryFood
        public ActionResult Index()
        {
            string err = string.Empty;
            var categories = new CategoryFoodDb().GetCategories(ref err);
            return View(categories);
        }

        // GET: CategoryFood/Details/5
        public ActionResult Details(int id)
        {
            string err = string.Empty;
            //  var category = new CategoryDb().GetCategoryByID(ref err, id);
            var categories = new CategoryFoodDb().GetCategories(ref err);
            var category = categories.SingleOrDefault(x => x.ID == id);
            if (category != null)
                return View(category);
            else
            {
                if (!string.IsNullOrEmpty(err))
                    ViewBag.err = string.Format("Lỗi: {0}", err);
                else
                {
                    ViewBag.err = "Không có giá trị";
                }
                return View();
            }
        }

        // GET: CategoryFood/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryFood/Create
        [HttpPost]
        public ActionResult Create(CategoryFood collection)
        {
            try
            {
                // TODO: Add insert logic here
                string err = string.Empty;
                int rows = 0;
                var result = new CategoryFoodDb().InsertCategory(ref err, ref rows, collection);



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        string err = string.Empty;
        int rows = 0;
        // GET: CategoryFood/Edit/5
        public ActionResult Edit(int id)
        {
            var category = new CategoryFoodDb().GetCategoryByID(ref err, id);
            return View(category);
        }

        // POST: CategoryFood/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CategoryFood collection)
        {
            try
            {
                // TODO: Add update logic here
                var result = new CategoryFoodDb().UpdateCategory(ref err, ref rows, collection);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryFood/Delete/5
        public ActionResult Delete(int id)
        {
            var category = new CategoryFoodDb().GetCategoryByID(ref err, id);
            return View(category);
        }

        // POST: CategoryFood/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CategoryFood collection)
        {
            try
            {
                // TODO: Add delete logic here
                var result = new CategoryFoodDb().DeleteCategoryByID(ref err, ref rows, collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
