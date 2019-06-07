using JsonAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonAjax.Controllers
{
    public class HomeController : Controller
    {
        public static Student[] stdList ={
            new Student("Hamza","BSE163079",3.54),
            new Student("Rawal","BSE163043",3.41),
            new Student("Shehzad","BSE163032",3.22),
            new Student("Ali","BSE163029",3.21),
            new Student("Qasim","BSE163011",3.88),
        };

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetStudentsData()
        {
            return Json(stdList);
        }
        [HttpPost]
        public JsonResult AddStudent(string name,string reg,double cgpa)
        {
            stdList[0].StudentName = name;
            stdList[0].StudentRegNo = reg;
            stdList[0].StudentCGPA = cgpa;
            return Json(stdList.ToList());
        }
    }
}