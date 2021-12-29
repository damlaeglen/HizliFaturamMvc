using HizliFaturam.Models.dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HizliFaturam.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Header(string controller,string action)
        {
            header header = new header
            {
                Action = action,
                Controller = controller
            };
            return PartialView("partialView/Header", header);
        }
    }
}
