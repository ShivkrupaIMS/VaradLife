
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProductRow))]
    public class ProductController : Controller
    {
        [Route("Masters/Product")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/Product/ProductIndex.cshtml");
        }
    }
}