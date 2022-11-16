using GroceryDelivery.BusinessLayer.Interfaces;
using GroceryDelivery.BusinessLayer.Services;
using GroceryDelivery.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryDelivery.Controllers
{
    public class GroceryController : Controller
    {
        private readonly IGroceryServices _groceryServices;

        public GroceryController(IGroceryServices services)
        {
            _groceryServices = services;
        }
        // GET: GroceryController
        public async Task<IActionResult> Index()
        {
            var prod = await _groceryServices.GetAllProduct();
            return View(prod);
        }

        // GET: GroceryController/Details/5
        [HttpGet]
        [Route("/Grocery/Details/{productId:int}")]
        public async Task<IActionResult> Details([FromRoute] int? productId)
        {
             throw new NotImplementedException();
        }

        [HttpGet]

        public ActionResult Create()

        {

            return View();

        }

        [HttpPost]

        public ActionResult Create(Product model)

        {

            throw new NotImplementedException();

        }

        [HttpGet]

        public async Task<ActionResult> Edit(int id)

        {

            var data =await _groceryServices.GetProductById(id);

            return View(data);

        }

        [HttpPost]

        public async Task<ActionResult> Edit(Product Model)

        {

             throw new NotImplementedException();

        }

        // GET: Employees/Delete/1
        [HttpGet]
        [Route("/Grocery/Delete/{productId:int}")]
        public async Task<IActionResult> Delete([FromRoute] int? productId)
        {
            throw new NotImplementedException();
        }

        // POST: Employees/Delete/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
