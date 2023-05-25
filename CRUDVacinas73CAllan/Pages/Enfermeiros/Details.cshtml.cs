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
    public class DetailsModel : PageModel
    {
        private readonly CRUDVacinas73CAllan.Data.CRUDVacinas73CAllanContext _context;

        public DetailsModel(CRUDVacinas73CAllan.Data.CRUDVacinas73CAllanContext context)
        {
            _context = context;
        }

      public Enfermeiro Enfermeiro { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Enfermeiro == null)
            {
                return NotFound();
            }

            var enfermeiro = await _context.Enfermeiro.FirstOrDefaultAsync(m => m.Id == id);
            if (enfermeiro == null)
            {
                return NotFound();
            }
            else 
            {
                Enfermeiro = enfermeiro;
            }
            return Page();
        }
    }
}
