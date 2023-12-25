using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
        
    public int CategoryId { get; set; }
    
    public string Author { get; set; }

    public string ImageUrl { get; set; }

    public string Language { get; set; }

    public Category? Category { get; set; }
    public virtual ICollection<OrderItem>? OrderItems { get; set; }

}