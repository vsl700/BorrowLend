using BorrowLend.Data;
using BorrowLend.Models;
using BorrowLend.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BorrowLend.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;


        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        
        public IActionResult Index()
        {
            IEnumerable<Item> obj = _db.Items;
            return View(obj);
        }

        // Create Get
        public IActionResult Create()
        {
            ItemVM itemVM = new ItemVM();
            return View(itemVM);
        }

        //Create Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ItemVM itemVM)
        {
            if (ModelState.IsValid)
            {
                _db.Items.Add(itemVM.Item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemVM);
        }

        //Update Get
        public IActionResult Update(int? id)
        {
            var obj = _db.Items.Find(id);

            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Update Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Item obj)
        {
            if(obj == null)
            {
                return NotFound();
            }

            _db.Items.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Delete Get
        public IActionResult Delete(int? id)
        {
            var obj = _db.Items.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Items.Remove(obj);
            _db.SaveChanges();

            return /*View(obj)*/ RedirectToAction("Index");
        }

        //Delete Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Item obj)
        {
            if (obj == null)
            {
                return NotFound();
            }

            _db.Items.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
