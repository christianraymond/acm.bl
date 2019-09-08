using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int? ProductId { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        private string _productName;
        public string ProductName { get { return _productName; } set { _productName = value; } }

        public override string ToString() => ProductName;
        public override bool Validate()
        {
            var isValid = true;
            if (String.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
