
namespace Serene.Northwind.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.PersonRow))]
    public class PersonController : Controller
    {
        [Route("Northwind/Person")]
        public ActionResult Index()
        {
            return View("~/Modules/Northwind/Person/PersonIndex.cshtml");
        }
    }
}