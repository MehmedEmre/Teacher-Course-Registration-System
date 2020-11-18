using FirstEntityFrameworkCore.Buisness.Abstract;
using FirstEntityFrameworkCore.DAC.Entities;
using FirstEntityFrameworkCore.Entity.ValidationControl;
using FirstEntityFrameworkCore.Entity.ViewModel;
using FirstEntityFrameworkCore.Helper.Extension.String_Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.Buisness.Manager
{
    public class BranchManager:ManagerBase<Branch>
    {

        private Validation<BranchViewModel> validation = new Validation<BranchViewModel>();

        public Validation<BranchViewModel> Insert(BranchViewModel model)
        {
            Branch branch = null;

            List<Branch> tempList = base.List();

            branch = tempList.Find(x => x.name.MyTrimAndToLowerFunction() == model.name.MyTrimAndToLowerFunction());


            if (model.name == null)
            {

                validation.ErrorList.Add("Branş Adı  Boş Geçilemez!");
                validation.objectModel = model;

                return validation;
            }
            if (branch != null)
            {

                validation.ErrorList.Add("Bu Branş Adı Zaten Kayıtlı!");
                validation.objectModel = model;

                return validation;

            }
            branch = new Branch();
            branch.name = model.name.MyFirstLetterCapital(); ;
            branch.CreatedOn = DateTime.Now;
            branch.ModifiedOn = DateTime.Now;
            int count = base.Insert(branch);

            if (count > 0)
            {
                return validation;
            }
            else
            {
                validation.ErrorList.Add("Branş Adını Eklerken Bir Hata Oluştu !");

                return validation;
            }

        }

   


    }
}
