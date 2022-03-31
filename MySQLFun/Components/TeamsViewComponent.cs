using Microsoft.AspNetCore.Mvc;
using MySQLFun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLFun.Components
{
    public class TeamsViewComponent : ViewComponent
    {
        private IRepository repo { get; set; }

        public TeamsViewComponent (IRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.Teams = repo.Teams.ToList();

            //ViewBag.SelectedType = RouteData?.Values["teamName"];
            ViewBag.SelectedType = HttpContext.Request.Query["bowlerTeam"].ToString();

            var teams = repo.Bowlers
                .Select(x => x.Team.TeamName)
                .Distinct()
                .OrderBy(x => x);
            
            return View(teams);
        }
    }
}
