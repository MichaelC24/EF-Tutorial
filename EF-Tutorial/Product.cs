using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial
{
    public class Product
    {
        public int Id { get; set; }
        public string PartNbr { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty ;
        public decimal Price { get; set; } = decimal.Zero;
        public string Unit {  get; set; } = string.Empty ;
        public string? PhotoPath {  get; set; } = string.Empty ;
        public int VendorId  { get; set; } 
        public virtual Vendor? Vendor { get; set; } // uses the relationship in sql to detect what column in the Product class is the
                                                    // foregin key and then compares the foregin key in the class to the primary key in the virtual property
                                                    // virtual says this property is not in this table in the database i.e. vendor is not in the product table.
                                                    //? is used so that you dont have to put all of the vendor info in everytime you try to add a Product.

    }
}
