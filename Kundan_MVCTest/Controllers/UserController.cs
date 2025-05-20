using Kundan_MVCTest.DataAccess;
using Kundan_MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kundan_MVCTest.Controllers
{
    public class UserController : Controller
    {
        UserRepository repo = new UserRepository();
        // GET: User
        public ActionResult Index(string searchFirstName="",string serachEmail="")
        {
            List<UserModel> users = repo.GetUsers(searchFirstName,serachEmail);  
            return View(users);
        }
    }
}