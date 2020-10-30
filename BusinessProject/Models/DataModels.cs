using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessProject.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusinessProject.Models
{
    public class DataModels
    {

        public Data title{ get; set; }
        public List<SelectListItem> titleSelectList{ get; set; }        
        public Data content { get; set; }
        public List<Data> contentList { get; set; }
        public Question1 question1 { get; set; }
        public Question2 question2 { get; set; }
        public Question3 question3 { get; set; }

        public Question4 question4 { get; set; }
        public List<Question1> questionList { get; set; }
        public Data link { get; set; }
        public List<Data> linkList { get; set; }
        public int denemeId { get; set; } //olmamalı


    }
}
