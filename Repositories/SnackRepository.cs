using AquiTemLanche.Context;
using AquiTemLanche.Models;
using AquiTemLanche.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AquiTemLanche.Repositories
{
    public class SnackRepository : ISnackRepository
    {
        private readonly AppDbContext _context;

        public SnackRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Snack> GetAllSnacks => _context.Snacks.Include(c => c.Category);

        public IEnumerable<Snack> GetFavoriteSnacks => _context.Snacks.Where(s => s.IsFavoriteSnack).Include(c => c.Category);

        public Snack GetSnackById(int snackId)
        {
            return _context.Snacks.FirstOrDefault(s => s.SnackId == snackId);
        }
    }
}
