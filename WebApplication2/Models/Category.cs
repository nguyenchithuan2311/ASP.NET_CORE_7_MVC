using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
