using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHoppingCart.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public string Price { get; set; }
        public string Photo { get; set; }

        public string Avaiablity { get; set; }
    }
}
