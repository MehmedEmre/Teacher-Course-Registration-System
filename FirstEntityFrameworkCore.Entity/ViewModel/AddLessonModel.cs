using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstEntityFrameworkCore.Entity.ViewModel
{
    public class AddLessonModel
    {
        [DisplayName("Eğitmen Adı"), Required(ErrorMessage = "Lütfen {0} Alanını Doldurunuz.")]
        public string name { set; get; }

        [DisplayName("Eğitmen Soyadı"), Required(ErrorMessage = "Lütfen {0} Alanını Doldurunuz.")]
        public string surname { set; get; }

        public int TeacherId { set; get; }

        public string[] title { set; get; }
        public string[] text { set; get; }

        public Boolean isPDF { set; get; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime?[] subjectStart { set; get; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime?[] subjectFinish { set; get; }

        public List<SelectListItem> selectListBranch { set; get; }

        public List<SelectListItem> selectListLesson { set; get; }

        public int branch { set; get; }

        public int lesson { set; get; }

        public AddLessonModel()
        {
            selectListBranch = new List<SelectListItem>();
            selectListLesson = new List<SelectListItem>();
        }

    }
}
