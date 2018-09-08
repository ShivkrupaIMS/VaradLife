
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.InvoiceStatusRow))]
    public class InvoiceStatusController : Controller
    {
        [Route("Masters/InvoiceStatus")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/InvoiceStatus/InvoiceStatusIndex.cshtml");
        }
    }
}