
namespace Serene.Masters.Pages
{
    using Serenity;
    using Serenity.Web;
    using Microsoft.AspNetCore.Mvc;

    [PageAuthorize(typeof(Entities.StateRow))]
    public class StateController : Controller
    {
        [Route("Masters/State")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/State/StateIndex.cshtml");
        }
    }
}