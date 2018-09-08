
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.CompanyRow))]
    public class CompanyController : Controller
    {
        [Route("Masters/Company")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/Company/CompanyIndex.cshtml");
        }
    }
}