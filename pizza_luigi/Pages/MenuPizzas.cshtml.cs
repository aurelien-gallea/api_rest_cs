using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_luigi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizza_luigi.Pages
{
    public class MenuPizzasModel : PageModel
    {
       
        private readonly pizza_luigi.Data.DataContext _context;

        public MenuPizzasModel(pizza_luigi.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get; set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
            Pizza = Pizza.OrderBy(p => p.Prix).ToList();
        }
    }
}
