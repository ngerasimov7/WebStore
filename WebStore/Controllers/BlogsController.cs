using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using WebStore.Models;

namespace WebStore.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Blog() => View();
        public IActionResult BlogSingle() => View();
    }
}
