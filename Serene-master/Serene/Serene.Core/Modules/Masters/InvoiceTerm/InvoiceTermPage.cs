
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.InvoiceTermRow))]
    public class InvoiceTermController : Controller
    {
        [Route("Masters/InvoiceTerm")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/InvoiceTerm/InvoiceTermIndex.cshtml");
        }
    }
}