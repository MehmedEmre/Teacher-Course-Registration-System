using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.DAC.Entities
{
    [Table("Lessons")]
    public class Lessons:MyEntityBase
    {
        [Required]
        public string name { get; set; }

        public string code { get; set; }

        public string ownerBranch { set; get; }

        public Boolean isFull { set; get; }

        public Teacher teacher { set; get; }
        
        public int? TeacherId { set; get; }

        public List<Subject> subject { set; get; }

        public Lessons()
        {
            subject = new List<Subject>();
        }


    }

}
