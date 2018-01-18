using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace fernandez.northwind.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : northwindControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}