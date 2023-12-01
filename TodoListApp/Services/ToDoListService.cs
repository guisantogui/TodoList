using Microsoft.EntityFrameworkCore;
using TodoListApp.Data;
using TodoListApp.Data.Entity;

namespace TodoListApp.Services
{
    public class ToDoListService: IToDoListService
    {

        private readonly ToDoListContext _context;

        public ToDoListService(ToDoListContext context)
        {
            _context = context;
        }



        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<List<ToDoItem>> GetAll()
        {
            return Task.FromResult(_context.ToDoItem.ToList());
        }


        public Task<ToDoItem[]> GetItems(DateTime startDate)
        {




            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new ToDoItem
            {
                Title = Summaries[index],
                Description = "Some Description"

            }).ToArray());
        }



    }
}
