using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers {
    [Route("[controller]")]
    public class StadiumsController: Controller {
        private readonly string connString;
        public StadiumsController(IConfiguration configuration) {
            connString = configuration.GetConnectionString("DefaultConnection");
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAllStadiums() {
            using (FootballContext db = new FootballContext(connString)) {
                string path = "~/views/Stadiums/Stadiums.cshtml";
                List<Stadium> stadiums = (from s in db.Stadiums select s).ToList();
                return View(path, stadiums);
            }
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult StadiumPage(int id) {
            using (FootballContext db = new FootballContext(connString)) {
                Stadium stadium = db.Stadiums.Find(id);
                return View(stadium);
            }
        }
    }
}
