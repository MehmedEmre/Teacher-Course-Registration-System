using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstEntityFrameworkCore.Buisness.Manager;
using FirstEntityFrameworkCore.Entity.ViewModel;
using FirstEntityFrameworkCore.Entity.ValidationControl;
using NToastNotify;
using FirstEntityFrameworkCore.DAC.Entities;

namespace FirstEntitiyFrameworkCore.Controllers
{
    public class LessonController : Controller
    {

        private LessonManager lessonManager = new LessonManager();
        private List<Lessons> lessonList = null;
        private IToastNotification toastNotification;


        public LessonController(IToastNotification toastNotification)
        {
            this.toastNotification = toastNotification;
        }

        [HttpGet]
        public IActionResult Lesson()
        {
            lessonList = lessonManager.List();
            ViewBag.Lessons = lessonList;                   
         
            return View();
        }

 
        [HttpPost]
        public IActionResult Lesson(LessonViewModel modelLesson)
        {
            Validation<LessonViewModel> lessonViewModel = new Validation<LessonViewModel>();

            if (ModelState.IsValid)
            {
                if (modelLesson != null)
                {
                    lessonViewModel = lessonManager.Insert(modelLesson);

                    if (lessonViewModel.ErrorList.Count == 0)
                    {
                        toastNotification.AddSuccessToastMessage("Ders Ekleme İşlemi Başarılı");
                        return RedirectToAction("Lesson");
                    }
                    else
                    {
                        lessonViewModel.ErrorList.ForEach(x => toastNotification.AddAlertToastMessage(x));
                        return RedirectToAction("Lesson");
                    }
                }
                else
                {
                    toastNotification.AddWarningToastMessage("Ders Ekleme İşlemi Sırasında Bir Hata Meydana Geldi!");
                    return RedirectToAction("Lesson");
                }
            }
            else
            {
                ModelState.Values.ToList().ForEach(x => x.Errors.ToList().ForEach(y => toastNotification.AddWarningToastMessage(y.ErrorMessage)));
                return RedirectToAction("Lesson");

            }

        }
     


        public JsonResult DeleteLesson(int? value)
        {
            if (value != null)
            {
                Lessons lesson = lessonManager.Find(x => x.id == value);

                if (lesson != null)
                {
                    int count = lessonManager.Remove(lesson);

                    if (count > 0)
                    {
                        toastNotification.AddSuccessToastMessage("Silme İşlemi Başarılı!");
                        return Json(new { state = true });
                    }
                    toastNotification.AddWarningToastMessage("Silme İşlemi Sırasında Bir Hata Meydana Geldi!!");
                    return Json(new { state = false });
                }
                toastNotification.AddWarningToastMessage("Silme İşlemi Sırasında Bir Hata Meydana Geldi!!");
                return Json(new { state = false });
            }
            toastNotification.AddWarningToastMessage("Silme İşlemi Sırasında Bir Hata Meydana Geldi!!");
            return Json(new { state = false });

        }


        public JsonResult Update(Lessons value)
        {
            if (value != null)
            {
                Lessons lesson = lessonManager.Find(x => x.id == value.id);

                if (lesson != null)
                {
                    lesson.name = value.name;
                    int count = lessonManager.Update(lesson);

                    if (count > 0)
                    {
                        lesson.ModifiedOn = DateTime.Now;
                        toastNotification.AddSuccessToastMessage("Güncelleme İşlemi Başarılı!");
                        return Json(new { state = true });
                    }
                    toastNotification.AddWarningToastMessage("Güncelleme İşlemi Sırasında Bir Hata Meydana Geldi!!");
                    return Json(new { state = false });
                }
                toastNotification.AddWarningToastMessage("Güncelleme İşlemi Sırasında Bir Hata Meydana Geldi!!");
                return Json(new { state = false });
            }
            toastNotification.AddWarningToastMessage("Güncelleme İşlemi Sırasında Bir Hata Meydana Geldi!!");
            return Json(new { state = false });
        }


    }
}
