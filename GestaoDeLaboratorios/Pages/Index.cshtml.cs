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
    public class IndexModel : PageModel
    {
        private readonly GestaoDeLaboratorios.Infra.InfnetDbContext _context;

        public IndexModel(GestaoDeLaboratorios.Infra.InfnetDbContext context)
        {
            _context = context;
        }

        public IList<Computador> Computador { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Computador = await _context.Computador.ToListAsync();
        }
    }
}
