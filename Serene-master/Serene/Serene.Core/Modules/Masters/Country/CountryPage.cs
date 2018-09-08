
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.CountryRow))]
    public class CountryController : Controller
    {
        [Route("Masters/Country")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/Country/CountryIndex.cshtml");
        }
    }
}