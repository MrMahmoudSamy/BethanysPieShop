using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class ProductController : Controller
    {
        private ICategoryRepository _categoryRepository;
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository,ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult List()
        {
            return View(_productRepository.Allproducts);
        }
    }
}