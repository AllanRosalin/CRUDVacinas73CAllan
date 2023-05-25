using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDVacinas73CAllan.Data;
using CRUDVacinas73CAllan.Models;

namespace CRUDVacinas73CAllan.Pages.Enfermeiros
{
    public class IndexModel : PageModel
    {
        private readonly CRUDVacinas73CAllan.Data.CRUDVacinas73CAllanContext _context;

        public IndexModel(CRUDVacinas73CAllan.Data.CRUDVacinas73CAllanContext context)
        {
            _context = context;
        }

        public IList<Enfermeiro> Enfermeiro { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Enfermeiro != null)
            {
                Enfermeiro = await _context.Enfermeiro.ToListAsync();
            }
        }
    }
}
