﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstEntityFrameworkCore.Buisness.Manager;
using FirstEntityFrameworkCore.Entity.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FirstEntityFrameworkCore.DAC.Entities;
using FirstEntityFrameworkCore.Entity.ValidationControl;
using NToastNotify;

namespace FirstEntitiyFrameworkCore.Controllers
{
    public class InstructorController : Controller
    {
        private BranchManager branchManager = new BranchManager();
        private InstructorViewModel instructorViewModel = new InstructorViewModel();
        private InstructorManager ınstructorManager = new InstructorManager();
        private Branch_TeacherManager branch_TeacherManager = new Branch_TeacherManager();
        private LessonManager lessonManager = new LessonManager();
        private List<Teacher> instructorList;
        private IToastNotification toastNotification;
        
        public InstructorController(IToastNotification toastNotification)
        {
            this.toastNotification = toastNotification;
        }

        [HttpGet]
        public IActionResult Instructor()
        {

            branchManager.List().ForEach(x => instructorViewModel.selectList.Add(new SelectListItem(x.name,x.id.ToString())));
            instructorList = ınstructorManager.List();
            ViewBag.Instructor = instructorList;

            ViewBag.branchList = branch_TeacherManager.List();
            ViewBag.LessonList = lessonManager.List();

            return View(instructorViewModel);
        }

        [HttpPost]
        public IActionResult Instructor(InstructorViewModel model)
        {

            Validation<InstructorViewModel> instructorViewModel = new Validation<InstructorViewModel>();

            if (ModelState.IsValid)
            {
                if (model != null)
                {
                    instructorViewModel = ınstructorManager.Insert(model);

                    if (instructorViewModel.ErrorList.Count == 0)
                    {
                        toastNotification.AddSuccessToastMessage("Eğitmen Ekleme İşlemi Başarılı");
                        return RedirectToAction("Instructor");
                    }
                    else
                    {
                        instructorViewModel.ErrorList.ForEach(x => toastNotification.AddAlertToastMessage(x));
                        return RedirectToAction("Instructor");
                    }
                }
                else
                {
                    toastNotification.AddWarningToastMessage("Eğitmen Ekleme İşlemi Sırasında Bir Hata Meydana Geldi!");
                    return RedirectToAction("Instructor");
                }
            }
            else
            {
                ModelState.Values.ToList().ForEach(x => x.Errors.ToList().ForEach(y => toastNotification.AddWarningToastMessage(y.ErrorMessage)));
                return RedirectToAction("Instructor");

            }
        }


    }
}
