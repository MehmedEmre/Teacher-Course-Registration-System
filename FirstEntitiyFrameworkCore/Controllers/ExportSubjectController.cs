using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstEntityFrameworkCore.Entity.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify;
using FirstEntityFrameworkCore.Helper.Extension.Tempdata_Extension;
using Rotativa.AspNetCore;

namespace FirstEntitiyFrameworkCore.Controllers
{
    public class ExportSubjectController : Controller
    {

        private IToastNotification toastNotification;
        private static  AddLessonModel model;

        public ExportSubjectController(IToastNotification toastNotification)
        {
            this.toastNotification = toastNotification;
        }

        [HttpGet]
        public IActionResult exportSubject()
        {
           
            model = TempData.MyGet<AddLessonModel>("model");

            if(model == null)
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
            return new ViewAsPdf("exportSubject",model)
            {
                CustomSwitches = "--footer-center [page]"
            }; ;
        }


    }
}
