
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.CompanyTypeRow))]
    public class CompanyTypeController : Controller
    {
        [Route("Masters/CompanyType")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/CompanyType/CompanyTypeIndex.cshtml");
        }
    }
}