using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessProject.Entities
{
    public class Exam
    {
        public int id { get; set; }
        public int titleId { get; set; }
        public string examTitle { get; set; }
        public string creationDate { get; set; }
    }
}
