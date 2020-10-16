using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestIT.Models;

namespace RequestIT.Controllers

{
    public class logincont
    {
        Login l = new Login();

        public string Password { get; set; }
        public int UserId { get; set; }

    }
}