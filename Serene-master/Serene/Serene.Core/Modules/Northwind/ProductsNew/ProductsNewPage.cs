
namespace Serene.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.ProductsNewRow))]
    public class ProductsNewController : Controller
    {
        [Route("Northwind/ProductsNew")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/ProductsNew/ProductsNewIndex.cshtml");
        }
    }
}