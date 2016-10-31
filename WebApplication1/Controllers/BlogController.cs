using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            var db = new BlogDatabase();
            db.Database.CreateIfNotExists();
            var lst = db.BlogArticles.OrderByDescending(o =>o.Id).ToList();
            ViewBag.BlogArticles = lst;

            return View();
        }
        public ActionResult AddArticle()
        {
            return View();

        }
        public ActionResult ArticleSave(string subject,string body)
        {
            var article = new BlogArticle();
            article.Subject = subject;
            article.Body = body;
            article.DateCreated = DataTime.Now;
            var db = new BlogDatabase();
            db.BlogArticles.Add(article);
            return Redirect("Index");
        }
    }
}