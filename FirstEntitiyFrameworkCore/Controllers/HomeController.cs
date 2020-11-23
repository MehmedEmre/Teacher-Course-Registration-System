using FirstEntitiyFrameworkCore.RedisCacheManagers.Abstract;
using FirstEntityFrameworkCore.Buisness.Manager;
using FirstEntityFrameworkCore.DAC.Entities;
using FirstEntityFrameworkCore.Entity.ViewModel;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;

namespace FirstEntitiyFrameworkCore.Controllers
{
    public class HomeController : Controller
    {
        private IToastNotification toastNotification;
        private InstructorManager instructorManager = new InstructorManager();
        private LessonManager lessonManager = new LessonManager();
        private readonly IRedisCacheService _IRedisCacheService;

        public HomeController(IToastNotification toastNotification, IRedisCacheService IRedisCacheService)
        {
            this.toastNotification = toastNotification;
            _IRedisCacheService = IRedisCacheService;
        }

        [HttpGet]
        public IActionResult Index()
        {
           
            List<Lessons> instructorList = _IRedisCacheService.GetLessons();
    
            return View(instructorList);
        }





    }
}
