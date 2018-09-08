
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.LicenseTypeRow))]
    public class LicenseTypeController : Controller
    {
        [Route("Masters/LicenseType")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/LicenseType/LicenseTypeIndex.cshtml");
        }
    }
}