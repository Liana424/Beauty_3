using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Beauty_2.Data;
using Beauty_2.Models;

namespace Beauty_2.Pages.Services
{
    public class IndexModel : PageModel
    {
        private readonly Beauty_2.Data.Beauty_2Context _context;

        public IndexModel(Beauty_2.Data.Beauty_2Context context)
        {
            _context = context;
        }

        public IList<Service> Service { get;set; }

        public async Task OnGetAsync()
        {
            Service = await _context.Service.Include(b => b.Artist).ToListAsync();
        }
    }
}
