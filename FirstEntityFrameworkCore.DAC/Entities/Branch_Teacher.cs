using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.DAC.Entities
{
    public class Branch_Teacher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public Branch branch { set; get; }
        public int BranchId { set; get; }
        public string branchName { set; get; }

        public Teacher teacher { set; get; }
        public int TeacherId { set; get; }
        public string teacherName { set; get; }


    }
}
