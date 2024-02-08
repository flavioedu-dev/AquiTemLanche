using AquiTemLanche.Repositories.Interfaces;
using AquiTemLanche.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AquiTemLanche.Controllers
{
    public class SnackController : Controller
    {
        private readonly ISnackRepository _snacks;

        public SnackController(ISnackRepository snacks)
        {
            _snacks = snacks;
        }

        public IActionResult List()
        {
            SnackListViewModel snackListViewModel = new SnackListViewModel();
            snackListViewModel.Snacks = _snacks.GetAllSnacks;
            snackListViewModel.CurrentCategory = "Categoria atual";
            return View(snackListViewModel);
        }
    }
}
