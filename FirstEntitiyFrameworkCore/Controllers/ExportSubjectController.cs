using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstEntityFrameworkCore.Entity.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify;
using FirstEntityFrameworkCore.Helper.Extension;
namespace FirstEntitiyFrameworkCore.Controllers
{
    public class ExportSubjectController : Controller
    {

        private IToastNotification toastNotification;

        public ExportSubjectController(IToastNotification toastNotification)
        {
            this.toastNotification = toastNotification;
        }

        public IActionResult exportSubject()
        {
           
            AddLessonModel model = TempData.MyGet<AddLessonModel>("model");

            if(model == null)
            {
                toastNotification.AddWarningToastMessage("Beklenmeyen Bir Hata Oluştu!");
                return View();
            }
           
            toastNotification.AddSuccessToastMessage("Ders Ve Konu Kayıtları Başarıyla Gerçekleşti!");
           
            return View(model);
        }
    }
}
