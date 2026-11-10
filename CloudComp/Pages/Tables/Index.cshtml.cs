using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CloudComp.Models;

namespace CloudComp.Pages.Tables
{
    public class IndexModel : PageModel
    {
        private readonly CloudComp.Models.DebesuKompContext _context;

        public IndexModel(CloudComp.Models.DebesuKompContext context)
        {
            _context = context;
        }

        public IList<Table> Table { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Table = await _context.Tables.ToListAsync();
        }
    }
}
