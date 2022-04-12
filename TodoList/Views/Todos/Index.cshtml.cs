using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Views.Home.TodoList
{
    public class IndexModel : PageModel
    {
        private readonly Data.ApplicationDBContext _db;

        //retrieve all todos from database
        // using dependency injection again 
        public IndexModel(Data.ApplicationDBContext db)
        {
            _db = db;
        }
        //will extract  the applicationDbContect inside the dependency injection container into this page
        

        public IEnumerable<Todos> Todos { get; set; }


    }
}
