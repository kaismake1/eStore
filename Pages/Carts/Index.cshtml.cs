using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using eGearStore.DataAccess;

namespace eGearStore.Pages.Carts
{
    public class IndexModel : PageModel
    {
        private readonly eGearStore.DataAccess.BhdtContext _context;

        public IndexModel(eGearStore.DataAccess.BhdtContext context)
        {
            _context = context;
        }

        public IList<Cart> Cart { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Cart = await _context.Carts
                .Include(c => c.Product)
                .Include(c => c.User).ToListAsync();
        }
    }
}
