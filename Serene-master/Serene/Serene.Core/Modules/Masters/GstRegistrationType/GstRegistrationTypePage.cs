
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.GstRegistrationTypeRow))]
    public class GstRegistrationTypeController : Controller
    {
        [Route("Masters/GstRegistrationType")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/GstRegistrationType/GstRegistrationTypeIndex.cshtml");
        }
    }
}