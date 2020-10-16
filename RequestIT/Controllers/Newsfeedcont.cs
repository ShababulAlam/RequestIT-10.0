using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestIT.Models;

namespace RequestIT.Controllers
{
    public class Newsfeedcont
    {
        Newsfeed n = new Newsfeed();

       
        public string Title { get; set; }

        public string Catagory { get; set; }
        public string Comment { get; set; }
        public string FormId { get; set; }
        public string StatusId { get; set; }
        public string AccountId { get; set; }
        public string Status { get; set; }
        public string DateTime { get; set; }

    }
}
