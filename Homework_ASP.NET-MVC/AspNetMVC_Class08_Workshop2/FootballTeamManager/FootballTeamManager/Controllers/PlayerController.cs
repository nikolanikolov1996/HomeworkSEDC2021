using FootballTeamManager.Enums;
using FootballTeamManager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballTeamManager.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult GetPlayerById(int id)
        {
            var player = new Player()
            {
                PlayerId = id,
                FirstName = "Bob",
                LastName = "Bobsky",
                Position = Position.Forward,
                Salary = 10000000.00
            };

            return View("ShowPlayer", player);
        }
    }
}
