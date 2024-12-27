using AspNetMvcAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AspNetMvcAssignment.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Orders()
        {
            var viewModel = new CustomerViewModel
            {
                CustomerNumber = 12345,
                FirstName = "John",
                LastName = "Smith",
                Orders = new List<CustomerOrder>
                {
                    new CustomerOrder { OrderId = 1, OrderDate = DateTime.Now.AddDays(-3), Description = "Sample Order 1", Total = 100.00M },
                    new CustomerOrder { OrderId = 2, OrderDate = DateTime.Now.AddDays(-2), Description = "Sample Order 2", Total = 200.00M },
                    new CustomerOrder { OrderId = 3, OrderDate = DateTime.Now.AddDays(-1), Description = "Sample Order 3", Total = 300.00M }
                }
            };

            return View(viewModel);
        }
    }
}
