using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessProject.Entities
{
    public class Question1
    {
        public int id { get; set; }
        public string question { get; set; }
        public string aChoise { get; set; }
        public string bChoise { get; set; }
        public string cChoise { get; set; }        
        public string dChoise { get; set; }       
        public string trueAnswer1 { get; set; }       
      

    }

    public class Question2
    {
        public int id { get; set; }
   
        public string question { get; set; }

        public string aChoise { get; set; }

        public string bChoise { get; set; }
        public string cChoise { get; set; }
        public string dChoise { get; set; }
        public string trueAnswer2 { get; set; }


    }
    public class Question3
    {
        public int id { get; set; }

        public string question { get; set; }

        public string aChoise { get; set; }

        public string bChoise { get; set; }
        public string cChoise { get; set; }
        public string dChoise { get; set; }
        public string trueAnswer3{ get; set; }
    

    }
    public class Question4
    {
        public int id { get; set; }

        public string question { get; set; }

        public string aChoise { get; set; }

        public string bChoise { get; set; }
        public string cChoise { get; set; }
        public string dChoise { get; set; }
        public string trueAnswer4 { get; set; }
      

    }


}
