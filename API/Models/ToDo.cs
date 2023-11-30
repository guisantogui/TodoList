using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        
        public string Summary { get; set; }
    }
}
