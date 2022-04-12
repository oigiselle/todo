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
    }
}
