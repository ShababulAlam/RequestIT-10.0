using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestIT.Models;

namespace RequestIT.Controllers
{
   public class Newpostcont
    {
        Login l = new Login();

       
       
       public string AccountId { get; set; }
        public string Status { get; set; }
        public string DateTime { get; set; }
        public string Title { get; set; }
        public string StatusId { get; set; }
        public string Catagory { get; set; }
        public string Check { get; set; }
    }
}
