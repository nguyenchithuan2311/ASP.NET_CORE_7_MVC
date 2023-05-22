using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get;set; }
        public decimal Price { get; set; }
        public int Quantity { get;set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        //Dieu huong
        public virtual Category? category { get; set; }
    }
}
