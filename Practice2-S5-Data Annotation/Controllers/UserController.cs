using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice2_S5_Data_Annotation.Models;

namespace Practice2_S5_Data_Annotation.Controllers
{
    public class UserController : Controller
    {
        private static List<User> _users = new List<User>()
        {
            new User("1", "Thai", "123123", "123123", "thai@gmail.com"),
            new User("2", "Thai2", "123123", "123123", "thai@gmail.com"),
            new User("3", "Thai3", "123123", "123123", "thai@gmail.com"),
        };

        // GET: User
        public ActionResult Index()
        {

            var model = _users;
            return View(model);
        }

        // GET: User details
        public ActionResult Details(string Id)
        {
            if (Id != null)
            {
                foreach (var user in _users)
                {
                    if (user.Id == Id)
                    {
                        return View(user);
                    }   
                }
            }
            return View();
        }

        
        public ActionResult Create()
        {
            User user = new User();
            return View("Create", user);
        }

        //POST: User
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                User model = new User();
                model.Id = user.Id;
                model.Name = user.Name;
                model.Email = user.Email;
                model.Password = user.Password;
                _users.Add(model);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(string Id)
        {
            if (Id != null)
            {
                foreach (var user in _users)
                {
                    if (user.Id == Id)
                    {
                        return View("Edit", user);
                    }
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                User model = new User();
                model.Id = user.Id;
                model.Name = user.Name;
                model.Email = user.Email;
                model.Password = user.Password;
                _users.Add(model);
                _users.Remove(user);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string Id)
        {
            if (Id != null)
            {
                foreach (var user in _users)
                {
                    if (user.Id == Id)
                    {
                        return View("Delete", user);
                    }
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult Delete(User user)
        {
            _users.Remove(user);
            return RedirectToAction("Index");
        }
    }
}