using TodoListApp.Data.Entity;

namespace TodoListApp.Services
{
    public interface IToDoListService
    {
        List<ToDoItem> GetAll();

    }
}
