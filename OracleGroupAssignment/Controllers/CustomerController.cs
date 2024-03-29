using Microsoft.AspNetCore.Mvc;
using OracleGroupAssignment.Models;
using OracleGroupAssignment.Repository;

namespace OracleGroupAssignment.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {

            var customer = _customerService.GetAll();
            return View(customer);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Store(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", customer);
            }
            var result = _customerService.Create(customer);
            if (result)
            {
                return RedirectToAction("Index");
            }
            return View("Create", customer);
        }
        public IActionResult Edit(int id)
        {
            var customer = _customerService.GetById(id);
            if (customer == null)
            {
                return RedirectToAction("Index");
            }
            return View(customer);
        }
        public IActionResult Details(int id)
        {
            var customer = _customerService.GetById(id);
            if (customer == null)
            {
                return RedirectToAction("Index");
            }
            return View(customer);
        }
        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            _customerService.Update(customer);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var customer = _customerService.GetById(id);
            if (customer == null)
            {
                return RedirectToAction("Index");
            }
            return View(customer);
        }
        [HttpPost]
        public ActionResult ConfirmDelete(int Customerid)
        {
			if (!ModelState.IsValid)
			{
				return View("Create", Customerid);
			}
			var result = _customerService.Delete(Customerid);
			if (result)
			{
				return RedirectToAction("Index");
			}
			return View("Create", Customerid);
		}
    }
}
