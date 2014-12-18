using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace TimeTracker.Controllers
{
    public class TimeDataController : Controller
    {
        public ActionResult Index()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ew-db\\dev;Initial Catalog=TimeTracker;Integrated Security=True;User ID=UserName;Password=Password"))
            {
                try
                {
                    SqlConnection.ClearPool(connection);
                    connection.Open();
                }
                
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return View();
        }
    }
}