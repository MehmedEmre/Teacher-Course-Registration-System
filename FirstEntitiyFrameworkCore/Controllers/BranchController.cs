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

namespace FirstEntitiyFrameworkCore.Controllers
{
    public class BranchController : Controller
    {
        private List<Branch> branchList = new List<Branch>();
        private BranchManager branchManager = new BranchManager();
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

            return View();
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

        public JsonResult DeleteBranch(int? value)
        {
            if (value != null)
            {
                Branch branch = branchManager.Find(x => x.id == value);

                if (branch != null)
                {
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


        public JsonResult Update(Lessons value)
        {
            if (value != null)
            {
                Branch branch = branchManager.Find(x => x.id == value.id);

                if (branch != null)
                {
                    branch.name = value.name;
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
