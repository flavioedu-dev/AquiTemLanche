using AquiTemLanche.Context;
using AquiTemLanche.Models;
using AquiTemLanche.Repositories.Interfaces;

namespace AquiTemLanche.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll => _context.Categories;
    }
}
