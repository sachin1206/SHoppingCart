using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHoppingCart.Model
{
    public class BasketItem
    {
        public BasketItem()
        {
            Product = new Product();
        }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }


    }
}
