using System.Web.Mvc;

namespace fernandez.northwind.Web.Controllers
{
    public class AboutController : northwindControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}