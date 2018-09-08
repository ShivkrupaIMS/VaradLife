
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ManufacturerRow))]
    public class ManufacturerController : Controller
    {
        [Route("Masters/Manufacturer")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/Manufacturer/ManufacturerIndex.cshtml");
        }
    }
}