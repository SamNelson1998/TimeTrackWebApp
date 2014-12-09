using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using TimeTracker.Models;

namespace TimeTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ew-db\\dev;Initial Catalog=TimeTracker;Integrated Security=True;User ID=UserName;Password=Password"))
            {
                try
                {
                    SqlConnection.ClearPool(connection);
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[User];", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.WriteLine(reader.GetValue(i));
                                }
                                Console.WriteLine();
                            }
                        }
                    }
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