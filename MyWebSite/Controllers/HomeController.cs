using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite.Service;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyService _service;
         
        public HomeController(IMyService service)
        {
            _service = service;
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(_service.Entities1());
        }

    }
}
