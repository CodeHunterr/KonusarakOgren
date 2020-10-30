using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessProject.Entities
{
    public class User
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [StringLength(15, ErrorMessage = "Karakter uzunluğu 15 ' den fazla olamaz")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [StringLength(15, ErrorMessage = "Karakter uzunluğu 15 ' den fazla olamaz")]
        public string password { get; set; }
        public int statusId { get; set; }
       
    }
}
