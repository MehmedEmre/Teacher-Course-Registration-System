using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstEntityFrameworkCore.Buisness;
using FirstEntityFrameworkCore.DAC.Entities;
using FirstEntityFrameworkCore.Entity.ViewModel;
using FirstEntityFrameworkCore.Entity.ValidationControl;
using NToastNotify;

namespace FirstEntitiyFrameworkCore.Controllers
{
    public class HomeController : Controller
    {
        private  IToastNotification toastNotification;

        public HomeController(IToastNotification toastNotification)
        {
            this.toastNotification = toastNotification;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }


  


    }
}
