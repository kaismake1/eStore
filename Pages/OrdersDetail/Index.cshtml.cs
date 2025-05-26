using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using eGearStore.DataAccess;

namespace eGearStore.Pages.OrdersDetail
{
    public class IndexModel : PageModel
    {
        private readonly eGearStore.DataAccess.BhdtContext _context;

        public IndexModel(eGearStore.DataAccess.BhdtContext context)
        {
            _context = context;
        }

        public IList<OrderDetail> OrderDetail { get;set; } = default!;

        public async Task OnGetAsync()
        {
            OrderDetail = await _context.OrderDetails
                .Include(o => o.Order)
                .Include(o => o.Product).ToListAsync();
        }
    }
}
