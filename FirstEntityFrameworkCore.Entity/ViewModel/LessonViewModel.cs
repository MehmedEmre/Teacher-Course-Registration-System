using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.Entity.ViewModel
{
    public class LessonViewModel
    {
        public int id { get; set; }

        [DisplayName("Ders Adı"),Required(ErrorMessage = "Lütfen {0} Alanını Doldurunuz.")]
        public string name { get; set; }

        public string ownerBranch { set; get; }

   
    }
}
