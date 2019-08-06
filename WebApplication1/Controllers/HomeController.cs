using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccessPolicyService<BaseClass<BaseEntity>> _service;

        public HomeController(IAccessPolicyService<BaseClass<BaseEntity>> service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            bool b = _service.Policy.GetFalse();
            return View();
        }

        public ActionResult About()
        {

            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}