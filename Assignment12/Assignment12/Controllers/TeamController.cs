using Assignment12.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Assignment12.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        static List<Team> ListTeams = new List<Team>()
        {
            new Team(){TeamId=1,TeamName="India",NOWC=3},
            new Team(){TeamId=2,TeamName="Australia",NOWC=4},
            new Team(){TeamId=3,TeamName="West Indies",NOWC=2},
            new Team(){TeamId=4,TeamName="England",NOWC=1}
        };

        public ActionResult Index()
        {

            return View(ListTeams);
        }
    }
}