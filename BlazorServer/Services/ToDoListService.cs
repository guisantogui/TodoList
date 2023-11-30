using ToDoListApp.Data.Entity;

namespace ToDoListApp.Services
{
    public class ToDoListService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

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
