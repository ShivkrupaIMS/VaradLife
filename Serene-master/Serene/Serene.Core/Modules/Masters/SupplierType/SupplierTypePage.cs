
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.SupplierTypeRow))]
    public class SupplierTypeController : Controller
    {
        [Route("Masters/SupplierType")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/SupplierType/SupplierTypeIndex.cshtml");
        }
    }
}