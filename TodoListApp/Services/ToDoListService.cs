using TodoListApp.Data.Entity;

namespace TodoListApp.Services
{
    public class ToDoListService: IToDoListService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public List<ToDoItem> GetAll()
        {
            throw new NotImplementedException();
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
