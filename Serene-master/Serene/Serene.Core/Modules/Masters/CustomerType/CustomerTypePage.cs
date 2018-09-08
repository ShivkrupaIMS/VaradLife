
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.CustomerTypeRow))]
    public class CustomerTypeController : Controller
    {
        [Route("Masters/CustomerType")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/CustomerType/CustomerTypeIndex.cshtml");
        }
    }
}