using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class TodoListContext: DbContext
    {

        public TodoListContext(DbContextOptions<TodoListContext> options): base(options)
        {
            
        }

        public DbSet<ToDo> TodoSet { get; set; }
    }
}
