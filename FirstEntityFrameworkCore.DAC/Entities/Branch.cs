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

    [Table("Branch")]
    public class Branch:MyEntityBase
    {

        [Required]
        public string name { get; set; }
        [JsonIgnore]
        public List<Branch_Teacher> branch_teacher { set; get; }
        public Branch()
        {
            branch_teacher = new List<Branch_Teacher>();
        }


    }
}
