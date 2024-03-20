using Microsoft.AspNetCore.Mvc;

namespace OracleGroupAssignment.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
