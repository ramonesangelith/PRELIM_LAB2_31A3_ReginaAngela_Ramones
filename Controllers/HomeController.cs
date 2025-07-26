using Microsoft.AspNetCore.Mvc;
using angelith.Models;
using angelith.ViewModels;

namespace angelith.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var book = new Book
            {
                Id = 1,
                Title = "The Perks of Being a Miss Philippines",
                Author = "Sophia LaForteza"
            };

            var customer = new Customer
            {
                FirstName = "Daniela",
                LastName = "Avanzini",
                MiddleName = "C.",
                Title = "Ms.",
                Email = "latina.mami@katseye.com"
            };

            var viewModel = new BookCustomerViewModel
            {
                Book = book,
                Customer = customer
            };

            return View(viewModel);
        }
    }
};