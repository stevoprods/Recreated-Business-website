using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _100_Thieves.Models;

namespace _100_Thieves.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult About()
        {
            return View();
        }
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Apparel()
        {
            return View();
        }

        public ViewResult Faq()
        {
            return View();
        }

        public ViewResult Partners()
        {
            return View();
        }

       
        public ViewResult ThankYou()
        {
            return View();
        }
        [HttpGet]
        public ViewResult CheckoutForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult CheckoutForm(CustomerCheckout customerCheckout)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(customerCheckout);
                return View("ThankYou", customerCheckout);
            }
            else
            {
                //there is a validation error
                return View();
            }

        }

        public ViewResult Orders()
        {
            return View(Repository.Responses.Where(r => r.DeliveryType == true));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
