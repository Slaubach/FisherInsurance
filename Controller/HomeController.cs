﻿
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860



    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Ok("this is the index of the Homecontroller");
        }
    }

