using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUDVacinas73CAllan.Data;
using CRUDVacinas73CAllan.Models;

namespace CRUDVacinas73CAllan.Pages.Enfermeiros
{
    public class CreateModel : PageModel
    {
        private readonly CRUDVacinas73CAllan.Data.CRUDVacinas73CAllanContext _context;

        public CreateModel(CRUDVacinas73CAllan.Data.CRUDVacinas73CAllanContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Enfermeiro Enfermeiro { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Enfermeiro == null || Enfermeiro == null)
            {
                return Page();
            }

            _context.Enfermeiro.Add(Enfermeiro);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
