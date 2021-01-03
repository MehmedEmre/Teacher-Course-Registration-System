using System;
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
using FirstEntitiyFrameworkCore.RedisCacheManagers.Abstract;
using Newtonsoft.Json;
using FirstEntityFrameworkCore.Helper.Extension.String_Extension;

namespace FirstEntitiyFrameworkCore.Controllers
{
    public class InstructorController : Controller
    {
        private BranchManager branchManager = new BranchManager();
        private InstructorViewModel instructorViewModel = new InstructorViewModel();
        private EditInstructorModel editInstructorViewModel = new EditInstructorModel();
        private InstructorManager ınstructorManager = new InstructorManager();
        private Branch_TeacherManager branch_TeacherManager = new Branch_TeacherManager();
        private LessonManager lessonManager = new LessonManager();
        private List<Teacher> instructorList;
        private IToastNotification toastNotification;
        private readonly IRedisCacheService _IRedisCacheService;

        public InstructorController(IToastNotification toastNotification, IRedisCacheService IRedisCacheService)
        {
            this.toastNotification = toastNotification;
            _IRedisCacheService = IRedisCacheService;
        }

        [HttpGet]
        public IActionResult Instructor()
        {

            _IRedisCacheService.GetBranchs().ForEach(x => instructorViewModel.selectList.Add(new SelectListItem(x.name,x.id.ToString())));
            instructorList = _IRedisCacheService.GetInstructors();
            ViewBag.Instructor = instructorList;

            ViewBag.branchList = branch_TeacherManager.List();
            ViewBag.LessonList = _IRedisCacheService.GetLessons();

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
                        _IRedisCacheService.GetAllRemove();
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

        public IActionResult EditInstructor(int id)
        {
            Teacher teacher = ınstructorManager.Find(x => x.id == id);
            int empty = 0;
            int leave = -1;

            List<Branch_Teacher> instructorBrachList = branch_TeacherManager.List(x => x.teacherid == id);
    
                for (int i = 0; i < instructorBrachList.Count; i++)
                {
                    List<SelectListItem> branchlist = new List<SelectListItem>();
                    List<SelectListItem> lessonlist = new List<SelectListItem>();
                   
                    branchlist.Add(new SelectListItem(instructorBrachList[i].branchName, instructorBrachList[i].branchid.ToString()));
                    branchlist.Add(new SelectListItem("Branşı Bırak", leave.ToString()));

                    Lessons lesson = lessonManager.Find(x=> x.ownerBranch.Equals(instructorBrachList[i].branchName) && x.teacherid == instructorBrachList[i].teacherid);

                    if(lesson != null)
                    {

                    lessonlist.Add(new SelectListItem(lesson.name, lesson.id.ToString()));

                    }
                    else
                    {

                    lessonlist.Add(new SelectListItem("Ders Seçilmedi", empty.ToString()));

                    }

                    editInstructorViewModel.branchKeys.Add(branchlist);
                    editInstructorViewModel.lessonKeys.Add(lessonlist);
                }


                editInstructorViewModel.name = teacher.name;
                editInstructorViewModel.surname = teacher.surname;
                editInstructorViewModel.branchValues = new int[instructorBrachList.Count];
                editInstructorViewModel.lessonValues = new int[instructorBrachList.Count];
                editInstructorViewModel.Id = id;

            return View(editInstructorViewModel);    
    
        }

        [HttpPost]
        public JsonResult SetInstructorProperty(int lessonId)
        {
            List<SelectListItem> selectListLesson = new List<SelectListItem>();

            List<Lessons> lessonList = lessonManager.List(x => !x.isFull).ToList();//Cache'den çekersen JsonIgnore Çalışmıyor

            Lessons lesson = lessonManager.Find(x => x.id == lessonId);


            int empty = 0;


            if(lessonId == 0) //Ders Seçilmediyse
            {
                selectListLesson.Add(new SelectListItem("Ders Seçilmedi", empty.ToString()));

                for (int i = 0; i < lessonList.Count; i++)
                {
                    selectListLesson.Add(new SelectListItem(lessonList[i].name, lessonList[i].id.ToString()));
                }
            }
            else
            {
                selectListLesson.Add(new SelectListItem(lesson.name, lesson.id.ToString()));

                for (int i = 0; i < lessonList.Count; i++)
                {
                    selectListLesson.Add(new SelectListItem(lessonList[i].name, lessonList[i].id.ToString()));
                }
                
                selectListLesson.Add(new SelectListItem("Ders Seçilmedi", empty.ToString()));
            }

            return Json(new { lessonList = selectListLesson });
        }

        [HttpPost]
        public JsonResult ChangeInstructorProperty(int newBranchId,int branchId, int lessonId,int newLessonId , int teacherId)
        {
            Teacher teacher = _IRedisCacheService.GetInstructors().Find(x => x.id == teacherId);

            int value = 0;
        

                if (newLessonId != lessonId) //Eğer değişiklik yapılmışsa
                {

                    Branch branch = _IRedisCacheService.GetBranchs().Find(x => x.id == branchId);


                    if (lessonId == 0)//Önceden bu branşa ait ders yoksa yeni dersi direk ekleriz
                    {
                        Lessons newLesson = lessonManager.List().Find(x => x.id == newLessonId);

                        newLesson.ownerBranch = branch.name;
                        newLesson.branchid = branch.id;
                        newLesson.isFull = true;
                        newLesson.teacherid = teacher.id;
                        newLesson.ownerTeacherName = teacher.name;
                        newLesson.ownerTeacherSurname = teacher.surname;
                        newLesson.teacher = teacher;
                        value = lessonManager.Update(newLesson);

                    }
                    else //Önceden bu branşa ait ders varsa önce o dersi sıfırlarız
                    {
                        Lessons lesson = lessonManager.List().Find(x => x.id == lessonId); //Önceki dersi buluruz ve değerlerini null'a çekeriz.

                        lesson.ownerBranch = null;
                        lesson.branchid = null;
                        lesson.isFull = false;
                        lesson.teacherid = null;
                        lesson.ownerTeacherName = null;
                        lesson.ownerTeacherSurname = null;
                        lesson.teacher = null;
                        value = lessonManager.Update(lesson);


                        if (newLessonId != 0)//Yeni bir ders seçildiyse eklenir. Eğer herhangi birşey seçilmediyse birşey yapılmaz.
                        {
                            Lessons newLesson = lessonManager.List().Find(x => x.id == newLessonId); // yeni ders eklenir

                            newLesson.ownerBranch = branch.name;
                            newLesson.branchid = branch.id;
                            newLesson.isFull = true;
                            newLesson.teacherid = teacher.id;
                            newLesson.ownerTeacherName = teacher.name;
                            newLesson.ownerTeacherSurname = teacher.surname;
                            newLesson.teacher = teacher;
                            value = lessonManager.Update(lesson);

                        }
                    }

                    if (value > 0)
                    {
                        _IRedisCacheService.GetAllRemove();
                        toastNotification.AddSuccessToastMessage("Yeni Ders Kayıtı Başarıyla Gerçekleşti!");
                    }
                    else
                    {
                        toastNotification.AddWarningToastMessage("Kayıt Esnasında Bir Hata Meydana Geldi!");
                    }
                }

                if (newBranchId == -1)
                {

                    int value2 = 0;

                    Branch_Teacher branch_Teacher = branch_TeacherManager.Find(x => x.branchid == branchId && x.teacherid == teacherId);

                    value2 = branch_TeacherManager.Remove(branch_Teacher);

                    if(lessonId != 0) {
                        Lessons lesson = lessonManager.Find(x => x.id == lessonId);

                        lesson.ownerBranch = null;
                        lesson.branchid = null;
                        lesson.isFull = false;
                        lesson.teacherid = null;
                        lesson.ownerTeacherName = null;
                        lesson.ownerTeacherSurname = null;
                        lesson.teacher = null;

                        lessonManager.Update(lesson);
                }        

                    if (value2 > 0)
                    {
                        toastNotification.AddSuccessToastMessage("Branş Başarıyla Silindi!");
                    }

                    return Json(new { state = true });
                }
                else
                {
                    return Json(new { state = false });
                }
        }

        [HttpPost]
        public JsonResult ChangeNameProperty(string name,string surname,int id)
        {
            int val = 0;

            Teacher teacher = ınstructorManager.Find(x => x.id == id);

            teacher.name = name;
            teacher.surname = surname;

            val = ınstructorManager.Update(teacher);

            if(val > 0 || teacher.name.MyFirstLetterCapital().Equals(name.MyFirstLetterCapital()) && teacher.surname.MyFirstLetterCapital().Equals(surname.MyFirstLetterCapital()))
            {
                toastNotification.AddSuccessToastMessage("Değişiklikler Başarıyla Kayıt Edildi!");

                return Json(new { state = true , name = name , surname = surname});
            }
            else
            {
                toastNotification.AddWarningToastMessage("İsim Ve Soyisim'i Güncellerken Bir Hata Meydana Geldi!");

                return Json(new { state = false});
            }
            
        }

        public JsonResult EndBranch(int teacherId,int val)
        {
            List<Branch_Teacher> branch_TeacherList = branch_TeacherManager.List(x => x.teacherid == teacherId);

            if (branch_TeacherList.Count == 1)
            {

                if(val == -1)
                {
                    toastNotification.AddWarningToastMessage("Bir Eğitmene ait en az bir branş olmalıdır!");
                }
                

                return Json(new { state = true });
            }

            return Json(new{ state = false });
        }



        public JsonResult warningMessage()
        {

            toastNotification.AddInfoToastMessage("Lütfen Devam Etmekte Olan İşlemi Kayıt Ediniz.");

            return Json(new { state = true });
        }


        public JsonResult Delete(int? id)
        {

            if(id != null)
            {
                Teacher instructor = ınstructorManager.Find(x => x.id == id);

                for(int i = 0; i < instructor.lessons.Count; i++)
                {

                    instructor.lessons[i].ownerBranch = null; ;
                    instructor.lessons[i].ownerTeacherName = null;
                    instructor.lessons[i].ownerTeacherSurname = null;
                    instructor.lessons[i].isFull = false;
                    instructor.lessons[i].branchid = null;
                  
                }


                if(instructor != null)
                {
                    int count = ınstructorManager.Remove(instructor);

                    if(count > 0)
                    {
                        _IRedisCacheService.GetAllRemove();
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



    }
}
