using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> __Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronomic = "Иванович", Age = 36 },
            new Employee { Id = 2, LastName = "Петров", FirstName = "Петр", Patronomic = "Петрович", Age = 25 },
            new Employee { Id = 3, LastName = "Сидоров", FirstName = "Сидор", Patronomic = "Сидорович", Age = 46 }
        };
        public IActionResult Index() => View();
        
        public IActionResult SecondAction()
        {
            return Content("Second controller action");
        }

        public IActionResult Employees()
        {
            return View(__Employees);
        }
    }
}
