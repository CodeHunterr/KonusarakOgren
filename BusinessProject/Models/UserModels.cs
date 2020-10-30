using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessProject.Entities;

namespace BusinessProject.Models
{
    public class UserModels
    {
        public User user { get; set; }
        public List<User> users { get; set; }
        public int id { get; set; }
    }
}
