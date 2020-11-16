using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.Entity.ViewModel
{
    public class BranchViewModel
    {
        public int id { get; set; }

        [DisplayName("Branş Adı"),Required(ErrorMessage ="Lütfen {0} Alanını Doldurunuz.")]
        public string name { get; set; }

    }
}
