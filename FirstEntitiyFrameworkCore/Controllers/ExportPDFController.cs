using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstEntityFrameworkCore.Entity.ViewModel;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using FirstEntityFrameworkCore.Helper.Extension.Tempdata_Extension;
using FirstEntityFrameworkCore.DAC.Entities;
using FirstEntityFrameworkCore.Buisness.Manager;
using Rotativa.AspNetCore;
using FirstEntitiyFrameworkCore.RedisCacheManagers.Abstract;

namespace FirstEntitiyFrameworkCore.Controllers
{
    public class ExportPDFController : Controller
    {

        private IToastNotification toastNotification;
        private static AddLessonModel model;
        private InstructorManager instructorManager = new InstructorManager();
        private LessonManager lessonManager = new LessonManager();
        private readonly IRedisCacheService _IRedisCacheService;

        public ExportPDFController(IToastNotification toastNotification, IRedisCacheService IRedisCacheService)
        {
            this.toastNotification = toastNotification;
            _IRedisCacheService = IRedisCacheService;
        }


        [HttpGet]
        public IActionResult exportSubject()
        {

            model = TempData.MyGet<AddLessonModel>("model");

            if (model == null)
            {
                toastNotification.AddWarningToastMessage("Beklenmeyen Bir Hata Oluştu!");
                return View();
            }

            toastNotification.AddSuccessToastMessage("Ders Ve Konu Kayıtları Başarıyla Gerçekleşti!");

            return View(model);
        }

        [HttpPost]
        [ActionName("exportSubject")]
        public IActionResult exportPdf()
        {
            return new ViewAsPdf("exportSubject", model)
            {
                CustomSwitches = "--footer-center [page]"
            }; ;
        }


        [HttpGet]
        public IActionResult exportMain()
        {
            List<Teacher> instructorList = _IRedisCacheService.GetInstructors();
            lessonManager.List();

            return View(instructorList);
        }

        [HttpPost]
        [ActionName("exportMain")]
        public IActionResult exportMainList()
        {
            List<Teacher> instructorList = _IRedisCacheService.GetInstructors();
            lessonManager.List();

            return new ViewAsPdf("exportMain", instructorList)
            {
                CustomSwitches = "--footer-center [page]"
            }; ;
        }


    }
}
