using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        //public List<User> users = new List<User>();
        //public IActionResult Index()

        public IActionResult Index(string username = "User") {
            ViewBag.username = username;
            //ViewBag.user = UserData.GetAll();
            return View();
        }
        
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user,string verify)
        {
            if(user.UserName == null || user.UserName.Length < 5 && user.UserName.Length > 15)
            {
                ViewBag.error1 = "Please enter valid username which is greater than 5"
                return View();
            }
            else if (user.UserName.Any(char.IsDigit))
            {
                ViewBag.error2 = "Please enter valid username with out";
                return View();
            }
            else if ( user.Email == null)
            {
                return View();
            }

            if (user.Password != null && user.Password.Equals(verify))
            {

                

                //return View("Index");
                //i can use qaury parameter
                return Redirect("Index?username=" + user.UserName);
               
            }
            else
            {
                ViewBag.username = user.UserName;
                ViewBag.email = user.Email;
                ViewBag.error3 = "Please enter valid username and password";
                return View();
            }


            
             
             
            
           
                

    








        }
    }
}
