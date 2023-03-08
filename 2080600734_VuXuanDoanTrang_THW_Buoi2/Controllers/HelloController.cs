using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2080600734_VuXuanDoanTrang_THW_Buoi2.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public string Index()
        {
            return "DOAN TRANG";
        }

        public ActionResult GetInfo(string school, string classname)
        {
            string name = "DOAN TRANG";
            ViewBag.GetName = name;
            ViewBag.GetSchool = school;
            ViewBag.GetClass = classname;
            return View();
        }
    }
}