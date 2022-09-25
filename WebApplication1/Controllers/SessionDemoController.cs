using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.ExtentionMethods;

namespace WebApplication1.Controllers
{
    public class SessionDemoController : Controller
    {
        public string Index()
        {
            HttpContext.Session.SetInt32("age", 25);
            HttpContext.Session.SetString("name", "Admin");

            HttpContext.Session.SetObject("user", new Student
            {
                Email = "leyla@gmail.com",
                Firstname = "Leyla",
                Lastname = "Mammadova",
                Id = 1
            });


            return "Session created";
        }

        public string GetSessions()
        {
            return $"Name {HttpContext.Session.GetString("name")}" +
                $"Age {HttpContext.Session.GetInt32("age")}";
        }
        public JsonResult GetStudent()
        {
            var student=(HttpContext.Session.GetObject<Student>("user"));
            return Json(student);
        }
    }
}
