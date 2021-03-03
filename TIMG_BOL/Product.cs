using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TIMG_BOL
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(TypeName = "NVARCHAR(50)")]
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        [Column(TypeName = "money")]
        public decimal ProductCost { get; set; }
    }
}
