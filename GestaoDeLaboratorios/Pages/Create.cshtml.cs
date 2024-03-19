using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GestaoDeLaboratorios.Infra;
using GestaoDeLaboratorios.Models;

namespace GestaoDeLaboratorios.Pages
{
    public class CreateModel : PageModel
    {
        private readonly GestaoDeLaboratorios.Infra.InfnetDbContext _context;

        public CreateModel(GestaoDeLaboratorios.Infra.InfnetDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Computador Computador { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Computador.Add(Computador);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
