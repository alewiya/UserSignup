using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        //public List<User> users = new List<User>();
        //public IActionResult Index()

        public IActionResult Index(string userName="User") {

            ViewBag.UserName = userName;
            return View();
                //ViewBag.user = UserData.GetAll();
           
        }
        
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();

            return View(addUserViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User user1 = new User()
                {
                    UserName = addUserViewModel.UserName,
                    Email = addUserViewModel.Email,
                    Password = addUserViewModel.Password
                };
                return Redirect("Index?useName=" + user1.UserName);


            }
            return View(addUserViewModel);
        }
    }
}
