using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstEntityFrameworkCore.Buisness.Abstract;
using FirstEntityFrameworkCore.DAC.Entities;
using FirstEntityFrameworkCore.Entity.ValidationControl;
using FirstEntityFrameworkCore.Entity.ViewModel;
using FirstEntityFrameworkCore.Helper.Extension;

namespace FirstEntityFrameworkCore.Buisness.Manager
{
    public class SubjectManager:ManagerBase<Subject>
    {
        private InstructorManager instructorManager = new InstructorManager();
        private LessonManager lessonManager = new LessonManager();
        private BranchManager branchManager = new BranchManager();
        Validation<Subject> valid = new Validation<Subject>();

        public Validation<Subject> Insert(AddLessonModel addLessonModel)
        {
            int countSubject = 0;
            int countLesson = 0;
            Branch branch = null;
            Lessons lesson = null;
            Teacher teacher = null;

            if (addLessonModel.branch != 0 && addLessonModel.lesson != 0)
            {
                branch = branchManager.Find(x => x.id == addLessonModel.branch);
                lesson = lessonManager.Find(x => x.id == addLessonModel.lesson);
                teacher = instructorManager.Find(x => x.id == addLessonModel.TeacherId);

            }
            else
            {
                valid.ErrorList.Add("Lütfen Tüm Alanları Doldurduğunuzdan Emin Olun!");
                return valid;
            }

            for (int i = 0; i < addLessonModel.text.Length; i++)
            {
               
                if(addLessonModel.title[i] != null && addLessonModel.text[i] != null && addLessonModel.subjectStart[i] != null && addLessonModel.subjectFinish[i] != null)
                {          
                }
                else
                {
                    valid.ErrorList.Add("Lütfen Tüm Alanları Doldurduğunuzdan Emin Olun!");
                    return valid;
                }
            }

            lesson.ownerBranch = branch.name;
            lesson.isFull = true;
            lesson.teacher = teacher;

            for (int i = 0; i < addLessonModel.text.Length; i++)
                {
                    Subject subject  = new Subject();
                    subject.title = addLessonModel.title[i].ToUpper();
                    subject.text = addLessonModel.text[i].MyFirstLetterCapital();
                    subject.subjectStart = addLessonModel.subjectStart[i].Value;
                    subject.subjectFinish = addLessonModel.subjectFinish[i].Value;
                    subject.Lesson = lesson;
                    lesson.subject.Add(subject);

                    subject.CreatedOn = DateTime.Now;
                    subject.ModifiedOn = DateTime.Now;
                    lesson.ModifiedOn = DateTime.Now;
                    countSubject = base.Insert(subject);
                    countLesson = lessonManager.Update(lesson);

                if (countSubject < 0 && countLesson < 0)
                    break;
                }

                if (countSubject < 0 && countLesson < 0)
                {
                    valid.ErrorList.Add("Kayıt Oluşturma Sırasında Bir Hata Meydana Geldi!");
                    return valid;
                }

            return valid;
          
        }


    }
}
