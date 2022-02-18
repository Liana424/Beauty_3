using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Beauty_2.Data;
using Beauty_2.Models;

namespace Beauty_2.Pages.Artists
{
    public class IndexModel : PageModel
    {
        private readonly Beauty_2.Data.Beauty_2Context _context;

        public IndexModel(Beauty_2.Data.Beauty_2Context context)
        {
            _context = context;
        }

        public IList<Artist> Artist { get;set; }

        public async Task OnGetAsync()
        {
            Artist = await _context.Artist.ToListAsync();
        }
    }
}
