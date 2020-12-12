using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHoppingCart.Model
{
    public class ShoppingCart
    {
        BasketItem ItemDetails { get; set; }

        string ShoppingDate { get; set; }

        double TotalAmount { get; set; }
    }
}
