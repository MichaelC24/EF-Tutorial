using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EF_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext(); //creates an instance of AppDbContext

            var users = context.Users.ToList(); //gets all of the info from users and saves it to a list
            var vendors = context.Vendors.ToList();
            var products = context.Products.Include(x => x.Vendor).ToList();


            vendors.ForEach(v => {Console.WriteLine(v.Name);});

            products.ForEach(v => {Console.WriteLine($"Vendor Name: {v.Vendor!.Name} | Product Name: {v.Name}");});
        }
    }
}
