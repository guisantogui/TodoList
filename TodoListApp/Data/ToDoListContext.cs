using TodoListApp.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace TodoListApp.Data
{
    public class ToDoListContext: DbContext
    {

        public ToDoListContext(DbContextOptions<ToDoListContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

        public DbSet<ToDoItem> ToDoItem { get; set; }

    }
}
