using BorrowLend.Data;
using BorrowLend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowLend.Controllers
{
    public class ExpenseTypeTypeController : Controller
    {
        private readonly ApplicationDbContext _db;


        public ExpenseTypeTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ExpenseType> obj = _db.ExpenseTypes;
            return View(obj);
        }

        // Create Get
        public IActionResult Create()
        {
            //ExpenseTypeVM itemVM = new ExpenseTypeVM();
            return View(/*itemVM*/);
        }

        //Create Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseType item)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseTypes.Add(item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(item);
        }

        //Update Get
        public IActionResult Update(int? id)
        {
            var obj = _db.ExpenseTypes.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Update Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExpenseType obj)
        {
            if (obj == null)
            {
                return NotFound();
            }

            _db.ExpenseTypes.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Delete Get
        public IActionResult Delete(int? id)
        {
            var obj = _db.ExpenseTypes.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.ExpenseTypes.Remove(obj);
            _db.SaveChanges();

            return /*View(obj)*/ RedirectToAction("Index");
        }

        //Delete Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(ExpenseType obj)
        {
            if (obj == null)
            {
                return NotFound();
            }

            _db.ExpenseTypes.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
