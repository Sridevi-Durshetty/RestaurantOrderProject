using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantAPI.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
       
        [Required]
        public string OrderNo { get; set; }

        public string PaymentMethod { get; set; }

        public decimal GrandTotal { get; set; }

        public Nullable<int> CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customers { get; set; }
    }
}