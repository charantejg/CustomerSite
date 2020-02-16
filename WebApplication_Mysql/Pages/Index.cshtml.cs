using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication_Mysql.Models;

namespace WebApplication_Mysql.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CustomerContext _context;

        public IndexModel(CustomerContext context)
        {
            _context = context;
        }

        public  IList<PersonalDetails> personalDetails { get; set; }

        public void OnGet()
        {
            personalDetails = _context.GetAllPersonalDetails();
        }
    }
}
