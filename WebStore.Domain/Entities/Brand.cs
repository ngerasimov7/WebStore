using System.Collections.Generic;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
    //[Table("Brands")]
    public class Brand : NamedEntity, IOrderedEntity
    {
        //[Column("BrandOrder")]
        public int Order { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}