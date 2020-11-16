using FirstEntityFrameworkCore.Buisness.Abstract;
using FirstEntityFrameworkCore.DAC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstEntityFrameworkCore.Entity.ViewModel;
using FirstEntityFrameworkCore.Entity.ValidationControl;
using FirstEntityFrameworkCore.Helper.Extension;

namespace FirstEntityFrameworkCore.Buisness.Manager
{
    public class LessonManager:ManagerBase<Lessons>
    {

        private Validation<LessonViewModel> validation = new Validation<LessonViewModel>();

        public Validation<LessonViewModel> Insert(LessonViewModel modelLesson)
        {
                Lessons lesson = null;

                List<Lessons> tempList = base.List();

                lesson = tempList.Find(x => x.name.MyTrimAndToLowerFunction() == modelLesson.name.MyTrimAndToLowerFunction());
               
                
                if (modelLesson.name == null) {

                    validation.ErrorList.Add("Ders Adı  Boş Geçilemez!");
                    validation.objectModel = modelLesson;

                    return validation;
                }
                if(lesson != null)
                {

                    validation.ErrorList.Add("Bu Ders Adı Zaten Kayıtlı!");
                    validation.objectModel = modelLesson;

                    return validation;

                }
                lesson = new Lessons();
                lesson.name = modelLesson.name.MyFirstLetterCapital();
                lesson.ownerBranch = modelLesson.ownerBranch;
                lesson.CreatedOn = DateTime.Now;
                lesson.ModifiedOn = DateTime.Now;

            int count = base.Insert(lesson);

                if (count > 0)
                {
                     return validation;
                }
                else
                {
                     validation.ErrorList.Add("Ders Adını Eklerken Bir Hata Oluştu !");

                    return validation;
                }

        }


    }
}
