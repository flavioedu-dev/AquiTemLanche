using AquiTemLanche.Models;

namespace AquiTemLanche.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll { get; }
    }
}
