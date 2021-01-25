using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using WebStore.Models;

namespace WebStore.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Catalog() => View();
    }
}
