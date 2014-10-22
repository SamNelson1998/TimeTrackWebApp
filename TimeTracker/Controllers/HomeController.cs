using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (SqlConnection connection = new SqlConnection("connection string"))
            {
                try
                {
                    connection.Open();

                }
                catch (Exception e)
                {

                }


            }



            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
