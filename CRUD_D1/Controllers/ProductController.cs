#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD_D1.Data;
using CRUD_D1.Models;
using CRUD_D1.Service;

namespace CRUD_D1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Product
        public IActionResult Index()
        {
            return View( _productService.GetProducts());
        }

        // GET: Product/Details/5
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rs = _productService.GetProduct(id);
            if (rs == null)
            {
                return NotFound();
            }

            return View(rs);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Product_Id,Product_Name,Product_Img,Description,Price,Category_Id,CreatedDate,UpdatedDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
                TempData["success"] = "Product added successfully!";
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rs = _productService.GetProduct(id);
            if (rs == null)
            {
                return NotFound();
            }
            return View(rs);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Product_Id,Product_Name,Product_Img,Description,Price,Category_Id,CreatedDate,UpdatedDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.UpdateProduct(product);
                TempData["success"] = "Product updated successfully!";
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rs = _productService.GetProduct(id);
            if (rs == null)
            {
                return NotFound();
            }
            _productService.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        
    }
}
