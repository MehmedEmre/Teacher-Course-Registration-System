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
    [Table("Subjects")]
    public class Subject : MyEntityBase
    {
        public string title { set; get; }

        public string text { set; get; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime subjectStart { set; get; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime subjectFinish { set; get; }
        [JsonIgnore]
        public Lessons Lesson { set; get; }

        public int LessonId { set; get; }

    }
}
