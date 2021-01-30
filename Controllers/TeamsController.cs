using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers {
    [Route("[controller]")]
    public class TeamsController: Controller {
        private readonly string connString;
        public TeamsController(IConfiguration configuration) {
            connString = configuration.GetConnectionString("DefaultConnection");
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAllTeams() {
            using (FootballContext db = new FootballContext(connString)) {
                string path = "~/views/Teams/Teams.cshtml";
                List<Team> teams = (from t in db.Teams select t).ToList();
                return View(path, teams);
            }
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult TeamPage(int id) {
            using (FootballContext db = new FootballContext(connString)) {
                Team team = db.Teams.Find(id);
                return View(team);
            }
        }
    }
}
