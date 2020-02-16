using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Mysql.Models
{
    public class PersonalDetails
    {
        private CustomerContext context;

        public  int NRIC { get; set; }
        public  string Name { get; set; }
        public string Email { get; set; }

    }
}
