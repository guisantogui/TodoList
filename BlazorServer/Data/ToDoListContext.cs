using ToDoListApp.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace ToDoListApp.Data
{
    public class ToDoListContext: DbContext
    {

        public ToDoListContext(DbContextOptions<ToDoListContext> options): base(options)
        {
            
        }

        public DbSet<ToDoItem> ToDoItemContext { get; set; }

    }
}
