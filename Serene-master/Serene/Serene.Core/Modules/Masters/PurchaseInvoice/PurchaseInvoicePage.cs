
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.PurchaseInvoiceRow))]
    public class PurchaseInvoiceController : Controller
    {
        [Route("Masters/PurchaseInvoice")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/PurchaseInvoice/PurchaseInvoiceIndex.cshtml");
        }
    }
}