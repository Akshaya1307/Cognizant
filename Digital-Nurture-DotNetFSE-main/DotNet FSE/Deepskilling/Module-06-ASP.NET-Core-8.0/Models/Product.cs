using System.ComponentModel.DataAnnotations;

namespace RetailInventory.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public ProductDetail? ProductDetail { get; set; }

        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}
