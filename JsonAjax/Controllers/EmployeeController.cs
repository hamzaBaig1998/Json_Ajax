using JsonAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonAjax.Controllers
{
    public class EmployeeController : Controller
    {
        public static Employee[] empList =
        {
            new Employee("Ahmad",20),
            new Employee("Ali",23),
            new Employee("Faheem",30),
            new Employee("Iqra",20),
        };
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetEmployees()
        {
            return Json(empList);
        }
    }
}