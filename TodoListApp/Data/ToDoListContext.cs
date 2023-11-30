using TodoListApp.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace TodoListApp.Data
{
    public class ToDoListContext: DbContext
    {

        public ToDoListContext(DbContextOptions<ToDoListContext> options): base(options)
        {
            
        }

        public DbSet<ToDoItem> ToDoItemContext { get; set; }

    }
}
