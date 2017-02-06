using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860



    public class AutoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Ok("This is the auto page");
        }

        [Route("auto/quotes")]
        public IActionResult quotes()
        {

            return Ok("this is the quotes page");        
        }

    }

