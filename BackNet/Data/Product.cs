using System.ComponentModel.DataAnnotations.Schema;

namespace BackNet.Data
{
    public class Product
    {
        public long productID { get; set; }
        public required string  productName { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal price {get; set; }
        public long CategoryId {  get; set; }
        public Category? Category { get; set; }
        public long SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
