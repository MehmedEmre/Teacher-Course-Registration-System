using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.Entity.ViewModel
{
    public class InstructorAndLessonModel
    {

        public int lessonId { set; get; }
        public int instructorId { set; get; }
        public string lessonName { set; get; }
        public string instructorName { set; get; }
        public string instructorSurname { set; get; }
        public string branchName { set; get; }

    }
}
