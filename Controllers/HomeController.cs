using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleBasesAuthorization.Models;
using Microsoft.AspNetCore.Authorization;
using RoleBasesAuthorization.Models;
using ASPNETMVCCRUD.Data;

namespace RoleBasedAuth.Controllers
{
    public class HomeController : Controller
    {
        private readonly MVCDemoDbContext _mvcDemoDbContext;
        private readonly object JsonRequestBehavior;

        public HomeController(MVCDemoDbContext mvcDemoDbContext)


        {
            this._mvcDemoDbContext = mvcDemoDbContext;
        }


        [Authorize(Roles = "Admin,User")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin,User")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [Authorize(Roles = "Admin,User")]
        public IActionResult Task()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult User()
        {
            var users = _mvcDemoDbContext.Users.ToList();
            return View(users);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(User model)
        {

            _mvcDemoDbContext.Add(model);
            _mvcDemoDbContext.SaveChanges();


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
