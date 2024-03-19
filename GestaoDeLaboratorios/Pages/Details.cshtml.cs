using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestaoDeLaboratorios.Infra;
using GestaoDeLaboratorios.Models;

namespace GestaoDeLaboratorios.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly GestaoDeLaboratorios.Infra.InfnetDbContext _context;

        public DetailsModel(GestaoDeLaboratorios.Infra.InfnetDbContext context)
        {
            _context = context;
        }

        public Computador Computador { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computador = await _context.Computador.FirstOrDefaultAsync(m => m.Id == id);
            if (computador == null)
            {
                return NotFound();
            }
            else
            {
                Computador = computador;
            }
            return Page();
        }
    }
}
