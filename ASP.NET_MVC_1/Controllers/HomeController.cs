using ASP.NET_MVC_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_1.Controllers
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

        public ActionResult Info()
        {
            var p = new Person()
            {
                Id = 98,
                Name = "xpy0928",
                BlogAddress = "http://www.cnblogs.com/CreateMyself",
                Description = "出生非贫即贵，你我无能为力，后天若不加以努力赶之超之，又能怪谁呢！自己都靠不住不靠谱，又能靠谁呢！"
            };
            //TODO 添加Person到数据库中
            TempData["info"] = "提示：已经成功添加一条数据到数据库中";
            return RedirectToAction("TempDataObject");
        }


        public ActionResult TempDataObject()
        {
            return View();
        }
    }
}