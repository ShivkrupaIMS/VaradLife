
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.CustomersRow))]
    public class CustomersController : Controller
    {
        [Route("Masters/Customers")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/Customers/CustomersIndex.cshtml");
        }
    }
}