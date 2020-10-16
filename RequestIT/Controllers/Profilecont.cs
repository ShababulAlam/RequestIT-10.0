using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestIT.Models;
namespace RequestIT.Controllers
{
   public class Profilecont
    {
        Profile l = new Profile();

        public string Password { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Dob { get; set; }
        public string Name { get; set; }
        public string Aiubid { get; set; }
        public string Gender { get; set; }
       
    }
}
