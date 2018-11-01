using System;
using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay
{
    public class TimeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}