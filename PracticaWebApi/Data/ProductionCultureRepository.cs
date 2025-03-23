using Microsoft.EntityFrameworkCore;
using PracticaWebApi.Data;
using PracticaWebApi.Interface;
using PracticaWebApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using static PracticaWebApi.Model.ProductionCulturecs;

namespace PracticaWebApi.Repositories
{
    public class ProductionCultureRepository : IProductionCultureRepository
    {
        private readonly AppDbContext _context;

        public ProductionCultureRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Culture>> GetCultureAsync()
        {
            return await _context.Cultures.AsNoTracking().ToListAsync();
        }

        public async Task<Culture> GetCultureByIdAsync(string cultureId)
        {
            return await _context.Cultures.FindAsync(cultureId);
        }
    }
}
