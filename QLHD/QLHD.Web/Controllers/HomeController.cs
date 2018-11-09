using QLHD.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLHD.Web.Controllers
{
    public class HomeController : Controller
    {
        private IdmhuongdanService _dmhuongdanService;

        public HomeController(IdmhuongdanService dmhuongdanService)
        {
            _dmhuongdanService = dmhuongdanService;
        }

        public ActionResult Index()
        {
            var listHD = _dmhuongdanService.GetAll().ToList();
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