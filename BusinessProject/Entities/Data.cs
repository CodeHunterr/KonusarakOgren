using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessProject.Entities
{
    public class Data
    {
        public int id { get; set; }
        public string title { get; set; }
        public string link { get; set; }     
        public string content { get; set; }
    }
}
