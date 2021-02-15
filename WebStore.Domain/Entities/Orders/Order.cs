using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Identity;

namespace WebStore.Domain.Entities.Orders
{
    public class Order : NamedEntity
    {
        [Required]
        public virtual User User { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public virtual ICollection<OrderItem> Items { get; set; } = new HashSet<OrderItem>();
    }

    public class OrderItem : Entity
    {
        [Required]
        public virtual Order Order { get; set; }

        [Required]
        public virtual Product Product { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [NotMapped]
        public decimal TotalItemPrice => Price * Quantity;
    }
}