
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.CityRow))]
    public class CityController : Controller
    {
        [Route("Masters/City")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/City/CityIndex.cshtml");
        }
    }
}