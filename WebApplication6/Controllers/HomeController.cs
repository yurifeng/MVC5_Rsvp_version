using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using WebApplication6.Models;


namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ViewResult index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Message = hour < 12 ? "早上好.." : "下午好...";
            return View();
        }

        /// <summary>
        /// HttpGet提交(用户获取首次的页面是空白的)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        /// <summary>
        /// HttpPost提交(用户填完Form表单提交)
        /// </summary>
        /// <param name="gestresponse"></param>
        /// <returns></returns>
        [HttpPost]
        public ViewResult RsvpForm(Gestresponse gestresponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", gestresponse);
            }
            else
            {
                return View();
            }
        }
    }
}