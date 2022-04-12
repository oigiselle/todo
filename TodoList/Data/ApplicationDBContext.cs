using Microsoft.EntityFrameworkCore;
using System;
using TodoList.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace TodoList.Data
{
    public class ApplicationDBContext : DbContext 

        //parameters to dependency injection to add into a database
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Todos> Todos { get; set; }
    }
}
