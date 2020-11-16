using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstEntityFrameworkCore.Entity.ViewModel
{
    public class InstructorViewModel
    {
        public int id { get; set; }

        [DisplayName("Eğitmen Adı"), Required(ErrorMessage = "Lütfen {0} Alanını Doldurunuz.")]
        public string name { set; get; }

        [DisplayName("Eğitmen Soyadı"), Required(ErrorMessage = "Lütfen {0} Alanını Doldurunuz.")]
        public string surname { set; get; }

        [DisplayName("Oluşturulma Tarihi")]
        public DateTime CreatedOn { set; get; }

        [DisplayName("Değiştirilme Tarihi")]
        public DateTime ModifiedOn { set; get; }

        public List<SelectListItem> selectList { set; get; }

        public int[] ModelArray { set; get; }

        public InstructorViewModel()
        {
            selectList = new List<SelectListItem>();
        }


    }
}
