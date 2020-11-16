using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.DAC.Entities
{
    [Table("Teachers")]
    public class Teacher:MyEntityBase
    {

        [Required]
        public string name { set; get; }
        [Required]
        public string surname { set; get; }
        public List<Branch_Teacher> branch_teacher { set; get; }
        public List<Lessons> lessons { set; get; }

        public Teacher()
        {
            lessons = new List<Lessons>();
            branch_teacher = new List<Branch_Teacher>();
        }

    }
}
