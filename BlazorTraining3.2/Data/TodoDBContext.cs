using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTraining3._2.Data
{
    public class TodoDBContext:DbContext
    {
        public DbSet<Aufgaben> Aufgabens { get; set; }
        public TodoDBContext(DbContextOptions<TodoDBContext> options):base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}
