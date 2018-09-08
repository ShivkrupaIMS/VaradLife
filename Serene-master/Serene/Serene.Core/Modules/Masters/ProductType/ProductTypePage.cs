
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProductTypeRow))]
    public class ProductTypeController : Controller
    {
        [Route("Masters/ProductType")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/ProductType/ProductTypeIndex.cshtml");
        }
    }
}