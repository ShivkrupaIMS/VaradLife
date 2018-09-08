
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.HsnsacRow))]
    public class HsnsacController : Controller
    {
        [Route("Masters/Hsnsac")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/Hsnsac/HsnsacIndex.cshtml");
        }
    }
}