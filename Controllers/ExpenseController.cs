using BorrowLend.Data;
using BorrowLend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowLend.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _db;


        public ExpenseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Expense> obj = _db.Expenses;
            return View(obj);
        }

        // Create Get
        public IActionResult Create()
        {
            //ExpenseVM itemVM = new ExpenseVM();
            return View(/*itemVM*/);
        }

        //Create Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense item)
        {
            if (ModelState.IsValid)
            {
                _db.Expenses.Add(item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(item);
        }

        //Update Get
        public IActionResult Update(int? id)
        {
            var obj = _db.Expenses.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Update Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expense obj)
        {
            if (obj == null)
            {
                return NotFound();
            }

            _db.Expenses.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Delete Get
        public IActionResult Delete(int? id)
        {
            var obj = _db.Expenses.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Expenses.Remove(obj);
            _db.SaveChanges();

            return /*View(obj)*/ RedirectToAction("Index");
        }

        //Delete Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Expense obj)
        {
            if (obj == null)
            {
                return NotFound();
            }

            _db.Expenses.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
