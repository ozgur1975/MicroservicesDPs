using System.ComponentModel.DataAnnotations.Schema;

namespace Order.API.Model
{
    public class OrderItem
    {
        public int Id{ get; set; }
        public int ProductId { get; set; }
        [Column(TypeName ="decimal(19,2)")]
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int Count { get; set; }
    }
}

