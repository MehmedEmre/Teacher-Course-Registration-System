using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.Entity.ViewModel
{
    public class EditInstructorModel
    {
        public string name { set; get; }

        public string surname { set; get; }

        public int Id { set; get; }

        public List<List<SelectListItem>> branchKeys { set; get; }

        public int[] branchValues { set; get; }

        public List<List<SelectListItem>> lessonKeys { set; get; }

        public int[] lessonValues { set; get; }

        public Boolean isEnable { set; get; }

        public EditInstructorModel()
        {
            branchKeys = new List<List<SelectListItem>>();
            lessonKeys = new List<List<SelectListItem>>();
            isEnable = false;
        }
    }
}
