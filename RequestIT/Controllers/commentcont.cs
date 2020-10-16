using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestIT.Models;

namespace RequestIT.Controllers
{
   public class commentcont
    {
        Comment n = new Comment();


        public string FormId { get; set; }
        public string StatusId { get; set; }
        public string AccountId { get; set; }
        public string Status { get; set; }
        public string DateTime { get; set; }
        public string comment { get; set; }
        public string reply { get; set; }
    }
}
