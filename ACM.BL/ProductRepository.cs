using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product();
            if(productId == 2)
            {
                product.ProductName = "SunFlower";
                product.ProductDescription = "Assorted size set of 4 bright Yellow Minisonflower";
                product.CurrentPrice = 12.34M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object:{myObject.ToString()}");
            Console.WriteLine($"Object:{myObject.ToString()}");
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //Call an insert store procesure
                    }
                    else
                    {
                        //Call an update store proc
                    }
                }
                else
                {
                    return true;
                }
            }
            return success;
        }
    }
}
