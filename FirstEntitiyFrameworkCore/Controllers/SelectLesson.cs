﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstEntityFrameworkCore.Buisness.Manager;
using FirstEntityFrameworkCore.DAC.Entities;
using FirstEntityFrameworkCore.Entity.ValidationControl;
using FirstEntityFrameworkCore.Entity.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using NToastNotify;
using FirstEntityFrameworkCore.Helper.Extension;

namespace FirstEntitiyFrameworkCore.Controllers
{
    public class SelectLesson : Controller
    {
        private InstructorManager instructorManager = new InstructorManager();
        private LessonManager lessonManager = new LessonManager();
        private BranchManager branchManager = new BranchManager();
        private Branch_TeacherManager branch_TeacherManager = new Branch_TeacherManager();
        private SubjectManager subjectManager = new SubjectManager();
        private List<Branch_Teacher> branch_TeacherList;
        private IToastNotification toastNotification;

        public SelectLesson(IToastNotification toastNotification)
        {
            this.toastNotification = toastNotification;
        }



        [HttpGet]
        public IActionResult selectLesson()
        {
            List<Teacher> model = instructorManager.List();

            return View(model);
        }

        [HttpPost]
        public IActionResult RegisteredLesson(int id)
        {
            Teacher teacher = instructorManager.Find(x => x.id == id);
            lessonManager.List();
            return View(teacher);
        }

        [HttpGet]
        public IActionResult addInstructorLesson(int id)
        {
            Teacher teacher = instructorManager.Find(x => x.id == id);
            branch_TeacherList = branch_TeacherManager.List().Where(x => x.TeacherId == id).ToList();


            AddLessonModel addLessonModel = new AddLessonModel();

            addLessonModel.TeacherId = id;
            addLessonModel.name = teacher.name;
            addLessonModel.surname = teacher.surname;
            lessonManager.List().Where(x=>x.isFull != true).ToList().ForEach(x => addLessonModel.selectListLesson.Add(new SelectListItem(x.name, x.id.ToString())));
            branch_TeacherList.ForEach(x => addLessonModel.selectListBranch.Add(new SelectListItem(x.branchName, x.id.ToString())));

            return View(addLessonModel);
        }

        [HttpPost]
        public IActionResult addInstructorLesson(AddLessonModel addLessonModel)
        {
             lessonManager.List().Where(x=>x.isFull != true).ToList().ForEach(x => addLessonModel.selectListLesson.Add(new SelectListItem(x.name, x.id.ToString())));
            branch_TeacherList = branch_TeacherManager.List().Where(x => x.TeacherId == addLessonModel.TeacherId).ToList();
            branch_TeacherList.ForEach(x => addLessonModel.selectListBranch.Add(new SelectListItem(x.branchName, x.id.ToString())));


            if (addLessonModel != null)
            {
                Validation<Subject> valid = subjectManager.Insert(addLessonModel);

                if(valid.ErrorList.Count == 0)
                {
                    Teacher teacher = instructorManager.List().Find(x => x.id == addLessonModel.TeacherId);
                    addLessonModel.name = teacher.name;
                    addLessonModel.surname = teacher.surname;

                    TempData.MyPut("model",addLessonModel);

                    return RedirectToAction("exportSubject", "ExportSubject");
                }
                else
                {
                    valid.ErrorList.ForEach(x => toastNotification.AddWarningToastMessage(x));
                    return RedirectToAction("addInstructorLesson", new { id = addLessonModel.TeacherId });
                }   
            }
            else
            {
                toastNotification.AddWarningToastMessage("Ders Ve Konu Ekleme İşlemi Sırasında Bir Hata Meydana Geldi!");
                return RedirectToAction("addInstructorLesson", new { id = addLessonModel.TeacherId });
            }


        }


    }
}