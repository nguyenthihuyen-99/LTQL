using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL_quanlythuvien.Controllers
{
    public class HomeController : Controller
    {

        [AllowAnonymous]//truy cập ko cần kiểm tra đăng nhập
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]//truy cập cần kiểm tra trc khi đăng nhập
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}