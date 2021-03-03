using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TIMG_BOL
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Column("Id")]
        public int OrderId { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string ClientName { get; set; }
        public Client Client { get; set; }
        public DateTime OrderDate { get; set; }
        [Column(TypeName = "smallmoney")]
        public decimal GST { get; set; }
        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
