using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TIMG_BOL
{
    [Table("Client")]
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClientId { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string ClientName { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
