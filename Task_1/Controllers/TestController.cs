﻿using Microsoft.AspNetCore.Mvc;

namespace Task_1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Message()
        {
            return View();
        }
    }
}
