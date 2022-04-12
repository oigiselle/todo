using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Data;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class TodosController : Controller
    {

        private readonly ApplicationDBContext _db;

        //retrieve all todos from database
        // using dependency injection again 
        public TodosController(ApplicationDBContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Todos> objList = _db.Todos as IEnumerable<Todos>;
            return View(objList);
        }


        // Create page - get
        public IActionResult Create()
        {

            return View();
        }

        // Create page - post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Todos obj)
        {
            if (ModelState.IsValid)
            {
                _db.Todos.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);


        }

        // Edit page - get
        public IActionResult Edit(int id)
        {
         
            var obj = _db.Todos.Find(id);
            if (obj == null) 
            {
                return NotFound();
            }
            return View(obj);
        }

        // Edit page - post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Todos obj)
        {
            if (ModelState.IsValid)
            {
                _db.Todos.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);


        }

        // Delete page - get
        public IActionResult Delete(int? id)
        {

            var obj = _db.Todos.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // Delete page - post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int? id)
        {
            var obj = _db.Todos.Find(id);

            if (obj == null) 
            { 
                return NotFound(); 
            }
            
                _db.Todos.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
          
            


        }
    }
}
