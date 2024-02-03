using AquiTemLanche.Repositories.Interfaces;
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
            var snacks = _snacks.GetAllSnacks;
            return View(snacks);
        }
    }
}
