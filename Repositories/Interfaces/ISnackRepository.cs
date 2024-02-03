using AquiTemLanche.Models;

namespace AquiTemLanche.Repositories.Interfaces
{
    public interface ISnackRepository
    {
        IEnumerable<Snack> GetAllSnacks { get; }
        IEnumerable<Snack> GetFavoriteSnacks { get; }
        Snack GetSnackById(int snackId);
    }
}
