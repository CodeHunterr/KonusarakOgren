using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessProject.Entities;

namespace BusinessProject.Models
{
    public class ExamModels
    {
        public Exam exam { get; set; }
        public List<Exam> examList { get; set; }
        public Data examData{ get; set; }
        public List<Question1> questionList { get; set; }

    }
}
