using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstEntityFrameworkCore.Entity.ViewModel
{
    public class BranchViewModel
    {
        public int id { get; set; }

        [DisplayName("Branş Adı"),Required(ErrorMessage ="Lütfen {0} Alanını Doldurunuz.")]
        public string name { get; set; }

        public List<SelectListItem> TeacherList { set; get; }

        public int teacherValue { set; get; }

        public List<SelectListItem> BrachList { set; get; }

        public int branchValue { set; get; }

    
        public BranchViewModel()
        {
            TeacherList = new List<SelectListItem>();
            BrachList = new List<SelectListItem>();
            teacherValue = 0;
            branchValue = 0;

        }

    }
}
