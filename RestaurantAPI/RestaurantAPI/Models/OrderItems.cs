using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurantAPI.Models
{
    public class OrderItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderItemId { get; set; }      

        public Nullable<int> Quantity { get; set; }

        public Nullable<int> OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Orders { get; set; }

        public Nullable<int> ItemId { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Items { get; set; }


    }
}