using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        private readonly IAccessPolicyService<BaseClass<BaseEntity>> _service;

        public TestController(IAccessPolicyService<BaseClass<BaseEntity>> service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            _service.Policy.GetFalse();
            return View();
        }
    }
}