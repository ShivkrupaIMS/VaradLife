
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.SuppliersRow))]
    public class SuppliersController : Controller
    {
        [Route("Masters/Suppliers")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/Suppliers/SuppliersIndex.cshtml");
        }
    }
}