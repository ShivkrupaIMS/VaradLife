
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.PurchaseInvoiceDetailsRow))]
    public class PurchaseInvoiceDetailsController : Controller
    {
        [Route("Masters/PurchaseInvoiceDetails")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/PurchaseInvoiceDetails/PurchaseInvoiceDetailsIndex.cshtml");
        }
    }
}