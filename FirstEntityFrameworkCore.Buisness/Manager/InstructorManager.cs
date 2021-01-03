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
    public class InstructorManager:ManagerBase<Teacher>
    {
        private Validation<InstructorViewModel> validation = new Validation<InstructorViewModel>();

        private Branch_TeacherManager branch_TeacherManager = new Branch_TeacherManager();
        private BranchManager branchManager = new BranchManager();

        public Validation<InstructorViewModel> Insert(InstructorViewModel modelInstructor)
        {
            Teacher instructor = null;

            List<Teacher> tempList = base.List();

            instructor = tempList.Find(x => x.name.MyTrimAndToLowerFunction() == modelInstructor.name.MyTrimAndToLowerFunction() &&
                                        x.surname.MyTrimAndToLowerFunction() == modelInstructor.surname.MyTrimAndToLowerFunction());

            if (modelInstructor.name == null)
            {
                validation.ErrorList.Add("Eğitmen Adı  Boş Geçilemez!");
                validation.objectModel = modelInstructor;

                return validation;
            }
            if (modelInstructor.ModelArray == null)
            {
                validation.ErrorList.Add("Eğitmenin En Az Bir Branşı Olmalıdır!");
                validation.objectModel = modelInstructor;
                return validation;
            }
            if (instructor != null)
            {
                validation.ErrorList.Add("Bu  Eğitmen Adı Zaten Kayıtlı!");
                validation.objectModel = modelInstructor;

                return validation;
            }
            instructor = new Teacher();
            instructor.name = modelInstructor.name.MyFirstLetterCapital(); 
            instructor.surname = modelInstructor.surname.ToUpper();
            instructor.CreatedOn = DateTime.Now;
            instructor.ModifiedOn = DateTime.Now;

            int count = base.Insert(instructor);

            if (count > 0)
            {
                if(modelInstructor.ModelArray != null)
                {
                    for (int i = 0; i < modelInstructor.ModelArray.Length; i++)
                    {
                        Branch branch = branchManager.Find(x => x.id == modelInstructor.ModelArray[i]);
                        Branch_Teacher bt = new Branch_Teacher();
                        bt.branch = branch;
                        bt.teacher = instructor;
                        bt.branchName = branch.name;
                        bt.teacherName = instructor.name;
                        count = branch_TeacherManager.Insert(bt);

                        if (count < 0)
                        {
                            validation.ErrorList.Add("Branşları  Eklerken Bir Hata Oluştu !");
                            return validation;
                        }
                    }
                }

                    return validation;
            }
            else
            {
                validation.ErrorList.Add("Eğitmen Adını Eklerken Bir Hata Oluştu !");

                return validation;
            }

        }


    }
}
