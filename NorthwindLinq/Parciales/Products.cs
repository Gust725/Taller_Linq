using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindLinq
{
    public partial class Products
    {
        public string DescripcionProducto()
        {
            return ProductName + " - "+ UnitsInStock +" - " + UnitPrice;
        }
    }
}