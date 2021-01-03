using Newtonsoft.Json;
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

        public int? branchid { set; get; }

        public Boolean isFull { set; get; }
        [JsonIgnore]
        public Teacher teacher { set; get; }
        
        public int? teacherid { set; get; }

        public string ownerTeacherName { set; get; }

        public string ownerTeacherSurname{ set; get; }
        [JsonIgnore]
        public List<Subject> subject { set; get; }

        public Lessons()
        {
            subject = new List<Subject>();
        }


    }

}
