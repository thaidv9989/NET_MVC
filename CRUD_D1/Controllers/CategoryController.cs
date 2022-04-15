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
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: Category
        public IActionResult Index()
        {
            return View(_categoryService.GetCategories());
        }

        // GET: Category/Details/5
        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rs = _categoryService.GetCategory(id);
            if (rs == null)
            {
                return NotFound();
            }

            return View(rs);
        }

        // GET: Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Category_Id,Category_Name")] Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.AddCategory(category);
                TempData["success"] = "Category added successfully!";
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Category/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rs = _categoryService.GetCategory(id);
            if (rs == null)
            {
                return NotFound();
            }
            return View(rs);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Category_Id,Category_Name")] Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.UpdateCategory(category);
                TempData["success"] = "Product updated successfully!";
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Category/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rs = _categoryService.GetCategory(id);
            if (rs == null)
            {
                return NotFound();
            }
            _categoryService.DeleteCategory(id);
            return RedirectToAction("Index");
        }

        
    }
}
