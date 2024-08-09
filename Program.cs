using Crud_task.Context;
using Crud_task.Models;

namespace Crud_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbcontext = new ApplicationDbContext();

            dbcontext.Products.Add(new Product { Name = "Product 1", Price = 9.99 });
            dbcontext.Products.Add(new Product { Name = "Product 2", Price = 19.99 });
            dbcontext.Products.Add(new Product { Name = "Product 3", Price = 29.99 });
            dbcontext.SaveChanges();

            
            dbcontext.Orders.Add(new Order { Address = "123 Main St", CreatedAT = DateTime.Now });
            dbcontext.Orders.Add(new Order { Address = "456 Elm St", CreatedAT = DateTime.Now });
            dbcontext.Orders.Add(new Order { Address = "789 Oak St", CreatedAT = DateTime.Now });
            dbcontext.SaveChanges();


            var products = dbcontext.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

            var orders = dbcontext.Orders.ToList();
            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.Id}, Address: {order.Address}, Created At: {order.CreatedAT}");
            }

            var updateProductName = dbcontext.Products.First(p => p.Id == 1);
           
                updateProductName.Name = "ProductName";
                dbcontext.SaveChanges();
            

            
            var updateOrderCreatedAT = dbcontext.Orders.First(o => o.Id == 1);
           
                updateOrderCreatedAT.CreatedAT = new DateTime(2024, 8, 9, 12, 0, 0);
                dbcontext.SaveChanges();


            var removeProduct = dbcontext.Products.First(p => p.Id == 2);
            
                dbcontext.Products.Remove(removeProduct);
                dbcontext.SaveChanges();
            

            
            var removeOrder = dbcontext.Orders.First(o => o.Id == 3);
            
                dbcontext.Orders.Remove(removeOrder);
                dbcontext.SaveChanges();
            
        }
    }
}
