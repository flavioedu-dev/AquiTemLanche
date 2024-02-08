using AquiTemLanche.Models;

namespace AquiTemLanche.ViewModels
{
    public class SnackListViewModel
    {
        public IEnumerable<Snack> Snacks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
