
namespace Serene.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.MovieRow))]
    public class MovieController : Controller
    {
        [Route("Northwind/Movie")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/Movie/MovieIndex.cshtml");
        }
    }
}