using System.ComponentModel.DataAnnotations;

namespace TodoListApp.Data.Entity
{
    public class ToDoItem
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
