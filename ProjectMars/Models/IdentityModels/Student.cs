using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMars.Models.IdentityModels
{
    public class Student : ApplicationUser
    {
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string Gender { get; set; }
        public string College { get; set; }
    }
}