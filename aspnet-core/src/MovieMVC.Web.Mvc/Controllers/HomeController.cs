using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MovieMVC.Controllers;

namespace MovieMVC.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MovieMVCControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
