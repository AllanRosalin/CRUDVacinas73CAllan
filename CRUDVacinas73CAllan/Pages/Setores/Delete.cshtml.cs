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
    public class DeleteModel : PageModel
    {
        private readonly CRUDVacinas73CAllan.Data.CRUDVacinas73CAllanContext _context;

        public DeleteModel(CRUDVacinas73CAllan.Data.CRUDVacinas73CAllanContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Setor Setor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Setor == null)
            {
                return NotFound();
            }

            var setor = await _context.Setor.FirstOrDefaultAsync(m => m.Id == id);

            if (setor == null)
            {
                return NotFound();
            }
            else 
            {
                Setor = setor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Setor == null)
            {
                return NotFound();
            }
            var setor = await _context.Setor.FindAsync(id);

            if (setor != null)
            {
                Setor = setor;
                _context.Setor.Remove(Setor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
