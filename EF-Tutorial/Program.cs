using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace EF_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext(); //creates an instance of AppDbContext

            //var users = context.Users.ToList(); //gets all of the info from users and saves it to a list
            //var vendors = context.Vendors.ToList();
            var products = context.Products.Include(x => x.Vendor).ToList(); //creates an instance of products and includes Vendor
            var request = context.Requests.Include(x => x.User).ToList();
            
            var rl = context.Requestlines.Include(x => x.Product).Include(r => r.Request).ToList();
            

            //products.ForEach(v => { Console.WriteLine($"Vendor Name: {v.Vendor!.Name} | Product Name: {v.Name}"); });
            //request.ForEach(v => { Console.WriteLine($"Name: {v.User.Firstname} {v.User.Lastname} | Request: {v.Description}"); });
            rl.ForEach(v => { Console.WriteLine($"Request Description: {v.Request!.Description} | Product Name: {v.Product!.Name} | Quantity: {v.Quantity} | Price: {v.Product!.Price:C}"); });
            
        }
    }
}
