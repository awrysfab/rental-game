    using game_rental.DAL;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;

namespace game_rental.Controllers
{
    public class HomeController : Controller
    {
        private GameRentalContext db = new GameRentalContext();
        public ActionResult Index()
        {
            ViewBag.RenterID = new SelectList(db.Renters, "ID", "Name");
            var games = db.Games.Include(g => g.Genre);
            return View(games.ToList());
        }
        public ActionResult Cart()
        {
            return View();
        }
    }
}