using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstEntityFrameworkCore.DAC.Entities;
using FirstEntityFrameworkCore.Entity.ViewModel;
using Microsoft.AspNetCore.Mvc;
using FirstEntityFrameworkCore.Buisness.Manager;
using FirstEntityFrameworkCore.Entity.ValidationControl;
using NToastNotify;
using FirstEntitiyFrameworkCore.RedisCacheManagers.Abstract;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstEntitiyFrameworkCore.Controllers
{
    public class BranchController : Controller
    {
        private List<Branch> branchList = new List<Branch>();
        private BranchManager branchManager = new BranchManager();
        private LessonManager lessonManager = new LessonManager();
        private InstructorManager instructorManager = new InstructorManager();
        private Branch_TeacherManager branch_TeacherManager = new Branch_TeacherManager();
        private IToastNotification toastNotification;
        private readonly IRedisCacheService _IRedisCacheService;

        public BranchController(IToastNotification toastNotification, IRedisCacheService IRedisCacheService)
        {
            this.toastNotification = toastNotification;
            _IRedisCacheService = IRedisCacheService;
        }


        [HttpGet]
        public IActionResult Branch()
        {
            branchList = _IRedisCacheService.GetBranchs();
            ViewBag.Branchs = branchList;

            BranchViewModel viewModel = new BranchViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Branch(BranchViewModel model)
        {
            Validation<BranchViewModel> branchViewModel = new Validation<BranchViewModel>();

            if (ModelState.IsValid)
            {
                if (model != null)
                {
                    branchViewModel = branchManager.Insert(model);

                    if (branchViewModel.ErrorList.Count == 0)
                    {
                        _IRedisCacheService.GetAllRemove();
                        toastNotification.AddSuccessToastMessage("Branş Ekleme İşlemi Başarılı");
                        return RedirectToAction("Branch");
                    }
                    else
                    {
                        branchViewModel.ErrorList.ForEach(x => toastNotification.AddAlertToastMessage(x));
                        return RedirectToAction("Branch");
                    }
                }
                else
                {
                    toastNotification.AddWarningToastMessage("Branş Ekleme İşlemi Sırasında Bir Hata Meydana Geldi!");
                    return RedirectToAction("Branch");
                }
            }
            else
            {

                ModelState.Values.ToList().ForEach(x => x.Errors.ToList().ForEach(y=> toastNotification.AddWarningToastMessage(y.ErrorMessage)));

                return RedirectToAction("Branch");

            }
        }

        [HttpPost]
        public JsonResult LoadTeacher()
        {
            List<Teacher> teacherList = instructorManager.List();

            List<SelectListItem> list = new List<SelectListItem>();

            for(int i = 0; i < teacherList.Count; i++)
            {
                
                list.Add(new SelectListItem(teacherList[i].name + " " + teacherList[i].surname, teacherList[i].id.ToString()));
            }

            return Json( new { list = list});
        }


        [HttpPost]
        public JsonResult LoadBranch(int id)
        {

            if(id != -1)
            {
                Teacher teacher = instructorManager.Find(x => x.id == id);

                List<int> branch_TeachersList = branch_TeacherManager.List(x => x.teacherid == teacher.id).Select(x => x.branchid).ToList();

                List<Branch> branchList = branchManager.List(x => !branch_TeachersList.Contains(x.id)).ToList();

                if(branchList.Count ==  0)
                {
                    return Json(new { state = false });
                }

                List<SelectListItem> list = new List<SelectListItem>();

                for (int i = 0; i < branchList.Count; i++)
                {

                    list.Add(new SelectListItem(branchList[i].name, branchList[i].id.ToString()));
                }

                return Json(new { state = true,list = list });
            }


            return Json(new { state = false });
        }

        [HttpPost]
        public JsonResult RegisterTeacherBranch(int tid,int bid)
        {

            int val = 0;


           if(tid != -1 && bid != -1){

                Teacher teacher = instructorManager.Find(x => x.id == tid);
                Branch branch = branchManager.Find(x => x.id == bid);

                Branch_Teacher branch_Teacher = new Branch_Teacher();

                branch_Teacher.branchid = branch.id;
                branch_Teacher.branchName = branch.name;
                branch_Teacher.teacherid = teacher.id;
                branch_Teacher.teacherName = teacher.name;

                val = branch_TeacherManager.Insert(branch_Teacher);

                if(val > 0)
                {
                    toastNotification.AddSuccessToastMessage("Ekleme İşlemi Başarılı");
                    return Json(new {state = true });
                }
                else
                {
                    toastNotification.AddWarningToastMessage("Branş Ekleme İşlemi Sırasında Bir Hata Meydana Geldi!");
                }

           }

            toastNotification.AddWarningToastMessage("Lütfen Geçerli Değerler İle İşlem Yapın!");
            return Json(new { state = false});
        }



        public JsonResult DeleteBranch(int? value)
        {
            if (value != null)
            {
                Branch branch = branchManager.Find(x => x.id == value);

                if (branch != null)
                {
                    List<Lessons> lessonList = lessonManager.List();

                    for (int i = 0; i < lessonList.Count; i++)
                    {
                        if (lessonList[i].branchid == branch.id)
                        {
                            lessonList[i].ownerBranch = null;
                            lessonList[i].branchid = null;
                            lessonList[i].isFull = false;
                            lessonList[i].teacherid = null;
                            lessonList[i].ownerTeacherName = null;
                            lessonList[i].ownerTeacherSurname = null;

                            lessonManager.Update(lessonList[i]);
                        }
                    }



                    int count = branchManager.Remove(branch);

                    if (count > 0)
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


        public JsonResult Update(int id,string name)
        {
            if (id != 0)
            {
                Branch branch = branchManager.Find(x => x.id == id);

                if (branch != null)
                {
                    Branch_Teacher branch_Teacher = branch_TeacherManager.Find(x => x.branchid == id);

                    if(branch_Teacher != null)
                    {
                        List<Branch_Teacher> branch_TeacherList = branch_TeacherManager.List();

                        for(int i = 0; i< branch_TeacherList.Count; i++)
                        {
                            if(branch_TeacherList[i].branchid == branch.id)
                            {
                                branch_TeacherList[i].branchName = name;
                                branch_TeacherManager.Update(branch_TeacherList[i]);
                            }
                        }

                    }


                    branch.name = name;
                    int count = branchManager.Update(branch);

                    if (count > 0)
                    {
                        _IRedisCacheService.GetAllRemove();
                        branch.ModifiedOn = DateTime.Now;
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
