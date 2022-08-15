using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService) // Injeção de dependência 
        {
            _sellerService = sellerService;
        }
        public IActionResult Index() // chamou o controlador 
        {
            var list = _sellerService.FindAll(); // Acessou o model
            return View(list); // Encaminhou para view
        }
    }
}
