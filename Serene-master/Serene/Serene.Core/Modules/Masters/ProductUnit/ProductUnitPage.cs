
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProductUnitRow))]
    public class ProductUnitController : Controller
    {
        [Route("Masters/ProductUnit")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/ProductUnit/ProductUnitIndex.cshtml");
        }
    }
}