using TodoListApp.Data.Entity;

namespace TodoListApp.Services
{
    public interface IToDoListService
    {
        Task<List<ToDoItem>> GetAll();

        Task<ToDoItem[]> GetItems(DateTime startDate);


    }
}
