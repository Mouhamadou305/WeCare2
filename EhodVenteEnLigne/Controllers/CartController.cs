﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EhodBoutiqueEnLigne.Models;
using EhodBoutiqueEnLigne.Models.Entities;
using EhodBoutiqueEnLigne.Models.Services;

namespace EhodBoutiqueEnLigne.Controllers
{
    public class CartController : Controller
    {
        private readonly ICart _cart;
        private readonly IProductService _productService;

        public CartController(ICart cart, IProductService productService)
        {
            _cart = cart;
            _productService = productService;
        }

        public ViewResult Index()
        {
            Cart cart = _cart as Cart;
            return View(cart);
        }

        [HttpPost]
        public RedirectToActionResult AddToCart(int id)
        {
            MedicalFile product = _productService.GetProductById(id);

            if (product != null)
            {
                _cart.AddItem(product, 1);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Product");
            }
        }

        public RedirectToActionResult RemoveFromCart(int id)
        {
            MedicalFile product = _productService.GetAllProducts()
                .FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                _cart.RemoveLine(product);
            }

            return RedirectToAction("Index");
        }
    }
}
