using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HelloASPDotNET.Models;

namespace HelloASPDotNET.Controllers;

public class HelloController : Controller
{

        // GET: /Hello/Index
        public IActionResult Index()
        {
           string html = "<h1>" + "Hello World!" + "</h1>";
           return Content(html, "text/html");
        }

}
