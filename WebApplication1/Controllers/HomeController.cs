using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
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
        public ActionResult bbq()
        {
            int a = 100;
            int sum = 0;
            for (int i=1; i<=a;i++)
            {
                sum += i;
            }
            ViewBag.sum = sum;
            return View();

        }
        /// <summary>
        /// 新闻列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List(int page=1)
        {
            string[] data = new string[] {"神十一与天宫对接成功 航天员“入宫”",
                "深度：中国四年内已建造13艘052D舰 背后有3大玄机",
                "深度：中国新武器3小时绕地球1圈 美要中方公开进展",
                "油价上调在即 业界预计每吨300元 加一箱多15至20元"};

            ViewBag.data = data;
            ViewBag.Page = page;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}