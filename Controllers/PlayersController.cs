using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers {
    [Route("[controller]")]
    public class PlayersController: Controller {
        private readonly string connString;
        public PlayersController(IConfiguration configuration) {
            connString = configuration.GetConnectionString("DefaultConnection");
        }
        [HttpGet]
        [Route("")]
        [Route("List/{team_id?}")]
        [Route("~/")]
        public IActionResult GetAllPlayers(int? team_id) {
            using (FootballContext db = new FootballContext(connString)) {
                string path = "~/views/Players/Players.cshtml";
                List<Player> players;
                if (team_id.HasValue) {
                    players = (from p in db.Players
                               where p.TeamId == team_id.Value
                               select p).ToList(); ;
                }
                else {
                    players = (from p in db.Players select p).ToList();
                }
                return View(path, players);
            }
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult PlayerPage(int id) {
            using (FootballContext db = new FootballContext(connString)) {
                Player player = db.Players.Find(id);
                return View(player);
            }
        }
    }
}
