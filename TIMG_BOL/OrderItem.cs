using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TIMG_BOL
{
    [Table("OrderItem")]
    public class OrderItem
    {
        [Key]
        [Column("Id")]
        public int OrderItemId { get; set; }
        [ForeignKey("Product")]
        [Column(TypeName = "NVARCHAR(50)")]
        public string ProductCode { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }
        [ForeignKey("Order")]
        [Column("ParentOrder")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
