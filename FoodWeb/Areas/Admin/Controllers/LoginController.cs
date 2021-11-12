using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using FoodWeb.Model;
using FoodWeb.Common;
using Models.DAO;

namespace FoodWeb.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        
        public ActionResult Index(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, model.Password);
                if(result == 1)
                {
                    var user = dao.GetByID(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(Commonstants.USER_SESSION, userSession);
                    
                        return RedirectToAction("Index", "Dashboard");
                    
                }
                else if(result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại!");
                }
           
                else if (result == -1)
                {
                ModelState.AddModelError("", "Mật khẩu không đúng!");
                }
                else
                {
                ModelState.AddModelError("", "đăng nhập không đúng ");
                }
        }
            return View("Index");
        }

        // GET: Admin/Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
