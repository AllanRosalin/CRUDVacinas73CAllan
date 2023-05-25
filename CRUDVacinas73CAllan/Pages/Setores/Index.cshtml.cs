using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDVacinas73CAllan.Data;
using CRUDVacinas73CAllan.Models;

namespace CRUDVacinas73CAllan.Pages.Setores
{
    public class IndexModel : PageModel
    {
        private readonly CRUDVacinas73CAllan.Data.CRUDVacinas73CAllanContext _context;

        public IndexModel(CRUDVacinas73CAllan.Data.CRUDVacinas73CAllanContext context)
        {
            _context = context;
        }

        public IList<Setor> Setor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Setor != null)
            {
                Setor = await _context.Setor.ToListAsync();
            }
        }
    }
}
