using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework01.Controllers
{
    public class UserController : Controller
    {
        //GetUser action
        [HttpGet("/User")]
        public IActionResult GetUser()
        {
            return View("User");
        }

        //GetContact action
        public IActionResult GetContact()
        {
            return RedirectToAction("Admin", "Admin");
        }
        
        //GetEmpty action
        [HttpGet("/Empty")]
        public IActionResult GetEmpty()
        {
            return new EmptyResult();
        }

        //GetId action
        [HttpGet("/Id/{id}")]
        public IActionResult GetId(int id)
        {
            if (id != 0)
            {
                return View("UserId");
            }

            return new EmptyResult();
        }


    }
}
