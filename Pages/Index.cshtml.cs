using eGearStore.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eGearStore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BhdtContext _context;

        public IndexModel(ILogger<IndexModel> logger, BhdtContext context)
        {
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public List<Product> products { get; set; }

        public void OnGet()
        {
            products = _context.Products.ToList();

        }
    }
}
