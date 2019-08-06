using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccessPolicyService<ChildOfBaseClass<BaseChildOfEntity>> _service;

        public HomeController(IAccessPolicyService<ChildOfBaseClass<BaseChildOfEntity>> service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            string b1 = _service.Policy.GetSuperFalse(new Child1OfEntity());
            string b2 = _service.Policy.GetSuperFalse(new Child2OfEntity());
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