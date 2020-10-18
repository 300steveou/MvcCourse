using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCourse.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        
        /// <summary>
        /// 新建test頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult Test()
        {
            ViewBag.Message = "Your Test page.";

            return View();
        }       
    }
}