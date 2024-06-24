using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EF_Tutorial
{
    public class AppDbContext : DbContext //adds in the EntityFrameworkCore
    {
        public  DbSet<User> Users { get; set; } //tells entity framework what it can access
        

        public AppDbContext()//default constructor
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //overides one of the methods in the base class (DbContext).
                                                                                      //protected is a access modifer.
                                                                                      //protected says its private for all other classes except for the base class
                                                                                      //OnConfiguring is a method within DbContext
        {
            var connectionString = "Server = localhost\\sqlexpress01;database=tqlprsdb;trusted_connection=true;trustServerCertificate=true;";
            
            optionsBuilder.UseSqlServer(connectionString); //passes connection to Entity FrameWork
        }
    }
}
