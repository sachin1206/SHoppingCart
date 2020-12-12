using SHoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHoppingCart.Repository
{
    public class ProductRepository : IProductRepository
    {

        private List<Product> productsList = new List<Product>() {
            new Product(){ Id =121, Desciption= "Cisco Aironet", Name =" Tablet", Price ="$23",Avaiablity ="Instock"},
            new Product(){ Id =122, Desciption= "Apple", Name =" Tablet", Price ="$23",Avaiablity ="OutOfStock"},
            new Product(){ Id =123, Desciption= "Samsung Phone", Name =" Watch", Price ="$23",Avaiablity ="Instock"},
            new Product(){ Id =124, Desciption= "Television ", Name =" Laptop", Price ="$23",Avaiablity ="Instock"},
            new Product(){ Id =125, Desciption= "Cisco Aironet Access Point Module for 802.11ac", Name =" Mobile", Price ="$23",Avaiablity ="Instock"},
            new Product(){ Id =126, Desciption= "Saunsung Aironet Access Point Module for 802.11ac", Name =" Tablet", Price ="$23",Avaiablity ="Instock"},
            new Product(){ Id =121, Desciption= "Cisco Aironet", Name =" Tablet", Price ="$23",Avaiablity ="Instock"} };
    public Task<List<Product>> GetAllAsync()
    {
            return Task.Run(() => productsList);
       }

    public Task<Product> GetOneAsync(int productId)
    {
            return Task.Run(() => productsList.Where(x=>x.Id== productId).FirstOrDefault());
        }
    }
}
